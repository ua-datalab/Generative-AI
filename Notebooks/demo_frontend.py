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

# --- File Upload ---
st.markdown("### 📂 Upload your requirements file here:")
uploaded_file = st.file_uploader("Choose a DOCX, TXT, or Markdown file", type=['docx', 'txt', 'md'])

# --- Helper Function to Read Files ---
def read_file(file):
    if file.name.endswith(".docx"):
        doc = Document(file)
        return "\n".join([para.text for para in doc.paragraphs])
    elif file.name.endswith((".txt", ".md")):
        return file.read().decode("utf-8")
    else:
        return ""

# --- Main Display Section ---
if uploaded_file:
    file_contents = read_file(uploaded_file)
    st.success(f"✅ File uploaded: {uploaded_file.name}")

    edited_text = st.text_area("📝 Edit your document below:", value=file_contents, height=400)

    # --- Save Button ---
    if st.button("💾 Save Edited File"):
        os.makedirs("edited", exist_ok=True)
        output_path = os.path.join("edited", f"edited_{uploaded_file.name}")
        with open(output_path, "w", encoding="utf-8") as f:
            f.write(edited_text)
        st.success(f"✅ Edited file saved as: `{output_path}`")
