

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
|  |  **Session 1: Perceptrons and Neural Networks** 🧠 | This session will cover the foundational concepts, starting with the **Perceptron** algorithm, its biological inspiration, and limitations (e.g., the XOR problem). It will then introduce **Multi-Layer Perceptrons (MLPs)**, the role of activation functions, the intuitive idea behind **backpropagation** for learning, and the structure of a basic neural network (input, hidden, output layers), along with an introduction to loss functions and gradient descent at a conceptual level. | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Perceptrons-and-Neural-Networks) | [Code](https://github.com/ua-datalab/MLWorkshops/blob/main/Perceptrons_and_Neural_Networks/Perceptron.ipynb) | Video() | 
|   |  **Session 2: Running LLM Locally (Ollama, LM Studio)**  💻 | This session introduces the benefits and practicalities of running Large Language Models on local machines. It will cover **Ollama**, including installation, downloading models (e.g., Llama, Mistral), command-line interaction, and basic API access. It will also explore **LM Studio** as a user-friendly GUI for discovering, downloading, and interacting with various LLMs, including setting up a local inference server. Brief consideration of hardware requirements will be discussed. |  |  |  |
|  | **Session 3: Autoencoders** 🗜️ | This session focuses on **Autoencoders** as a neural network architecture for unsupervised learning, primarily for **representation learning** and dimensionality reduction. It will explore the encoder-bottleneck-decoder structure, the concept of reconstruction loss, and briefly touch upon variants like Denoising Autoencoders and an introduction to the generative capabilities of Variational Autoencoders (VAEs). Applications like anomaly detection and data compression will be discussed.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Autoencoders) | [Code](https://nbviewer.org/github/ua-datalab/MLWorkshops/blob/main/Autoencoders/autoencoder.ipynb) | Video() | 
|   |  **Session 4: Using AI VERDE (Open-source LLMs)** V (assuming V is for VERDE) |  This session will explore **AI VERDE** (or a similar institutional platform) as a gateway to accessing and utilizing a curated collection of open-source LLMs. Content will include an overview of the platform's objectives, how to navigate its interface, select different models for specific tasks, and any unique features it offers for research or educational purposes, such as integrated datasets or collaborative tools.  |  |  |  |
|  | **Session 5: GAN (Generative Adversarial Networks)** 🎭 | This session will introduce **Generative Adversarial Networks (GANs)**, explaining the innovative adversarial training process involving a **generator** and a **discriminator** locked in a minimax game. Key concepts like loss functions for both networks and common challenges such as mode collapse and training instability will be discussed, alongside examples of GANs' ability to generate realistic data, particularly images.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Generative-Adversarial-Networks) | [Code 1](https://github.com/ua-datalab/MLWorkshops/blob/main/GAN/GAN_Tutorial_1.ipynb) [Code 2](https://github.com/ua-datalab/MLWorkshops/blob/main/GAN/GAN_Tutorial_2.ipynb)| Video() | 
|   |  **Session 6: RAG (Retrieval Augmented Generation)** 📚 | This session dives into **Retrieval Augmented Generation (RAG)** to enhance LLM responses with external, up-to-date information. It will cover the core components: **document loading and chunking**, creating **embeddings** (e.g., using Sentence Transformers), setting up a **vector store** (e.g., FAISS, ChromaDB), and the **retrieval-then-generation** pipeline. The goal is to show how RAG mitigates hallucinations and grounds LLMs in specific knowledge domains.  |  |  |  |
|  | **Session 7: CNN (Convolutional Neural Networks)** 🖼️ | This session delves into **Convolutional Neural Networks (CNNs)**, the workhorse for image processing and computer vision tasks. It will cover the core components: **convolutional layers** (filters, stride, padding), **pooling layers**, and the role of fully connected layers. The concepts of parameter sharing, local receptive fields, and hierarchical feature learning will be explained, with a brief mention of influential CNN architectures.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Convolutional-Neural-Networks) | [Code](https://nbviewer.org/github/ua-datalab/MLWorkshops/blob/main/Convolutional_Neural_Networks/CNN.ipynb) | Video() |
|   |  **Session 8: Tool calling & SQL code generation** 🛠️ | This session covers LLM interaction with external tools and APIs. We'll explore **function calling** in GPT models, teaching participants to define tools, use them effectively, and process outputs. Examples include calculator operations and web search integration. We'll also cover **Text-to-SQL generation**, showing how LLMs can convert natural language to SQL queries. We'll discuss schema incorporation via RAG and handling different SQL dialects, with hands-on database practice. |  |  |  |
|  | **Session 9: RNN (Recurrent Neural Networks)** 🔄 |  This session focuses on **Recurrent Neural Networks (RNNs)**, designed to handle sequential data like text and time series. It will explain the concept of a **hidden state** that allows RNNs to have "memory," the challenges of training RNNs (vanishing/exploding gradients), and how variants like **LSTMs (Long Short-Term Memory)** and **GRUs (Gated Recurrent Units)** address these issues through gating mechanisms.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Recurrent-Neural-Networks) | [Code](https://github.com/ua-datalab/MLWorkshops/blob/main/RNN/pytorch_char_rnn_classification_tutorial.ipynb) | Video() | 
|  |  **Session 10: Agentic systems** 🤖 |  This session introduces the concept of **AI agents**—systems where LLMs are a core component that can reason, plan, and execute sequences of actions to achieve goals. It will cover basic agent architectures (e.g., **ReAct: Reason + Act**), the idea of an agent loop (observe, think, act), and how agents can utilize tools. An overview of simple agent development using frameworks like LangChain Agents or a conceptual design exercise will be included.  |  |  |  |
|  |  **Session 11: Transformers** 💡 |  Here we explore **Transformers**, this session will introduce the revolutionary "Attention is All You Need" concept. It will break down the **self-attention mechanism** (queries, keys, values), **Multi-Head Attention**, and the necessity of **positional encoding**. The discussion will focus on how attention allows models to weigh the importance of different parts of the input sequence, overcoming limitations of RNNs.  | [Notes]() | [Code]() | Video() | 
|   |  **Session 12: Modern Context Protocol (Claude SDK)** 📄 | This session focuses on effectively managing and utilizing context with modern LLMs, using the **Claude SDK** as a case study. It will cover best practices for structuring prompts, leveraging large context windows, and specific API features offered by Anthropic for tasks like document summarization, Q&A over long texts, and maintaining coherent conversations.  |  |  |  |



***



 

