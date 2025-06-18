
## Foundation Models to Autonomous Agents: From Neural Networks to Modern AI Systems

<img src="https://images.unsplash.com/photo-1671001803647-07e1bbb287b2?q=80&w=1332&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" width=840>

(Image credit: [Sufyan @blenderdesigner](https://unsplash.com/@blenderdesigner). Unsplash.com)
***
### Topic Overview

This comprehensive eight-session workshop guides participants through the evolution of machine learning—from foundational neural networks to cutting-edge AI architectures and their practical deployment. Designed for graduate students with basic machine learning knowledge, the series explores both theoretical foundations and hands-on implementation of transformative AI technologies.

The workshop begins with architectural fundamentals, covering Perceptrons, Neural Networks, Autoencoders, GANs, CNNs, and RNNs, before advancing to the Transformers and Diffusion Models that dominate contemporary AI (Vaswani et al., 2017; Ho et al., 2020). Participants will master the conceptual mechanisms and breakthrough innovations behind each architecture.

The series then moves to practical modern AI deployment, teaching participants how to run Large Language Models locally using tools like Ollama and LM Studio, and access open-source models through platforms like AI VERDE. Advanced applications include implementing Retrieval Augmented Generation (RAG) systems to enhance factual accuracy and reduce hallucinations (Lewis et al., 2020), tool calling mechanisms for external API integration, and text-to-SQL code generation.

The workshop culminates with agentic systems, where LLMs perform multi-step reasoning, planning, and task execution. Participants will explore emerging standards, including Anthropic's Claude SDK for context management and Google Firebase for AI application data integration.

Throughout the series, real-world applications spanning drug discovery, medical imaging, climate science, robotics, and creative arts demonstrate AI's broad impact. The workshop addresses ethical considerations and societal implications to foster responsible AI development. By emphasizing both theoretical understanding and practical implementation through popular open-source frameworks, participants will gain the skills to deploy, customize, and extend modern AI systems in their research domains.

**References for Overview:**

* Anthropic. (Various documentation on [Claude SDK](https://docs.anthropic.com/en/docs/claude-code/sdk) and context management). (Specific SDK documentation provides context for modern LLM interaction).
* Goodfellow, I., Bengio, Y., & Courville, A. (2016). [Deep Learning](https://www.deeplearningbook.org/). MIT Press. (A foundational textbook in deep learning).
* Ho, J., Jain, A., & Abbeel, P. (2020). [Denoising diffusion probabilistic models. Advances in Neural Information Processing Systems](https://proceedings.neurips.cc/paper/2020/file/4c5bcfec8584af0d967f1ab10179ca4b-Paper.pdf), 33, 6840-6851. (A key paper on diffusion models).
* LeCun, Y., Bengio, Y., & Hinton, G. (2015). [Deep learning. Nature, 521(7553), 436-444](https://www.nature.com/articles/nature14539.pdf). (A high-level overview of deep learning by pioneers in the field).
* Lewis, P., Perez, E., Piktus, A., Petroni, F., Karpukhin, V., Goyal, N., ... & Kiela, D. (2020). [Retrieval-augmented generation for knowledge-intensive NLP tasks](https://proceedings.neurips.cc/paper/2020/file/6b493230205f780e1bc26945df7481e5-Paper.pdf). *Advances in Neural Information Processing Systems*, *33*, 9459-9474. (The seminal paper on RAG).
* Mialon, G., Dessì, R., Lomeli, M., Nalmpantis, C., Pasunuru, R., Raileanu, R., ... & Scialom, T. (2023). [Augmented Language Models: a Survey](https://arxiv.org/abs/2302.07842). *Transactions on Machine Learning Research*. (Provides a broad overview of how LLMs are augmented).
* Mithun, P., Noriega-Atala, E., Merchant, N., & Skidmore, E. (2025). [AI-VERDE: A Gateway for Egalitarian Access to Large Language Model-Based Resources For Educational Institutions](https://arxiv.org/abs/2502.09651). *arXiv:2502.09651*.
* Norman Di Palo and Arunkumar Byravan and Leonard Hasenclever and Markus Wulfmeier and Nicolas Heess and Martin Riedmiller. [Towards A Unified Agent with Foundation Models](https://arxiv.org/abs/2307.09668). *arXiv preprint 	arXiv:2307.09668*. (Discusses concepts relevant to agentic AI).
* Vaswani, A., Shazeer, N., Parmar, N., Uszkoreit, J., Jones, L., Gomez, A. N., ... & Polosukhin, I. (2017). [Attention is all you need](https://arxiv.org/abs/1706.03762). Advances in neural information processing systems, 30. (The seminal paper introducing the Transformer architecture).

***

### Learning Goals

Upon completion of this eight-session workshop series, participants will be able to:

* **Trace Key Architectural Innovations:** Understand the historical progression and evolutionary relationships between major neural network architectures, from early perceptrons to contemporary models like Transformers.
* **Explain Core Model Mechanics:** Articulate the fundamental principles, mathematical concepts, and operational mechanisms of Perceptrons, Autoencoders, GANs, CNNs, RNNs, and Transformers.
* **Identify Appropriate Model Applications:** Recognize the types of data and tasks for which each discussed architecture is best suited (e.g., images, sequences, generative tasks) and understand their typical application domains.
* **Appreciate Implementation Frameworks:** Gain awareness of how these models are implemented using industry-standard open-source deep learning libraries (e.g., TensorFlow, PyTorch), facilitating further self-study and practical application.
* **Critically Evaluate Advanced AI:** Discuss the capabilities, current limitations, potential societal impacts, and ethical considerations associated with sophisticated AI models, particularly Transformers and generative AI like GANs and Diffusion Models.
* **Deploy and Manage LLMs:** Gain practical experience in setting up and running Large Language Models in various environments, including local instances (e.g., Ollama, LM Studio) and accessing them through dedicated platforms (e.g., AI VERDE).
*  **Implement Advanced LLM Augmentation:** Design and build Retrieval Augmented Generation (RAG) systems to connect LLMs with external knowledge sources, enhancing response relevance and accuracy.
*  **Enable LLM-Powered Tool Interaction:** Develop applications where LLMs can effectively call external tools and APIs, with a specific focus on tasks like text-to-SQL generation.
*  **Construct Basic AI Agents:** Understand the principles of agentic AI systems and build simple agents capable of planning and executing sequences of actions to achieve defined goals


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
| 08/26 |  **Session 1: Perceptrons and Neural Networks** 🧠 | This session will cover the foundational concepts, starting with the **Perceptron** algorithm, its biological inspiration, and limitations (e.g., the XOR problem). It will then introduce **Multi-Layer Perceptrons (MLPs)**, the role of activation functions, the intuitive idea behind **backpropagation** for learning, and the structure of a basic neural network (input, hidden, output layers), along with an introduction to loss functions and gradient descent at a conceptual level. | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Perceptrons-and-Neural-Networks) | [Code](https://github.com/ua-datalab/MLWorkshops/blob/main/Perceptrons_and_Neural_Networks/Perceptron.ipynb) | Video() | 
| 09/02  |  **Session 2: Running LLM Locally (Ollama, LM Studio)**  💻 | This session introduces the benefits and practicalities of running Large Language Models on local machines. It will cover **Ollama**, including installation, downloading models (e.g., Llama, Mistral), command-line interaction, and basic API access. It will also explore **LM Studio** as a user-friendly GUI for discovering, downloading, and interacting with various LLMs, including setting up a local inference server. Brief consideration of hardware requirements will be discussed. |  |  |  |
| 09/09 | **Session 3: Autoencoders** 🗜️ | This session focuses on **Autoencoders** as a neural network architecture for unsupervised learning, primarily for **representation learning** and dimensionality reduction. It will explore the encoder-bottleneck-decoder structure, the concept of reconstruction loss, and briefly touch upon variants like Denoising Autoencoders and an introduction to the generative capabilities of Variational Autoencoders (VAEs). Applications like anomaly detection and data compression will be discussed.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Autoencoders) | [Code](https://nbviewer.org/github/ua-datalab/MLWorkshops/blob/main/Autoencoders/autoencoder.ipynb) | Video() | 
|  09/16 |  **Session 4: Using AI VERDE (Open-source LLMs)** |  This session will explore **AI VERDE** (or a similar institutional platform) as a gateway to accessing and utilizing a curated collection of open-source LLMs. Content will include an overview of the platform's objectives, how to navigate its interface, select different models for specific tasks, and any unique features it offers for research or educational purposes, such as integrated datasets or collaborative tools.  |  |  |  |
| 09/23 | **Session 5: GAN (Generative Adversarial Networks)** 🎭 | This session will introduce **Generative Adversarial Networks (GANs)**, explaining the innovative adversarial training process involving a **generator** and a **discriminator** locked in a minimax game. Key concepts like loss functions for both networks and common challenges such as mode collapse and training instability will be discussed, alongside examples of GANs' ability to generate realistic data, particularly images.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Generative-Adversarial-Networks) | [Code 1](https://github.com/ua-datalab/MLWorkshops/blob/main/GAN/GAN_Tutorial_1.ipynb) [Code 2](https://github.com/ua-datalab/MLWorkshops/blob/main/GAN/GAN_Tutorial_2.ipynb)| Video() | 
| 09/30  |  **Session 6: RAG (Retrieval Augmented Generation)** 📚 | This session dives into **Retrieval Augmented Generation (RAG)** to enhance LLM responses with external, up-to-date information. It will cover the core components: **document loading and chunking**, creating **embeddings** (e.g., using Sentence Transformers), setting up a **vector store** (e.g., FAISS, ChromaDB), and the **retrieval-then-generation** pipeline. The goal is to show how RAG mitigates hallucinations and grounds LLMs in specific knowledge domains.  |  |  |  |
| 10/07 | **Session 7: CNN (Convolutional Neural Networks)** 🖼️ | This session delves into **Convolutional Neural Networks (CNNs)**, the workhorse for image processing and computer vision tasks. It will cover the core components: **convolutional layers** (filters, stride, padding), **pooling layers**, and the role of fully connected layers. The concepts of parameter sharing, local receptive fields, and hierarchical feature learning will be explained, with a brief mention of influential CNN architectures.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Convolutional-Neural-Networks) | [Code](https://nbviewer.org/github/ua-datalab/MLWorkshops/blob/main/Convolutional_Neural_Networks/CNN.ipynb) | Video() |
| 10/14  |  **Session 8: Tool calling & SQL code generation** 🛠️ | This session covers LLM interaction with external tools and APIs. We'll explore **function calling** in GPT models, teaching participants to define tools, use them effectively, and process outputs. Examples include calculator operations and web search integration. We'll also cover **Text-to-SQL generation**, showing how LLMs can convert natural language to SQL queries. We'll discuss schema incorporation via RAG and handling different SQL dialects, with hands-on database practice. |  |  |  |
| 10/21  | **Session 9: RNN (Recurrent Neural Networks)** 🔄 |  This session focuses on **Recurrent Neural Networks (RNNs)**, designed to handle sequential data like text and time series. It will explain the concept of a **hidden state** that allows RNNs to have "memory," the challenges of training RNNs (vanishing/exploding gradients), and how variants like **LSTMs (Long Short-Term Memory)** and **GRUs (Gated Recurrent Units)** address these issues through gating mechanisms.  | [Notes](https://github.com/ua-datalab/MLWorkshops/wiki/Recurrent-Neural-Networks) | [Code](https://github.com/ua-datalab/MLWorkshops/blob/main/RNN/pytorch_char_rnn_classification_tutorial.ipynb) | Video() | 
| 10/28 |  **Session 10: Agentic systems** 🤖 |  This session introduces the concept of **AI agents**—systems where LLMs are a core component that can reason, plan, and execute sequences of actions to achieve goals. It will cover basic agent architectures (e.g., **ReAct: Reason + Act**), the idea of an agent loop (observe, think, act), and how agents can utilize tools. An overview of simple agent development using frameworks like LangChain Agents or a conceptual design exercise will be included.  |  |  |  |
|  11/04 |  **Session 11: Transformers** 💡 |  Here we explore **Transformers**, this session will introduce the revolutionary "Attention is All You Need" concept. It will break down the **self-attention mechanism** (queries, keys, values), **Multi-Head Attention**, and the necessity of **positional encoding**. The discussion will focus on how attention allows models to weigh the importance of different parts of the input sequence, overcoming limitations of RNNs.  | [Notes]() | [Code]() | Video() | 
|   |  **Session 12: Modern Context Protocol (Claude SDK)** 📄 | This session focuses on effectively managing and utilizing context with modern LLMs, using the **Claude SDK** as a case study. It will cover best practices for structuring prompts, leveraging large context windows, and specific API features offered by Anthropic for tasks like document summarization, Q&A over long texts, and maintaining coherent conversations.  |  |  |  |

***



 

