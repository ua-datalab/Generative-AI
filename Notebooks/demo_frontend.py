import streamlit as st

# Page config
st.set_page_config(page_title="Code Factory", page_icon="🧠", layout="centered")

# Title
st.markdown("""
    <h1 style='text-align: center; color: #4B8BBE; font-size: 50px;'>
        🔧 Code Factory
    </h1>
    <p style='text-align: center; font-size: 18px; color: #555;'>
        Upload your requirements file to begin building your code!
    </p>
""", unsafe_allow_html=True)

# Spacer
st.markdown("---")

# File uploader
st.markdown("### 📁 Upload your requirements file here:")
uploaded_file = st.file_uploader("Choose a file", type=['txt', 'pdf', 'docx', 'md'])

# Show file details
if uploaded_file is not None:
    st.success(f"✅ File uploaded: {uploaded_file.name}")
    file_details = {
        "Filename": uploaded_file.name,
        "File type": uploaded_file.type,
        "File size": f"{uploaded_file.size / 1024:.2f} KB"
    }
    st.json(file_details)
