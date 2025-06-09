
<img src="https://images.unsplash.com/photo-1655720855348-a5eeeddd1bc4?q=80&w=1932&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" width=860>

***

## Workshop: Navigating the Modern AI Landscape: RAG, Tool-Use, and Agents

### Topic Overview

This eight-session workshop is tailored for graduate students eager to move beyond foundational AI concepts and master the practical application of modern Large Language Model (LLM) operations and agentic systems. As LLMs become increasingly integrated into research and industry, this series focuses on equipping participants with the skills to deploy, customize, and extend these powerful tools. We'll begin by exploring how to **run LLMs locally** using tools like Ollama and LM Studio, fostering hands-on experience and an understanding of resource management. The workshop will also introduce platforms like **AI VERDE**, which facilitate access to a variety of open-source LLMs within institutional or research settings.

A significant portion of the series is dedicated to advanced LLM applications. Participants will learn to implement **Retrieval Augmented Generation (RAG)** systems, enabling LLMs to access and utilize external, up-to-date knowledge bases, thereby reducing hallucinations and improving factual accuracy (Lewis et al., 2020). We will then explore **tool calling**, a mechanism that allows LLMs to interact with external software and APIs, and a practical application of this in **text-to-SQL code generation**.

The workshop culminates in an exploration of **agentic systems**, where LLMs are empowered to reason, plan, and execute multi-step tasks. We'll also touch upon emerging standards and SDKs, such as Anthropic's approaches to context management with the **Claude SDK**, and practical data integration techniques using **Google Firebase** to support AI applications. Throughout the series, interdisciplinary use-cases will be highlighted, demonstrating how these advanced AI skills can enhance research, automate complex workflows, and develop innovative solutions across diverse academic fields.

**References for Overview:**

