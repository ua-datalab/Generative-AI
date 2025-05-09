import warnings

warnings.filterwarnings("ignore")
from pprint import pprint

from langchain_community.document_loaders.generic import GenericLoader
from langchain_community.document_loaders.parsers import LanguageParser
from langchain_text_splitters import Language

loader = GenericLoader.from_filesystem(
    "./data/",
    glob="*",
    suffixes=[".vb", ".js"],
    parser=LanguageParser(),
)
docs = loader.load()

print(len(docs))
for document in docs:
    pprint(document.metadata)
    print(document.page_content)
print("\n\n--8<--\n\n".join([document.page_content for document in docs]))