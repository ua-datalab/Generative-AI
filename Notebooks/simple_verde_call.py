#simple call to verde



import os
from pathlib import Path


llm_url ='https://llm-api.cyverse.ai'
# openai_api_key = os.environ.get('OPENAI_API_KEY')
api_key = os.environ.get('API_KEY')
from chains.llm_proxy import build_llm_proxy

llm = build_llm_proxy(
    model="anvilgpt/llama3.1:latest",
    # model="gpt-4o",
    url=llm_url,
    engine="OpenAI",
    temperature=0.9,
    api_key=api_key,
)


message = llm.invoke("what is the largest wildfire in California")
print(message)
