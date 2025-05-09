from flask import Flask, request, jsonify
import os
from chains.llm_proxy import build_llm_proxy

app = Flask(__name__)

llm_url = 'https://llm-api.cyverse.ai'
api_key = os.environ.get('API_KEY')

llm = build_llm_proxy(
    model="anvilgpt/llama3.1:latest",
    url=llm_url,
    engine="OpenAI",
    temperature=0.9,
    api_key=api_key,
)

@app.route('/invoke', methods=['POST'])
def invoke():
    data = request.json
    prompt = data.get('prompt')
    
    if not prompt:
        return jsonify({"error": "No prompt provided"}), 400

    try:
        response = llm.invoke(prompt)
        return jsonify({"response": response})
    except Exception as e:
        return jsonify({"error": str(e)}), 500

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)