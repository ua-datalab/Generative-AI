import os
import json
from pathlib import Path
from chains.llm_proxy import build_llm_proxy


prompt_template_file="./data/clsColor_llm_prompt_dynamic_variables.txt"

dict_dynamic_business_object_names= {
    "{input_class_name}": "clsColor",
    "{output_class_name}": "clsBuyer"
}



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

llm_url ='https://llm-api.cyverse.ai'
api_key = os.environ.get('OPENAI_API_KEY')
print(f"api_key is:{api_key}")


llm = build_llm_proxy(
    # model="anthropic/claude-3-7-sonnet-20250219",
    # model="anthropic/claude-3-7-sonnet-latest",
    model ="gpt-4o",
    url=llm_url,
    engine="OpenAI",
    temperature=0.1,
    api_key=api_key,
)


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

prompt = inject_variables_into_template(prompt_template_file, dict_dynamic_business_object_names)
message = llm.invoke(prompt)
save_code_to_file(message.content, './outputs/buyer_created_by_llm_based_on_color_class.vb')