* Lewis, P., Perez, E., Piktus, A., Petroni, F., Karpukhin, V., Goyal, N., ... & Kiela, D. (2020). [Retrieval-augmented generation for knowledge-intensive NLP tasks](https://proceedings.neurips.cc/paper/2020/file/6b493230205f780e1bc26945df7481e5-Paper.pdf). *Advances in Neural Information Processing Systems*, *33*, 9459-9474. (The seminal paper on RAG).
* Mialon, G., Dessì, R., Lomeli, M., Nalmpantis, C., Pasunuru, R., Raileanu, R., ... & Scialom, T. (2023). [Augmented Language Models: a Survey](https://arxiv.org/abs/2302.07842). *Transactions on Machine Learning Research*. (Provides a broad overview of how LLMs are augmented).
* Norman Di Palo and Arunkumar Byravan and Leonard Hasenclever and Markus Wulfmeier and Nicolas Heess and Martin Riedmiller. [Towards A Unified Agent with Foundation Models](https://arxiv.org/abs/2307.09668). *arXiv preprint 	arXiv:2307.09668*. (Discusses concepts relevant to agentic AI).
* Anthropic. (Various documentation on [Claude SDK](https://docs.anthropic.com/en/docs/claude-code/sdk) and context management). (Specific SDK documentation provides context for modern LLM interaction).
* [Google Firebase](https://firebase.google.com/). (Various documentation on integrating Firebase with AI applications). (Platform documentation shows practical data backend integration).
* Mithun, P., Noriega-Atala, E., Merchant, N., & Skidmore, E. (2025). [AI-VERDE: A Gateway for Egalitarian Access to Large Language Model-Based Resources For Educational Institutions](https://arxiv.org/abs/2502.09651). *arXiv:2502.09651*. 

### Learning Goals

Upon completion of this eight-session workshop series, participants will be able to:

1. **Deploy and Manage LLMs:** Gain practical experience in setting up and running Large Language Models in various environments, including local instances (e.g., Ollama, LM Studio) and accessing them through dedicated platforms (e.g., AI VERDE).
2. **Implement Advanced LLM Augmentation:** Design and build Retrieval Augmented Generation (RAG) systems to connect LLMs with external knowledge sources, enhancing response relevance and accuracy.
3. **Enable LLM-Powered Tool Interaction:** Develop applications where LLMs can effectively call external tools and APIs, with a specific focus on tasks like text-to-SQL generation.
4. **Construct Basic AI Agents:** Understand the principles of agentic AI systems and build simple agents capable of planning and executing sequences of actions to achieve defined goals.
5. **Integrate LLMs with Modern Data Ecosystems:** Learn to utilize specific SDKs (like the Claude SDK) for sophisticated context management and integrate LLM applications with backend data solutions such as Google Firebase.

Okay, here's a list of the session topics for the workshop "Navigating the Modern AI Landscape: RAG, Tool-Use, and Agents," with a brief description of the possible content for each:


***

## Fall 2025

**Instructors**:  Nick Eddy /  Enrique Noriega/ Carlos Lizárraga 

* [**Registration**]() to attend in person or online.

* **When**: Thursdays at 1PM.

* **Where**: Albert B. Weaver Science-Engineering Library. Room 212 

* **Zoom**: (?)

_(Program not definitive!)_


## Workshop Sessions: Content Overview

| Date |  Topic |  Desciption |  Materials | Code | YouTube |
| :--: | :-- | :-- | :-- | :-- | :-- |
|  09/04 |  **Session 1: Running LLM Locally (Ollama, LM Studio)**  💻 | This session introduces the benefits and practicalities of running Large Language Models on local machines. It will cover **Ollama**, including installation, downloading models (e.g., Llama, Mistral), command-line interaction, and basic API access. It will also explore **LM Studio** as a user-friendly GUI for discovering, downloading, and interacting with various LLMs, including setting up a local inference server. Brief consideration of hardware requirements will be discussed. |  |  |  |
|  09/11 |  **Session 2: Using AI VERDE (Open-source LLMs)** V (assuming V is for VERDE) |  This session will explore **AI VERDE** (or a similar institutional platform) as a gateway to accessing and utilizing a curated collection of open-source LLMs. Content will include an overview of the platform's objectives, how to navigate its interface, select different models for specific tasks, and any unique features it offers for research or educational purposes, such as integrated datasets or collaborative tools.  |  |  |  |
| 09/18  |  **Session 3: RAG (Retrieval Augmented Generation)** 📚 | This session dives into **Retrieval Augmented Generation (RAG)** to enhance LLM responses with external, up-to-date information. It will cover the core components: **document loading and chunking**, creating **embeddings** (e.g., using Sentence Transformers), setting up a **vector store** (e.g., FAISS, ChromaDB), and the **retrieval-then-generation** pipeline. The goal is to show how RAG mitigates hallucinations and grounds LLMs in specific knowledge domains.  |  |  |  |
| 09/25  |  **Session 4: Tool calling** 🛠️ | This session focuses on enabling LLMs to interact with external tools and APIs, significantly expanding their capabilities. It will cover the concept of **function calling** (as seen in models like GPT) or similar mechanisms. Participants will learn how to define tools, how the LLM decides when and how to use a tool, and how to process the tool's output to inform the LLM's subsequent actions. Examples might include using a calculator or a simple web search API.  |  |  |  |
|  10/02 |  **Session 5: Text to SQL code generation** 📊 | A practical application of LLM capabilities, this session explores **Text-to-SQL generation**. It will cover techniques for prompting LLMs to convert natural language questions into SQL queries. Discussion will include the importance of providing schema information (potentially via RAG) for accuracy and how to handle different SQL dialects or complex queries. Participants might practice with sample database schemas.  |  |  |  |
| 10/09  |  **Session 6: Agentic systems** 🤖 |  This session introduces the concept of **AI agents**—systems where LLMs are a core component that can reason, plan, and execute sequences of actions to achieve goals. It will cover basic agent architectures (e.g., **ReAct: Reason + Act**), the idea of an agent loop (observe, think, act), and how agents can utilize tools. An overview of simple agent development using frameworks like LangChain Agents or a conceptual design exercise will be included.  |  |  |  |
|  10/16  |  **Session 7: Modern Context Protocol (Claude SDK)** 📄 | This session focuses on effectively managing and utilizing context with modern LLMs, using the **Claude SDK** as a case study. It will cover best practices for structuring prompts, leveraging large context windows, and specific API features offered by Anthropic for tasks like document summarization, Q&A over long texts, and maintaining coherent conversations.  |  |  |  |
| 10/23  |  **Session 8: Google Firebase** 🔥 | This session explores **Google Firebase** as a Backend-as-a-Service (BaaS) to support AI and LLM-powered applications. It will highlight key Firebase services such as **Firestore/Realtime Database** for storing application data (e.g., chat histories, user profiles, RAG vector metadata) and **Cloud Functions** for deploying serverless backend logic that might interact with LLM APIs or manage data processing pipelines.  |  |  |  |



***

### Past SPRING 2025 Workshop

| Date      | Title      | Topic Description     | Wiki/Slides      | YouTube | Instructor | 
| :--: | :-- | :--      | :--  | :--       | :--: | 
|  01/30/2025 | Scaling up Ollama: Local, CyVerse, HPC | In this hands-on workshop, participants will learn to deploy and scale large language models using Ollama across various computational environments—from laptops to supercomputing clusters—to master practical AI capabilities. | | [video](https://youtu.be/SuLc1bk3994?si=hc2tmI-L8ScnL-Eg)  | Enrique Noriega|
| 02/06/2025 | Using AI Verde  | This practical introduction shows how to effectively use U of A Generative AI Verde for academic research, writing, and problem-solving. Participants will learn to harness AI Verde's capabilities while gaining a clear understanding of its limitations and ethical implications. | | [video](https://youtu.be/M9Vos5LiwUo?si=8IBW006F7XNnA_gi)   | Nick Eddy |
|  02/13/2025| Best practices of Prompt Engineering using AI Verde | A hands-on session that teaches practical prompt engineering techniques to optimize U of A Generative AI Verde's performance for academic and professional applications. | [Slides](https://docs.google.com/presentation/d/1zx_6tRUo5m9Yz2nDOAg54di3bhHuW9KVx_7MQFI4yoE/edit?usp=sharing)  | [video](https://youtu.be/pVHeHTTNekY?si=ZxM4UAZq6ncIVtkZ) |Mithun Paul |
| 02/20/2025 | Quick RAG application using AI Verde / HPC | A hands-on session demonstrating how to build a basic Retrieval-Augmented Generation (RAG) system with the U of A Generative AI Verde API. Participants will learn to enhance AI responses by integrating custom knowledge bases. | [Slides](https://docs.google.com/presentation/d/1gMcJ348LLNRXgsXpFikIV_Fj-Cp5UMADzPOB_JJqdhA/edit?usp=sharing) | [video](https://youtu.be/Lwmhiwr4vwY?si=0nge273oFmW2eeQO) | Mithun Paul| 
| 02/27/2025 |  Multimodal Q&A+OCR in AI Verde | A hands-on technical session exploring U of A Generative AI's multimodal capabilities that combines vision and text processing for enhanced document analysis and automated question-answering with OCR technology. | | [video](https://youtu.be/GdzIn5FanFc?si=1C77kkR_53pSpUQY) | Nick Eddy  |
| 03/06/2025 | SQL specialized query code generation |  A hands-on session teaching participants how to use Large Language Models to craft, optimize, and validate complex SQL queries, emphasizing real-world database operations and industry best practices. | [Slides](https://docs.google.com/presentation/d/1JK48gWwOF-B2rIP77V0KcPAaKgvK4RADO1Xvn1Gv29k/edit?usp=sharing), [Code](https://github.com/enoriega/pmc-llm-index) | [video]() | Enrique Noriega |
| 03/13/2025  | **NO Session** | **Spring Break** | | |
| 03/20/2025 | Function calling with LLMs | There are two ways to implement function calling with open-source large language models (LLMs). When an LLM doesn't natively support function calling, you can combine prompt engineering, fine-tuning, and constrained decoding. | | [video]() | Enrique Noriega | 
| 03/27/2025 | Code generation assistants |  Large Language Models (LLMs) now serve as powerful code generation assistants, streamlining and enhancing software development. They generate code snippets, propose solutions, and translate code between programming languages.| | [video]() | Nick Eddy  | 


***

# Fall 2024

| Date      | Title      | Topic Description         | YouTube | Instructor |  
|:--: | :-- | :--         | :--: | :-- | 
| 09/05/2024 | [Hugging Face Models (NLP)](https://github.com/ua-datalab/Generative-AI/wiki/NLP-with-Hugging-Face-Transformers) | Hugging Face offers a vast array of pre-trained models for Natural Language Processing (NLP) tasks. These models cover a wide spectrum of applications, from text generation and translation to sentiment analysis and question answering. |[video](https://youtu.be/IJn9r6pJykw?si=3pOob4Iwnucjp50Y)  |  Enrique Noriega|
| 09/12/2024 | [Hugging Face Models (Computer Vision)](https://github.com/ua-datalab/Generative-AI/wiki/Computer-Vision-with-Hugging-Face-Transformers)| Hugging Face has significantly expanded its offerings beyond NLP to encompass a robust collection of computer vision models. You can find pre-trained models for a wide range of tasks, from basic image classification to complex image generation.  | [video](https://youtu.be/uNXeV-uQdOo?si=Lqn-FYXEb700cP6q)  | Enrique Noriega |
| 09/19/2024  | [Hugging Face Models (Multimodal)](https://github.com/ua-datalab/Generative-AI/wiki/Multimodal-LLM-with-Hugging-Face-Transformers)|  Hugging Face offers a diverse range of multimodal models, capable of processing and understanding multiple data modalities such as text, images, and audio. These models are at the forefront of AI research and development, enabling innovative applications.  | [video](https://youtu.be/99Nb6XLOwqE?si=M-L0-tSlQRD6wmPE)  | Enrique Noriega  |
| 09/26/2024  | [Running LLM locally: Ollama](https://github.com/ua-datalab/Generative-AI/wiki/Running-LLM-Locally:-Ollama)  | Ollama is an open-source platform designed to make running large language models (LLMs) on your local machine accessible and efficient. It acts as a bridge between the complex world of LLMs and users who want to experiment and interact with these models without relying on cloud-based services.  | [video](https://youtu.be/Ywi57myR-Q8?si=F5_T0cxOQQIoconA)  | Carlos Lizárraga|
| 10/03/2024  |  [Introduction to LangChain](https://github.com/ua-datalab/Generative-AI/wiki/Introduction-to-Langchain) | Langchain is an open-source Python library that provides a framework for developing applications powered by large language models (LLMs). It simplifies the process of building complex LLM-based applications by offering tools and abstractions to connect LLMs with other data sources and systems. | [video](https://youtu.be/EWOJwNoeIa0?si=VV3OpSzekEUqj6EN)  | Enrique Noriega |
| 10/10/2024  | [Getting Started with Phi-3](https://github.com/ua-datalab/Generative-AI/wiki/Getting-started-with-Phi%E2%80%903) | Phi-3 is a series of small language models (SLMs) developed by Microsoft. Unlike larger language models (LLMs) that require substantial computational resources, Phi-3 models offer impressive performance while being significantly smaller and more efficient.| [video](https://youtu.be/lo8Zdytfx9I?si=WUYZff5Dl5S2j5C_)  |  Enrique Noriega |
| 10/17/2024 | [Getting started with Gemini](https://github.com/ua-datalab/Generative-AI/wiki/Getting-started-with-Gemini)  | Gemini is a large language model (LLM) developed by Google AI. It's designed to be exceptionally versatile, capable of handling a wide range of tasks and modalities, including text, code, audio, and images. This makes it a significant advancement in the field of artificial intelligence. | [video](https://youtu.be/kVP7hI5PxX0?si=99ZbPvRzuum4WWhG)  | Enrique Noriega |
| 10/24/2024 | [Introduction to Gradio](https://github.com/ua-datalab/Generative-AI/wiki/Introduction-to-Gradio) | Gradio is an open-source Python library that allows you to quickly create user interfaces for your machine learning models, APIs, or any Python function. It simplifies the process of building interactive demos and web applications without requiring extensive knowledge of JavaScript, CSS, or web development.| [video](https://youtu.be/JHIKpScQcg8?si=MF4KTeBoOFgbYvKg)  | Enrique Noriega |
| 10/31/2024 | [Introduction to RAG](https://github.com/ua-datalab/Generative-AI/wiki/Introduction-to-RAG) | Retrieval-Augmented Generation. It's a technique that enhances the capabilities of Large Language Models (LLMs) by combining them with external knowledge sources.  | [video](https://youtu.be/5pnl0Y64JFQ?si=MmGsD8gTKQfKlzF5)  | Enrique Noriega |
| 11/15/2024 | Dense Passage Retrieval  |  | [video](https://youtu.be/xY010hbBnG4?si=nHE9QnjEXg4yTwmj) | Mithun Paul |  

****
Created: 06/10/2024 (C. Lizárraga) <br> Updated: 06/09/2025 (C. Lizárraga)

<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Cc.logo.circle.svg/64px-Cc.logo.circle.svg.png" width=20> 2025. [University of Arizona DataLab](https://datascience.arizona.edu/education/uarizona-data-lab), [Data Science Institute](https://datascience.arizona.edu/).

<a href="https://creativecommons.org/licenses/by-nc-sa/4.0/"><img src="https://mirrors.creativecommons.org/presskit/buttons/88x31/png/by-nc-sa.png" width="128"></a>

[<img src="https://datascience.arizona.edu/sites/default/files/Data%20Science%20Institute_Webheader%20%281%29.svg" width="256">](https://datascience.arizona.edu)
