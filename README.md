
## Autonomous AI Systems: From Local Deployment to Agentic Applications
<img src="https://images.unsplash.com/photo-1671001803647-07e1bbb287b2?q=80&w=1332&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" width=840>

(Image credit: [Sufyan @blenderdesigner](https://unsplash.com/@blenderdesigner). Unsplash.com)
***
### Topic Overview

This five-session workshop provides comprehensive training in contemporary AI deployment methodologies, instructing participants in local Large Language Model execution using frameworks such as Ollama and LM Studio, while facilitating access to open-source models through platforms like AI VERDE. The curriculum encompasses advanced implementation strategies including Retrieval Augmented Generation (RAG) systems for enhanced factual accuracy and hallucination mitigation (Lewis et al., 2020), tool calling architectures for external API integration, and automated text-to-SQL code generation.

Supplemental methodologies include **AI-assisted coding techniques**, which leverage language models for code completion, debugging, and optimization workflows, enabling accelerated development cycles and improved code quality. Additionally, participants will explore **vibe coding approaches**—an emergent paradigm emphasizing intuitive, conversational programming interfaces that facilitate rapid prototyping and iterative development through natural language specifications.

The workshop culminates with comprehensive training in **agentic systems architecture**, where LLMs demonstrate autonomous multi-step reasoning capabilities, strategic planning algorithms, and complex task execution pipelines. These systems represent the current frontier in artificial intelligence applications, enabling sophisticated problem-solving through iterative agent-environment interactions and goal-oriented behavior optimization.


<!--
* Goodfellow, I., Bengio, Y., & Courville, A. (2016). [Deep Learning](https://www.deeplearningbook.org/). MIT Press. (A foundational textbook in deep learning).
* Ho, J., Jain, A., & Abbeel, P. (2020). [Denoising diffusion probabilistic models. Advances in Neural Information Processing Systems](https://proceedings.neurips.cc/paper/2020/file/4c5bcfec8584af0d967f1ab10179ca4b-Paper.pdf), 33, 6840-6851. (A key paper on diffusion models).
* LeCun, Y., Bengio, Y., & Hinton, G. (2015). [Deep learning. Nature, 521(7553), 436-444](https://www.nature.com/articles/nature14539.pdf). (A high-level overview of deep learning by pioneers in the field).
* Vaswani, A., Shazeer, N., Parmar, N., Uszkoreit, J., Jones, L., Gomez, A. N., ... & Polosukhin, I. (2017). [Attention is all you need](https://arxiv.org/abs/1706.03762). Advances in neural information processing systems, 30. (The seminal paper introducing the Transformer architecture).
-->

### References
* Lewis, P., Perez, E., Piktus, A., Petroni, F., Karpukhin, V., Goyal, N., ... & Kiela, D. (2020). [Retrieval-augmented generation for knowledge-intensive NLP tasks](https://proceedings.neurips.cc/paper/2020/file/6b493230205f780e1bc26945df7481e5-Paper.pdf). *Advances in Neural Information Processing Systems*, *33*, 9459-9474. (The seminal paper on RAG).
* Mialon, G., Dessì, R., Lomeli, M., Nalmpantis, C., Pasunuru, R., Raileanu, R., ... & Scialom, T. (2023). [Augmented Language Models: a Survey](https://arxiv.org/abs/2302.07842). *Transactions on Machine Learning Research*. (Provides a broad overview of how LLMs are augmented).
* Mithun, P., Noriega-Atala, E., Merchant, N., & Skidmore, E. (2025). [AI-VERDE: A Gateway for Egalitarian Access to Large Language Model-Based Resources For Educational Institutions](https://arxiv.org/abs/2502.09651). *arXiv:2502.09651*.
* Norman Di Palo and Arunkumar Byravan and Leonard Hasenclever and Markus Wulfmeier and Nicolas Heess and Martin Riedmiller. [Towards A Unified Agent with Foundation Models](https://arxiv.org/abs/2307.09668). *arXiv preprint 	arXiv:2307.09668*. (Discusses concepts relevant to agentic AI).

***

### Learning Goals

Upon completion of this eight-session workshop series, participants will be able to:

- **Identify Appropriate Model Applications:** Recognize which data types and tasks each architecture best handles (e.g., images, sequences, generative tasks) and understand their ideal application domains.
- **Appreciate Implementation Frameworks:** Develop familiarity with how these models are built using popular open-source deep learning libraries (e.g., TensorFlow, PyTorch) to support your continued learning and practical applications.
- **Deploy and Manage LLMs:** Gain hands-on experience setting up and running Large Language Models across different environments, including local instances (e.g., Ollama, LM Studio) and cloud platforms (e.g., AI VERDE).
- **Implement Advanced LLM Augmentation:** Learn to design and build Retrieval Augmented Generation (RAG) systems that connect LLMs with external knowledge sources to improve response accuracy and relevance.
- **Enable LLM-Powered Tool Interaction:** Create applications where LLMs seamlessly call external tools and APIs, with particular emphasis on practical applications like text-to-SQL generation.
- **Construct Basic AI Agents:** Master the fundamental principles of agentic AI systems and build simple agents that can plan and execute action sequences to accomplish specific goals.

***

## Fall 2025

**Instructors**:  **Enrique Noriega/ Carlos Lizárraga**

* [**Registration**]() to attend in person or online.

* **When**: Tuesday's at 1PM.

* **Where**: Albert B. Weaver Science-Engineering Library. Room 212 

* **Zoom**: (?)

_(Program not definitive!)_

***

## Workshop Sessions: Content Overview

| Date |  Topic |  Desciption |  Materials | Code | YouTube |
| :--: | :-- | :-- | :-- | :-- | :-- |
| 09/02  |  **Session 1: Running LLM Locally (Ollama, LM Studio)**  💻 | This session introduces the benefits and practicalities of running Large Language Models on local machines. It will cover **Ollama**, including installation, downloading models (e.g., Llama, Mistral), command-line interaction, and basic API access. It will also explore **LM Studio** as a user-friendly GUI for discovering, downloading, and interacting with various LLMs, including setting up a local inference server. Brief consideration of hardware requirements will be discussed. |  |  |  |
|  09/09 |  **Session 2: Using AI VERDE (Open-source LLMs)** |  This session will explore **AI VERDE** (or a similar institutional platform) as a gateway to accessing and utilizing a curated collection of open-source LLMs. Content will include an overview of the platform's objectives, how to navigate its interface, select different models for specific tasks, and any unique features it offers for research or educational purposes, such as integrated datasets or collaborative tools.  |  |  |  |
| 09/16  |  **Session 3: RAG (Retrieval Augmented Generation)** 📚 | This session dives into **Retrieval Augmented Generation (RAG)** to enhance LLM responses with external, up-to-date information. It will cover the core components: **document loading and chunking**, creating **embeddings** (e.g., using Sentence Transformers), setting up a **vector store** (e.g., FAISS, ChromaDB), and the **retrieval-then-generation** pipeline. The goal is to show how RAG mitigates hallucinations and grounds LLMs in specific knowledge domains.  |  |  |  |
| 09/23  |  **Session 4: Tool calling & SQL code generation** 🛠️ | This session covers LLM interaction with external tools and APIs. We'll explore **function calling** in GPT models, teaching participants to define tools, use them effectively, and process outputs. Examples include calculator operations and web search integration. We'll also cover **Text-to-SQL generation**, showing how LLMs can convert natural language to SQL queries. We'll discuss schema incorporation via RAG and handling different SQL dialects, with hands-on database practice. |  |  |  |
| 09/30 |  **Session 5: Agentic systems** 🤖 |  This session introduces the concept of **AI agents**—systems where LLMs are a core component that can reason, plan, and execute sequences of actions to achieve goals. It will cover basic agent architectures (e.g., **ReAct: Reason + Act**), the idea of an agent loop (observe, think, act), and how agents can utilize tools. An overview of simple agent development using frameworks like LangChain Agents or a conceptual design exercise will be included.  |  |  |  |

<!--
| 08/26 |  **Session 1: Perceptrons and Neural Networks** 🧠 | This session will cover the foundational concepts, starting with the **Perceptron** algorithm, its biological inspiration, and limitations (e.g., the XOR problem). It will then introduce **Multi-Layer Perceptrons (MLPs)**, the role of activation functions, the intuitive idea behind **backpropagation** for learning, and the structure of a basic neural network (input, hidden, output layers), along with an introduction to loss functions and gradient descent at a conceptual level. | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Perceptrons-and-Neural-Networks) | [Code](https://github.com/ua-datalab/MLWorkshops/blob/main/Perceptrons_and_Neural_Networks/Perceptron.ipynb) | Video() | 
| 09/09 | **Session 3: Autoencoders** 🗜️ | This session focuses on **Autoencoders** as a neural network architecture for unsupervised learning, primarily for **representation learning** and dimensionality reduction. It will explore the encoder-bottleneck-decoder structure, the concept of reconstruction loss, and briefly touch upon variants like Denoising Autoencoders and an introduction to the generative capabilities of Variational Autoencoders (VAEs). Applications like anomaly detection and data compression will be discussed.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Autoencoders) | [Code](https://nbviewer.org/github/ua-datalab/MLWorkshops/blob/main/Autoencoders/autoencoder.ipynb) | Video() | 
| 09/23 | **Session 5: GAN (Generative Adversarial Networks)** 🎭 | This session will introduce **Generative Adversarial Networks (GANs)**, explaining the innovative adversarial training process involving a **generator** and a **discriminator** locked in a minimax game. Key concepts like loss functions for both networks and common challenges such as mode collapse and training instability will be discussed, alongside examples of GANs' ability to generate realistic data, particularly images.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Generative-Adversarial-Networks) | [Code 1](https://github.com/ua-datalab/MLWorkshops/blob/main/GAN/GAN_Tutorial_1.ipynb) [Code 2](https://github.com/ua-datalab/MLWorkshops/blob/main/GAN/GAN_Tutorial_2.ipynb)| Video() | 
| 10/07 | **Session 7: CNN (Convolutional Neural Networks)** 🖼️ | This session delves into **Convolutional Neural Networks (CNNs)**, the workhorse for image processing and computer vision tasks. It will cover the core components: **convolutional layers** (filters, stride, padding), **pooling layers**, and the role of fully connected layers. The concepts of parameter sharing, local receptive fields, and hierarchical feature learning will be explained, with a brief mention of influential CNN architectures.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Convolutional-Neural-Networks) | [Code](https://nbviewer.org/github/ua-datalab/MLWorkshops/blob/main/Convolutional_Neural_Networks/CNN.ipynb) | Video() |
| 10/21  | **Session 9: RNN (Recurrent Neural Networks)** 🔄 |  This session focuses on **Recurrent Neural Networks (RNNs)**, designed to handle sequential data like text and time series. It will explain the concept of a **hidden state** that allows RNNs to have "memory," the challenges of training RNNs (vanishing/exploding gradients), and how variants like **LSTMs (Long Short-Term Memory)** and **GRUs (Gated Recurrent Units)** address these issues through gating mechanisms.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Recurrent-Neural-Networks) | [Code](https://github.com/ua-datalab/MLWorkshops/blob/main/RNN/pytorch_char_rnn_classification_tutorial.ipynb) | Video() | 
|  11/04 |  **Session 11: Transformers** 💡 |  Here we explore **Transformers**, this session will introduce the revolutionary "Attention is All You Need" concept. It will break down the **self-attention mechanism** (queries, keys, values), **Multi-Head Attention**, and the necessity of **positional encoding**. The discussion will focus on how attention allows models to weigh the importance of different parts of the input sequence, overcoming limitations of RNNs.  | [Notes]() | [Code]() | Video() | 
|   |  **Session 12: Modern Context Protocol (Claude SDK)** 📄 | This session focuses on effectively managing and utilizing context with modern LLMs, using the **Claude SDK** as a case study. It will cover best practices for structuring prompts, leveraging large context windows, and specific API features offered by Anthropic for tasks like document summarization, Q&A over long texts, and maintaining coherent conversations.  |  |  |  |
-->

***

# Past Workshops 

## Fall 2025

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

## Fall 2024

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
Created: 06/10/2024 (C. Lizárraga) <br> Updated: 06/18/2025 (C. Lizárraga)

<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Cc.logo.circle.svg/64px-Cc.logo.circle.svg.png" width=20> 2025. [University of Arizona DataLab](https://datascience.arizona.edu/education/uarizona-data-lab), [Data Science Institute](https://datascience.arizona.edu/).

<a href="https://creativecommons.org/licenses/by-nc-sa/4.0/"><img src="https://mirrors.creativecommons.org/presskit/buttons/88x31/png/by-nc-sa.png" width="128"></a>

[<img src="https://datascience.arizona.edu/sites/default/files/Data%20Science%20Institute_Webheader%20%281%29.svg" width="256">](https://datascience.arizona.edu)


 

