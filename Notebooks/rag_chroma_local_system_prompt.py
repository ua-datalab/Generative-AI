# %%
import os
from pathlib import Path
import chromadb
# from chromadb.config import Settings
from langchain_chroma import Chroma

# Path to the ChromaDB storage
vdb_dir = "./pdfs"

# %%
# pip install -qU "langchain-huggingface" langchain openai langchain-openai langchain-community Langchainhub langchain_chroma chromadb PyMuPDF langchain-community


# %%
from langchain.chat_models import ChatOpenAI
# from langchain.embeddings.openai import OpenAIEmbeddings
# from langchain.vectorstores import FAISS
# from langchain.text_splitter import CharacterTextSplitter
# from langchain.document_loaders import TextLoader
# from langchain.schema import Document
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

def load_chunk_persist_pdf(pdf_folder_path) -> Chroma:    
    documents = []
    for file in os.listdir(pdf_folder_path):
        if file.endswith('.pdf'):
            pdf_path = os.path.join(pdf_folder_path, file)
            loader = PyPDFLoader(pdf_path)
            documents.extend(loader.load())
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

# Initialize the RAG pipeline
def create_rag_chain(vectorstore):
    llm = ChatOpenAI(model_name="Llama-3.2-11B-Vision-Instruct", temperature=0, base_url="https://llm-api.cyverse.ai", api_key="sk-hQh-wEV81QhGxP-QE0FXxQ")
    retriever = vectorstore.as_retriever()
    
    conversation_template = ChatPromptTemplate([
        ("system", """You will look at the following passages and reply to the question using only and only the information present in the following documents.
             You will not refer to the information, just write the answer. After you give the answer, cite the section from which you read it.
             If the information requested is not present in the documents or if the question can not be answered using the documents as context, just say that you can't answer the question
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
vectorstore = load_chunk_persist_pdf(vdb_dir)
rag_chain = create_rag_chain(vectorstore)

while True:
    # Query the RAG system
    user_input = input("Enter a command (or type 'exit' to quit): ")
    # Check if the user wants to exit the loop
    if user_input.lower() == 'exit':
            print("Exiting the program.")
            break
        
        # Process the user input (you can add any logic here)
    print(f"You entered: {user_input}")
    # query = "who is the author of Combining Symbolic and Distributional Models of Meaning"
    response = rag_chain.invoke(user_input)
    print(f"answer to your query is: {response}")


# %%



