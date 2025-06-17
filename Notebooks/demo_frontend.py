import streamlit as st
import os
import subprocess
import base64
import time

# Set Streamlit page configuration
st.set_page_config(page_title="Code Factory", page_icon="⚙️", layout="centered")

# Custom CSS for gradient background and animation
st.markdown("""
    <style>
    body {
        background: linear-gradient(135deg, #e0c3fc, #8ec5fc);
        animation: fadeIn 1.5s ease-in;
    }
    @keyframes fadeIn {
        from { opacity: 0; transform: translateY(-10px); }
        to { opacity: 1; transform: translateY(0); }
    }
    .stButton>button {
        background-color: #4B8BBE;
        color: white;
        border-radius: 10px;
        padding: 0.5em 2em;
        font-weight: bold;
        transition: 0.3s ease;
    }
    .stButton>button:hover {
        background-color: #306998;
        transform: scale(1.05);
    }
    </style>
""", unsafe_allow_html=True)

# App Title
st.markdown("""
    <h1 style='text-align: center; color: #222;'>
        ⚙️ Code Factory
    </h1>
    <p style='text-align: center; font-size: 16px; color: #444;'>
        Upload your requirements file and let the magic begin!
    </p>
    <hr style='border: 1px solid #ccc;'>
""", unsafe_allow_html=True)

# Upload Section
st.markdown("### 📂 Upload your requirements file here:")
uploaded_file = st.file_uploader("Choose a DOCX file", type=['docx'])

# File handling
if uploaded_file is not None:
    st.success(f"✅ File uploaded: {uploaded_file.name}")

    # Save file to temp location
    save_path = os.path.join("temp", uploaded_file.name)
    os.makedirs("temp", exist_ok=True)
    with open(save_path, "wb") as f:
        f.write(uploaded_file.read())
    
    st.write("📄 File saved locally as:", save_path)

    # Delay for UX
    with st.spinner("🔄 Launching VB.NET engine..."):
        time.sleep(1)

        # Run VB.NET app via dotnet
        vbnet_path = os.path.abspath("./VbNetApp")
        try:
            result = subprocess.run(
                ["dotnet", "run"],
                cwd=vbnet_path,
                capture_output=True,
                text=True,
                timeout=30
            )
            st.code(result.stdout, language='text')
            if result.stderr:
                st.error(f"⚠️ VB.NET Error:\n{result.stderr}")
        except subprocess.TimeoutExpired:
            st.error("⏱️ VB.NET execution timed out.")
        except Exception as e:
            st.error(f"💥 Failed to run VB.NET program: {str(e)}")
