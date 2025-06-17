import os
import json
from pathlib import Path
from chains.llm_proxy import build_llm_proxy
import datetime

prompt_file_name="./data/all_prompts/prompt_to_find_missing_constants_from_buyer_files.txt"
output_file_name="./outputs/dictionary_frm_clsBuyer_related_classes.txt"

# dict_dynamic_business_object_names= {
#     "{input_class_name}": "clsColors",
#     "{output_class_name}": "clsBuyers"
# }
# input_class_path="./data/color_related/clsColors.vb"

llm_url ='https://llm-api.cyverse.ai'
api_key = os.environ.get('OPENAI_API_KEY')
print(f"api_key is:{api_key}")


llm = build_llm_proxy(
    # model="anthropic/claude-3-7-sonnet-20250219",
    # model="anthropic/claude-3-7-sonnet-latest",
    model ="gpt-4o",
    # model ="gpt-4",
    # model ="gpt-4o-mini",    
    # model ="anvilgpt/llama3:70b",
    # model ="anvilgpt/codegemma:latest", 
    # model ="Qwen2.5-Coder-32B-Instruct", 
    # model ="anvilgpt/codegemma:latest", 
    url=llm_url,
    engine="OpenAI",
    temperature=0.9,
    api_key=api_key,
)



def inject_variables_into_template(template_file_path, variable_values):
    """
    Reads a text template from a file, replaces placeholders with 
    specified variable values, and returns the resulting text.

    Args:
        template_file_path (str): The path to the template file.
        variable_values (dict): A dictionary where keys are the 
                               placeholder names (e.g., "{variable_name}")
                               and values are the strings to inject.

    Returns:
        str: The template text with variables injected, or None if the 
             template file could not be read.
    """
    try:
        with open(template_file_path, 'r') as f:
            template_text = f.read()
    except FileNotFoundError:
        print(f"Error: Template file not found at '{template_file_path}'")
        return None
    except IOError:
        print(f"Error: Could not read template file at '{template_file_path}'")
        return None


    # Perform the variable injection.  We iterate through the dictionary 
    # and replace each placeholder in turn.
    for placeholder, value in variable_values.items():
        template_text = template_text.replace(placeholder, value)  # Important: replace all occurrences

    return template_text



def read_vbnet_file(file_path):
    try:
        with open(file_path, 'r', encoding='utf-8') as file:
            content = file.read()
            return content
    except FileNotFoundError:
        print(f"The file at {file_path} was not found.")
    except Exception as e:
        print(f"An error occurred: {e}")


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

# prompt_without_input_class = inject_variables_into_template(prompt_template_file, dict_dynamic_business_object_names)
prompt = read_vbnet_file(prompt_file_name)
# from datetime import datetime
# current_time = datetime.now()
# print(current_time)
# prompt = f"{current_time} use this as the time stamp for '* Created on" + prompt 
message = llm.invoke(prompt)
save_code_to_file(message.content, output_file_name)
