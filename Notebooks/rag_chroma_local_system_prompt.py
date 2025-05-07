# %%
import os
from pathlib import Path
import chromadb
from langchain_chroma import Chroma
import chromadb
from chromadb.config import Settings
from langchain.text_splitter import CharacterTextSplitter
from langchain.embeddings import SentenceTransformerEmbeddings
import os
import warnings

warnings.filterwarnings("ignore")
from pprint import pprint

from langchain_community.document_loaders.generic import GenericLoader
from langchain_community.document_loaders.parsers import LanguageParser
from langchain_text_splitters import Language



# Path to the ChromaDB storage
vdb_dir = "./data"

# %%
# pip install -qU "langchain-huggingface" langchain openai langchain-openai langchain-community Langchainhub langchain_chroma chromadb PyMuPDF langchain-community


# %%
from langchain.chat_models import ChatOpenAI
from langchain_huggingface import HuggingFaceEmbeddings
from langchain_core.prompts import ChatPromptTemplate
from langchain_core.runnables import RunnableLambda, RunnablePassthrough
from langchain_core.output_parsers import StrOutputParser


from langchain.document_loaders import PyPDFLoader
from langchain.text_splitter import CharacterTextSplitter
from langchain.embeddings import OpenAIEmbeddings
from langchain.chains.question_answering import load_qa_chain
from langchain.chat_models import ChatOpenAI
from langchain.vectorstores import Chroma
import chromadb

def format_message(msgs):
  return '\n\n'.join([f"Section: {next(iter(msg.metadata.values()))}\n Contents: {msg.page_content}" for msg in msgs])

embeddings = HuggingFaceEmbeddings(model_name="all-MiniLM-L6-v2")
# Load and preprocess documents

# Create embeddings and store them in FAISS
def setup_vectorstore():
    vectordb = Chroma(persist_directory=vdb_dir, embedding_function=embeddings)
    #retriever = vectordb.as_retriever()
    return vectordb


def save_code_to_file(code_content, filename):
    """
    Save code content to a specified file on disk
    
    Args:
        code_content (str): The VB.NET code to save
        filename (str): The path and filename to save the code to
    """
    try:
        with open(filename, 'w', encoding='utf-8') as file:
            file.write(code_content)
        print(f"File successfully saved to {filename}")
    except IOError as e:
        print(f"Error saving file: {e}")

def load_chunk_persist_pdf(pdf_folder_path) -> Chroma:    
    documents = []
    # for file in os.listdir(pdf_folder_path):
    #     if file.endswith('.pdf'):
    #         pdf_path = os.path.join(pdf_folder_path, file)
    #         loader = PyPDFLoader(pdf_path)
    #         documents.extend(loader.load())

     # Loop through all .txt files in the directory
    for file_name in os.listdir(pdf_folder_path):
        if file_name.endswith('.txt'):
            file_path = os.path.join(pdf_folder_path, file_name)
            
            # Read the text file
            with open(file_path, 'r', encoding='utf-8') as file:
                text = file.read()
                
            # Split text into chunks    
            # chunks = text_splitter.split_text(text)
            documents.append(text)
    text_splitter = CharacterTextSplitter(chunk_size=1000, chunk_overlap=10)
    chunked_documents = text_splitter.split_documents(documents)
    client = chromadb.Client()
    if client.list_collections():
        consent_collection = client.create_collection("consent_collection")
    else:
        print("Collection already exists")
    
    vectordb = Chroma.from_documents(
        documents=chunked_documents,
        embedding=embeddings,
        persist_directory=pdf_folder_path
    )
    vectordb.persist()
    return vectordb



def load_chunk_persist_txt(data_folder_path: str, chroma_collection_name: str)->Chroma :
    loader = GenericLoader.from_filesystem(
        "./data/",
        glob="*",
        suffixes=[".vb", ".js"],
        parser=LanguageParser(),
    )
    documents = loader.load()
    text_splitter = CharacterTextSplitter(chunk_size=5000, chunk_overlap=10)
    chunked_documents = text_splitter.split_documents(documents)
    
    client = chromadb.PersistentClient(path="./chromadb_persistence")
    print(client.heartbeat())
    if client.list_collections():
        consent_collection = client.create_collection("consent_collection")
    else:
        print("Collection already exists")
    
    vectordb = Chroma.from_documents(
        documents=chunked_documents,
        embedding=embeddings,
        persist_directory=data_folder_path
    )
    vectordb.persist()
    return vectordb


# Initialize the RAG pipeline
def create_rag_chain(vectorstore):
    llm = ChatOpenAI(model_name="gpt-4o", temperature=0, base_url="https://llm-api.cyverse.ai", api_key="sk-hQh-wEV81QhGxP-QE0FXxQ")
    retriever = vectorstore.as_retriever()
    
    conversation_template = ChatPromptTemplate([
        ("system", """Use the vb.net code present in the file
         clsBuyers.vb, which shows classes for buyers. Now do
         the following command based on the features of this code. 
             ```{context}```
             """),
    ("human", """Question: ```{question}```
    Answer: """)
    ])
    
    chain = {
        "context": retriever | RunnableLambda(format_message),
        "question": RunnablePassthrough()
    } | conversation_template | llm | StrOutputParser()
    
    
    return chain

# Main execution
#documents = load_documents()
# load_chunk_persist_pdf()
# vectorstore = setup_vectorstore()

# to load input files as pdf
# vectorstore = load_chunk_persist_pdf(vdb_dir)

#to load input files as code
vectorstore = load_chunk_persist_txt(vdb_dir,"mychroma")
rag_chain = create_rag_chain(vectorstore)

# ## uncomment this if you want a continous user interaction as opposed to a one time command run
# while True:
#     # Query the RAG system
#     user_input = input("Enter a command (or type 'exit' to quit): ")
#     # Check if the user wants to exit the loop
#     if user_input.lower() == 'exit':
#             print("Exiting the program.")
#             break
        
#         # Process the user input (you can add any logic here)
#     print(f"You entered: {user_input}")
#     # query = "who is the author of Combining Symbolic and Distributional Models of Meaning"
#     response = rag_chain.invoke(user_input)
#     print(f"answer to your query is: {response}")


user_input = "now create a similar code for customer class"
vbnet_code = rag_chain.invoke(user_input)
print(f"answer to your query is: {vbnet_code}")

save_code_to_file(vbnet_code.content, './outputs/customer.vb')

# %%



