import streamlit as st
from docx import Document
import os

# --- Streamlit Page Config ---
st.set_page_config(page_title="Code Factory", page_icon="🧠", layout="centered")

# --- Title and Intro ---
st.markdown("""
    <h1 style='text-align: center; color: #4B8BBE; font-size: 50px;'>
        🔧 Code Factory
    </h1>
    <p style='text-align: center; font-size: 18px; color: #555;'>
        Upload your requirements file and edit it directly below!
    </p>
    <hr style="border: 1px solid #bbb;">
""", unsafe_allow_html=True)

# --- Ensure edited folder exists ---
os.makedirs("edited", exist_ok=True)

# --- File Upload ---
st.markdown("### 📂 Upload your requirements file here:")
uploaded_file = st.file_uploader("Choose a DOCX, TXT, or Markdown file", type=['docx', 'txt', 'md'])

# --- Helper: Save uploaded file to ./edited/ ---
def save_uploaded_to_edited(uploaded_file):
    path = os.path.join("edited", uploaded_file.name)
    with open(path, "wb") as f:
        f.write(uploaded_file.read())
    return path

# --- Helper: Read from file ---
def read_file_from_path(path):
    if path.endswith(".docx"):
        doc = Document(path)
        return "\n".join([para.text for para in doc.paragraphs])
    else:
        with open(path, "r", encoding="utf-8") as f:
            return f.read()

# --- Upload Handling ---
if uploaded_file:
    st.success(f"✅ File uploaded: {uploaded_file.name}")

    # Save to edited folder
    saved_path = save_uploaded_to_edited(uploaded_file)

    # Read content from saved file
    file_contents = read_file_from_path(saved_path)

    # Editable text area
    edited_text = st.text_area("📝 Edit your document below:", value=file_contents, height=400)

    # Save edited version
    if st.button("💾 Save Edited File"):
        with open(saved_path, "w", encoding="utf-8") as f:
            f.write(edited_text)
        st.success(f"✅ Edited file saved to: `{saved_path}`")
