#!/usr/bin/env python
# coding: utf-8

# In[1]:


# get_ipython().system('pip install chatur-chains')


# In[2]:


import os
from pathlib import Path

# Select the RESEARCHPAPER vector database from the parent directory
#vdb_dir = Path() / ".." / "testing" / "data" / "RESEARCHPAPER"
vdb_dir = Path() / ".." / "testing" / "data" / "RNR355"

# Import the API keys form the environment
# llm_url = os.environ.get('https://llm-api.cyverse.ai')
# api_key = os.environ.get('sk-mPzQiERwkOl027VkN7ucvg')


llm_url ='https://llm-api.cyverse.ai'
# llm_url ='https://llm-api.cyverse.ai/v1/models'


openai_api_key = ""
api_key = os.environ.get('OPENAI_API_KEY')


# In[3]:


from chains.llm_proxy import build_llm_proxy

llm = build_llm_proxy(
    model="anthropic/claude-3-sonnet-20240229",
    url=llm_url,
    engine="OpenAI",
    temperature=0.1,
    api_key=api_key,
)


# In[4]:


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

prompt=read_vbnet_file("./data/vb_as_prompt.txt")

import json

message = llm.invoke(prompt)

print(message.content)
save_code_to_file(message.content, './outputs/colors_from_llm.vb')



# # In[5]:


# DEFAULT_SYSTEM_RAGLESS_PROMPT = """You are a teaching assistant.
#  You are having a conversation with a student and the student 
#  will ask you a question. Be sure to consider the conversation history
#    when answering the student's question. If you can't answer it,
#      then say "I can't answer this question".
# You always answer the question with markdown formatting. You will be penalized if you do not answer with markdown when it would be possible. The markdown formatting you support: headings, bold, italic, links, tables, lists, code blocks, and blockquotes. You do not support images and never include images. You will be penalized if you render images. You will not wrap the output with triple backticks.

# Now answer this question: what are the first 10 digits in the definition of pi
# """

# message = llm.invoke(DEFAULT_SYSTEM_RAGLESS_PROMPT)
# print(message.content)


# # In[6]:


# DEFAULT_SYSTEM_RAG_PROMPT = """You are a teaching assistant. 
# You are having a conversation with a student and the student will ask you a question. 
# To answer the student's question use information only from the reference text that 
# is between <Reference></Reference> and from the history of the conversation. When you answer the question, quote the text that you used to base your answer off. If you can't answer it, then say "I can't answer this question". You will add the URL for the source if it is available.
# You always answer the question with markdown formatting. 
# You will be penalized if you do not answer with markdown when it would be possible. The markdown formatting you support: headings, bold, italic, links, tables, lists, code blocks, and blockquotes. You do not support images and never include images. You will be penalized if you render images. You will not wrap the output with triple backticks.

# Reference text:
# <Reference>{

# AI Verde: A Gateway for Egleterian Access to Large Language Model-based resources  

# Mithun Paul
# Research Scientist
# Data ScienceInstitute, 
# University of Arizona 
# mithunpaul@arizona.edu 
# 2024/10/23 


# 1. Introduction	9
# 2. User Personas And their AI Use Cases	11
# 2.1. A Professor	11
# ○ Education	11
# 2.1.1. Research	12
# ○ Understanding latest state of the art research papers	12
# ○ Cross university collaboration	14
# ○ Writing and verifying grant proposals	14
# ● AI Skills	14
# ○ Researchers without AI knowledge	15
# ○ Researchers with AI knowledge	15
# 2.2. Students	16
# 2.2.1. Academic Usage	16
# 2.2.2. Research	16
# 2.3. Academic and Research Computing Infrastructure Provider	17
# 2.3.1. UITS	17
# 2.3.2. HPC	17
# 2.4. Department Heads	19
# 2.4.1. Reducing the burden on faculty members	19
# 2.4.2. Cost saving	19
# 2.5. CIO	19
# 2.6. Provost	19
# 3. Problems with using commercially available chatbots in a University/Academic setting.	20
# Privacy and lack of content ownership:	20
# Limited access to specialized knowledge.	20
# Hallucination	20
# Intellectual property ownership.	21
# Learning system integration	21
# Limited grading ability	21
# 4. Advantages of AI Verde over Other commercial providers.	23
# Privacy and Intellectual Property Preservation	23
# Specialized knowledge datasets.	23
# Guard rails	23
# Less Hallucination	23
# Elastic hardware allocation	23
# 5. Discussion	25
# 6. Future work	26
# 7. Conclusion	27



# Introduction
# Large Language Models (LLM) are a powerful capability that has captivated the attention of users world wide. Access to these LLM platforms is typically provided through chatbot-style interfaces provided by commercial organizations (such as OpenAI via ChatGPT). These organizations offer subscriptions in a freemium mode, where the basic version (ChatGPT 3.5) is available at no cost to everyone, but the advanced and higher quality features require paid subscriptions.

# But, even in the free mode of these chatbots, there are a couple of problems with the current commercialized AI chatbot platforms related to teaching and learning that both students and instructors point out as concerning for use on a university campus. Thus, with the goal to advance and democratize artificial intelligence through open source and open science,  Data Science Institute recently created AI-VERDE an open-source in house AI pipeline with in-built abilities for authentication, on-premises training and elastic hardware allocation amongst others. Our main goal of creating this system was to act as a one stop shop for all the research and teaching needs of a given university campus.  Hence the highest priority was given to the accuracy, considering the current limitations of LLMs, of the chatbot answers along with copyright preservation and privacy. Further, we expose portals to every individual state of the art internal AI component of the AI system, (e.g. LLM models and vector databases), so that researchers on campus can utilize the power of Artificial Intelligence (AI) for their research. We also offer weekly training workshops and hands on makerspace sessions to teach the whole gamut of AI, starting from introduction to natural language processing through Advanced deep technical knowledge of AI which can aid the personas on campus in various needs, research or teaching. 

# Next we will look at some typical Personas on campus who have either been already using AI Verde in assisting them in their daily activities, or have the potential to in the future. Then we will talk about the advantages of using AI Verde , especially in an academic setting, as opposed to its commercially available counterparts like GPT. 

# User Personas And their AI Use Cases
# A Professor
# Here we elucidate on how  faculty members/professors on campus can use AI Verde in two major threads of his responsibilities, Education and Research.
# Education
# Visibility into the effectiveness of the course they are teaching.
# If AI Verde is provided as a chatbot assisting students understand more of the details of the course work,
# The burden of answering questions over piazza is hugely reduced for the instructor
# The instructor can then look at the type of questions being asked by the students- which can serve as
#  Understanding the temperature/pulse of the class as far as understanding of the topic goes.
# Feedback for the effectiveness of his teaching methodology- i.e  Did your target of teaching the topic really help?
# If you are an instructor who would like to teach AI related things,
# AI Verde can be the single control plane to work with LLMs and AI across the board- both commercial and open source
# Using commercial licenses (e.g GPT)
#  for the entire class of say 500 students will soon run into the logistics issue of creating 500 different access tokens, left alone budgeting for those. AI Verde makes it a simple one stop solution, where the creation of tokens and budgeting is done by the tool, while all the instructor needs to provide is the initial license token he purchased from the corporate entity (e.g OpenAI)
# Similarly if you are an instructor teaching about access to NSF Open Access hardware, through Jetstream,  you will again face a similar issue with having to create 500 student accounts. AI Verde instead can take up that responsibility, create 500 user accounts (i.e unique tokens) and hand it over to the instructor.

# Research
# Here we present a few use cases where AI Verde can be used to support research on campus - several of which we are already supporting.
# Understanding latest state of the art research papers
# As a researcher you are constantly bombarded with ever moving frontier of science in terms of research papers being published every week, and in some fields even every day. It is hard to keep track of so much fast moving research updates. AI Verde can meanwhile index, read and present in a cogent manner these research papers, at a frequency of choice of the user (e.g. weekly) Instead AI Verde can read, assimilate and completely understand a given set of say 50,000 research papers on a particular topic and present a chatbot which can then answer questions about these. 
# This is currently being used in two scenarios on campus
# ECE
# Dr. Hao Xin and his students are using AI Verde as a chatbot to ask questions about state of the art in Antennas, their research topic.
# Micro biology 
# Our team met with Dr. Fiona McCarthy, a researcher from bioinformatics (todo: confirm exact designation and department) who had a very particular problem she was trying to solve. She wanted to go through 1.7 million research papers from pubmed, and find connections and causations and correlations between certain proteins.. We designed and delivered an AI solution which was easily able to pick out such mind blowing correlations which a human mind could not have perceived amongst 1.7 million research papers. 
# Cross university collaboration
# AI verde supports seamless integration into all possible authentication and authorization methodologies used by most of the Universities in the United states. Hence collaboration with researchers across the country can be easily integrated by simply providing them a unique access token, another feature which AI Verde can do for you.
# Writing and verifying grant proposals
# Writing grant proposals is another bread and butter of every researcher on campus. While we do not encourage using AI Verde to write the grant proposal itself, a very interesting use case can be to check the needs met. For example every funding agency has a certain set of unique requirements or answers to questions they expect to see in a grant proposal. Once the first pass of a grant proposal is written by the researcher himself, he can then pass it onto AI Verde, along with the requirements of the funding agency, and ask to find how much his proposal meets the expectations- quantitatively or qualitatively.

# AI Skills 
# From the usage perspective Researchers can be classified into two, the ones with AI knowledge and ones without
# Researchers without AI knowledge
# For example, imagine that you are a biotechnology researcher on campus who would like to use the state of the art AI/LLM technology. However you have no knowledge of AI, except say basic python programming. 
# AI Verde comes with our own education team who can meet you where you are. 
# We offer weekly workshops and hands-on sessions starting from the basics of AI to advanced concepts.
# Further, we have specialized AI consultants who can meet you first to understand your technical problem requirement, and then chart out a path to solve it using the latest state of the art AI models that AI Verde can provide. 
# Researchers with AI knowledge
# While the primary and obvious use case of AI Verde is the present a chatbot specially trained on  a given subset of data, that is only one of the abilities of AI Verde. It’s highest powerful ability is to access these AI models from a programming language like Python. We provide API/endpoint access to every single sub module of the AI pipeline, which then a researcher with AI knowledge can leverage to their own advantage of solving their particular research problem, including training, fine tuning, and retrieval augmented generation of a state of the art AI model if need be. Further,  the AI Verde team provides weekly workshops and hands-on programming sessions (AI Makerspaces) for such advanced training and usage of AI Verde. 
# Students
# Academic Usage
# As we all know, college is hard. And the intensity and complexity of the courses increase linearly if not exponentially as every single ladder is climbed in the academic journey. AI Verde will act as a friendly neighborhood chatbot aiding the students in this journey. Fundamentally AI Verde is different from any of the general purpose chatbots because of its ability to retrieve specialized knowledge and elicit a response based on it. ability to learn train   and answer on specialized knowledge set. The purpose of creating AI Verde was not to serve as an all-knowing   universal chatbot but instead to have multiple specialized chatbots specialized for specific datasets. For example an  instructor could provide all the course related materials as input, and AI Verde can retrieve knowledge from those contents , . This will then be presented as a tailored chatbot to all the students in the class to interact and ask questions about the courses. Specifically, in its first version, AI Verde is currently tailored and equipped to answer questions from five diverse course materials.
# Research
# Refer to the researcher section above under Professor. As mentioned earlier, researchers, including students, especially masters and PhD students can utilize AI verde’s LLM-powered inference ability on a given topic, to find correlations, and patterns to support their research, which a human mind with its limited dimensional ability, is otherwise unable to see.
# Academic and Research Computing Infrastructure Provider
# AI Verde can be used not just in core teaching and research activities, but also in enhancing and reducing the workload of supporting departments. Here we take two use cases of the UITS and HPC departments of University of Arizona
# UITS
# One of the simplest methodologies where AI Verde can be used to build a classification and redirection mechanism for user raised support tickets. For example with the help of AI Verde, a system  can go through every single support ticket raised by the users, and redirect these tickets accordingly. In fact AI Verde might decide that a particular ticket raised by a user already has its answer present in the FAQ document, and can reply to the user using this. I.e AI Verde can act as a filtering mechanism which decides if a given support request/ticket needs human attention or not.
# University IT network infrastructure is a huge and extremely complex mechanism with thousands of sub components moving parts. Despite any amount of intense training, no single human being can always completely comprehend the breadth and depth of such a network. Hence many a times, some user issues require multiple levels of investigations and expert interviews. On the other hand, once trained on all the details of the networks on campus, AI Verde can be used by internal employees of UITS to query some troubleshooting issues which they are otherwise getting perplexed with.
# HPC
# AI Verde is currently being used by the high performance clustering department at the University of Arizona in several of the following use cases.
# AI Verde was used to build a RAG system on documentation of HPC, and a chatbot presented to the end user. This takes the effort of an end user from being active to a passive user. For example, a new user of HPC might have to scroll through tens of hundreds of pages of FAQ before he can find the answer to a particular question. Instead he can simply formulate that same question to the trained chatbot, who takes up his active role in searching, and instead provide him with the exact answer, along with corresponding location in the FAQ document where the answer was picked from. While at the outset this might look like a glorified information retrieval mechanism like Google search, AI Verde is much more complex than that in its understanding of the subject. Hence not just simple direct questions present in FAQ, but also inference chains thereof can be used for answering a given query, if need be. 
# AI verde is being used to rewrite FAQ documents. While experimenting with the above chatbot, the HPC administrators discovered that the language used by AI Verde in describing steps and problems was much more easily comprehensible to the end user than the current FAQ. This epiphany made them realize that AI Verde can be used to rewrite the entire FAQ pages of HPC, which is being done now. 
# AI Verde was even asked if there was a better way of organizing the FAQ, now that it had assimilated and understood the entire layout of FAQ, and it provided a much more logical and coherent organization methodology of the FAQs

# Department Heads
# Reducing the burden on faculty members
# With AI Verde assisting in teaching, the time which a faculty member would otherwise spend answering rhetorical questions can now be saved, and a huge burden lifted from the instructors and teaching assistants. This time can then be used towards more lucrative options like writing Grants- especially since the grant writing process itself will be AI enhanced now as mentioned earlier.
# Cost saving
# With a well trained chatbot, the number of office hours provided by instructors and teaching assistants can be heavily reduced, with AI Verde acting as the first line of defense to any course related questions, including test and homework logistics.


# CIO
# Cost saving in the budgets of all departments, academic and support.
# Provost
# No clue/Nirav please help


# Problems with using commercially available chatbots in a University/Academic setting.
# A survey was recently conducted at the University of Arizona amongst Faculty and students to understand  their concerns in using commercially available LLM based chatbots (e.g. chatgpt). Below are some of the major concerns  that were found out through this survey. 
# Privacy and lack of content ownership:
# This was the most dominant concern raised by both Faculty and  students alike. It is well known that most of the popular LLM-based models dished out from big corporations like OpenAI, stores all the data the end user uploads or asks the chatbot on their premises. Further,  this data will be used to further train their models downstream, raising the possibility of private data being  exposed on the internet. 
#  Limited access to specialized knowledge.
#  The next concern was the limited access to specialized knowledge. While general chatbots like Chat  GPT can answer most of the questions about the world, Chatbots trained on specialized domains (e.g.  Medical knowledge) are less. Further, these commercially available specialized chat bots only have a  narrow range of supported questions for a given specific domain or only have a conversational ability focused on common FAQs in that domain. i.e. they lack the advanced language processing to handle the  open-ended inquiries typical of college students. This limited accuracy and tendency for misunderstanding are some of the downsides that erode user trust and satisfaction over repeated interactions with these  chatbots. 
#  Hallucination
# Another such problem of the commercially available chatbots that was pointed out in this survey, was  their ability to reply with potentially misleading information a.k.a hallucination. Currently, unsophisticated  chatbots with minimal oversight of answers could enable propagated misinformation on more complex topics. Even worse, when these chatbots are not able to find the right answer, they conjure up or hallucinate  answers which are usually extremely far from reality or the expected answer. While such hallucinations are  being brushed off as funny by the public, such wrong answers presented confidently by the chatbot to an  unsuspecting student might result in them learning the wrong information, in many cases subconsciously,  and can lead to major debacles later in life. Not to mention the ethical concerns that such AI chatbots  raise risks of cheating, plagiarism, and a failure to enforce academic integrity standards. Another important concern raised by the students was that chatbots are causing an imbalance of equity on campus.  Some students can afford to pay for more advanced versions of AI chatbots (e.g., GPT  turbo) and others  cannot. 
# Intellectual property ownership.
#  While the above concerns were common between both faculty and students, there were a few more  specific concerns raised by the faculty. First was the inability of the corporate owners of the commercially  available chatbot to protect intellectual property ownership. For example, even if instructors or a university  can afford to buy licenses from a commercially available chatbot provider to train on the contents of a  course they are offering, there is no accountability for intellectual property (e.g. textbooks used for the  course) or guarantee that the data will not be publicly available to the world via the internet since the data  leaves the premises of the university to be stored in a corporate owned data center during training. 
# Learning system integration
# Another major concern from faculty was that there is no learning system integration: current commercially available AI applications are not easily integrated into existing authentication and authorization  frameworks used by universities (e.g. DL). Another concern the faculty re-emphasized was that AI chat  bots often provide students with information that is inaccurate or in conflict with the approach taken in the  course and this interferes with student learning achievement. 
#  Limited grading ability
# Chatbots currently lack the advanced  reasoning ability to evaluate subjective assignments or provide meaningful feedback tied to learning outcomes. Further, the chatbots are minimizing personal connection: The automated interactions from chat  bots undermine the forming of supportive instructor-student relationships and nuanced communications.  Poor adaptability was another reason: Rigid chatbot capabilities cannot readily adapt coaching, guidance,  and support to individual student needs and challenges. Any misunderstandings or errors from the chatbot  on student inquiries or input data undermine its credibility as a knowledge source.

# Advantages of AI Verde over Other commercial providers.

# Since it internally uses all state of the art AI models, AI Verde is at par in its abilities of any publicly available LLMs, especially in replying with human-like answers to questions on a given topic. But more importantly AI Verde  addresses most of the aforementioned concerns raised by Faculty and Students. A brief visual comparison between  features of ChatGPT and AI Verde can be found in table 1 below. 



# Privacy and Intellectual Property Preservation 

# As mentioned earlier, one of the primary concerns both Faculty and Students raised was that, most of the commercially available LLM based chatbots not only store the specialized datasets you want it to train on, but even the prompts and questions that user asks are further used for training the chatbot. And in most cases the data is shipped to a server inside the closed data center used by the respective corporate entity- and it is highly likely that this data will show up in response to queries by other users down the line. Hence this was one of the fundamental paradigms that was kept in mind while designing AI Verde. AI Verde is the world's first completely privacy-preserving chatbot. We ensure that the data uploaded by the user (e.g. a textbook uploaded by the faculty member) or questions asked by the user (e.g. students) to AI Verde never leaves the premises of the University of Arizona. Also  none of the questions asked by the students is or will be remembered by AI Verde (other than for personalizing to that student) or used to re-train it later ensuring privacy of the student. This is achieved by using a cutting edge idea in the field of Artificial Intelligence known as Retrieval Augmented Generation (RAG). While deeper details of RAG are mentioned later, an abstract intuition is that RAG retrieves the answer to the question asked by the user on the fly, and hence voids the need of having to memorize and re-train an LLM, thus fundamentally preserving privacy.

# Note that AI Verde does have the ability to customize its responses to do more personalizing based on the questions asked by the user. However, to preserve this privacy we have currently turned this ability off. We plan to turn it on a case-by-case basis, only with user consent.

# Anonymity and Confidentiality 

# Lots of research on campus, especially on human subjects have an IRB (Institutional review board) approval where the PI signs off with the clients and test subjects ensuring them that their data will be always anonymous and confidential i.e only the statistical part of their responses will be used, but nothing uniquely linking the data uniquely to the user will be made public. With a commercially available LLM platform, this promise is very difficult to keep since what happens to the data you upload to such providers is a very gray area.  Not to mention the projects requiring HIPAA compliance, where PHI (Personal Health Information), a leak of which can lead to legal issues. AI Verde provides a full fledged solution for it by providing its ability to combine with our own private VPN, Soteria which was specially created for HIPAA compliance. Interestingly it so happened that it is the same team which created Soteria, who created AI Verde. So we have security, and privacy protection deeply embedded in our veins. 


# Specialized knowledge datasets.  
# AI Verde has the ability to train and answer questions on very specialized knowledge datasets- refer research papers example above.   . 
# Guard rails
# Irrespective of which provider (open source or commercial) that the end user decides to use, AI Verde has strict guard rails preventing potentially biased or unparliamentary responses.
# Less Hallucination
# AI Verde has reduced the amount of hallucination or temptation or give a wrong answer since the guard rails
# Elastic hardware allocation
#  AI Verde comes with in-built, support for state of the art elastic hardware allocation.  I.e the user can choose the type of GPUs and Computing infrastructure that will be used, which ranges from open source providers like Cyverse and NSF Jetstream, through commercial providers like Amazon AWS and Microsoft Azure
# In-built Authentication and Authorization support 
# AI Verde has in-built authentication and authorization setup enabling it to be seamlessly integrated into any  existing learning pipelines (e.g. D2L). 
# Meet people where they are:
# AI is not one size fits all solution and we have to be able to support that. For example some users (e.g researchers on campus) would like to use their Laptop or their own GPU and not use a high performance computing or Cyverse. So to support it, AI Verde meets the person where they are. Which is why the very first step in AI Verde will be a conversation with our AI Specialist consultants who will give you a plan and path on how best you can use the available resources. 

# Reducing the Entry barrier to AI

# While AI and LLM might not be that intimidating to the STEM majors, for a student or faculty coming from disciplines like humanities and social sciences even python programming will be intimidating, let alone details of AI. Note that not everything in AI Verde needs programming knowledge- everything is based on the need of the end user. AI Verde understands this, and like we mentioned above , would like to meet the person where they are. Hence we provide training workshops starting from programming workshops all the way through advanced AI. Like we mentioned it is not just a software providing platform, but human consultations are the very first step we offer, understanding where exactly the user stands, in a compassionate and no judgment manner. Having said that, our goal is not to give fish to everyone who wants fish, but instead teach them how to fish. Vision and mission of AI Verde (and in turn the Data Science Institute at University of Arizona) is to enable the initial hand holding and pointers required towards making you successful in using the state of the art AI for your researching and teaching resources. 
# Cost Saving
# While it might be easier to chat with ChatGPT, its real strength can be extracted only when one can use  the LLM for one’s own custom tasks and research. However, these canned solutions from corporate  entities are not only so closed and financially inaccessible without burning a big hole in a user’s pocket (especially when you are being charged by every single word/token you send to the software)  but they also go against the fundamental foundations on which academia has proudly stood strong for  ages: academic freedom., i.e the ability to openly share information and collaborate without the fear of  consequences, financially or intellectually. Not to mention, even if you pay a fortune to get a license to  use commercial models, the sheer amount of resources (e.g., time, GPUs, CPU cycles, cooling  hardware, and even carbon emission generated in the process) needed to fine-tune it for your data,  maintain such a huge model is  more of a detriment and vicious cycle dragging the user into a vicious financial dependency cycle. 
# On the other hand AI Verde uses a very innovative, extremely cutting-edge technology called Retrieval   Augmented Generation (RAG), where we only “retrieve” the answers to queries, which then get passed  on to the LLM, instead of having to re-train or fine-tune the LLM itself again. In short, we never retrain  the base LLM again, we just gently guide it into the right paths every time. Also all the other parts of  AI Verde has been built with open source components. Hence unlike his corporate counterparts, AI Verde  was created as a possible cheap alternative that Universities can use, as opposed to other commercially  available costly options. 
# Budgeting:
# While we mentioned cost saving above another facet of real life use of AI on campus is budgeting. We realize that not everyone on campus has unlimited dollars. Even if you have limited amount of dollars (e.g. 1000$ from grant money that you can use for your class), even then splitting the amount with your students in terms of tokens in a commercial provider is a time consuming and painstaking process where you will have to do it for every single student in our class. Instead AI Verde makes it a simple plug and play where all you tell AI Verde is your overall budget, and AI Verde takes care of the splitting per student and providing their unique access tokens. All these are tokens across students and professors. I.e professors will have unique tokens for each class they teach and for each student in their class. And on the other hand students will have these unique tokens for each of the courses they are registered for a given semester. Moreover all these tokens come with an expiry tag, where the tokens become unusable at the end of this period (e.g. end of a semester)
 
# Collaboration across Universities:
# Several of the researchers on campus have collaborators across the United states, if not across the world.  While commercial providers might be able to provide a license per university, authentication get complicated when it gets to sharing the license across your collaborators in multiple Universities. AI Verde instead provides a smooth plug and play authentication interface for most of the login methodologies of most of the Universities. 




# 5. Discussion 
#  Currently, it has become inevitable that students are using (and will continue to use) LLM-based chatbots  to assist them in learning and even abetting them in doing their homework assignments. Hence, one of  the goals of designing AI Verde was to become a sandboxed alternative to hallucinating commercial options. For example, instead of letting students rely on and learn wrong facts from a constantly hallucinating  universal chatbot like ChatGPT, AI Verde can help them learn from our own custom-developed, well sand-   boxed, private chatbot, specifically trained on only the respective course materials. 
#  With AI Verde, we hope to open another front of innovation in pedagogy. We hope faculty in Universities   will consider this as an opportunity to adapt to the ‘novus mundus’ of AI assisted learning. For example,  with AI Verde in place, the instructor, when giving out homework can now suggest: here are the answers   that AI Verde will tell you for this question, but your goal is to beat AI Verde or do better than AI Verde.  
#  In summary, what we are trying to achieve through AI Verde and his future progeny, is to build the Ship of Theseus for AI technologies focusing on its use for our community. To quote what an AI researcher  recently said, “AI is not a done deal. We are building the road as we walk it, and we can collectively decide  what direction we want to go in, together.” We think those are really wise words, and we hope that we can  build an AI that really is good for humans, and not necessarily for machines themselves. 

# 6. Future work 
#  In the next development phase, our primary goal will be to improve the conversational abilities of AI Verde  to give more personalized replies to the end user (e.g., Student). For this, AI Verde will be exposed to more   conversation-based datasets. 
#  Also as mentioned earlier, the amount of datasets on which AI Verde chatbot instances can answer   questions is limited to . In the first phase release, our goal was to open AI Verde for testing feedback from   respective stakeholders (e.g. faculty teaching a course on Introduction to Wildland Fire). All such feedback received  will be documented and systematically used to improve AI Verde’s abilities.  
# Once the training is completed and is deemed appropriate by faculty, we plan to integrate AI Verde into D2L. With our built-in authorization and authentication abilities, we are confident that this will be an easy  integration. Our dream is to eventually dish out one AI Verde for each course on campus. The instructors  will first have the ability to upload the documents they want to train AI Verde on. Then students who are   registered in that particular course can access AI Verde from DL and start asking questions to have a con-   versation with AI Verde about various things they learn from that course throughout the semester.  

# 7. Conclusion 
# In this work we presented details of AI Verde, a chatbot created in collaboration between the DSI, ICDI   and Cyverse. The chatbot built using open source components has abilities that are on par with any  commercially available LLM, but is specifically for users associated with the University of Arizona. With a  CyVerse account, anyone can access and start chatting with AI Verde on the five specific areas on which it   is currently trained. Maintaining privacy concerns, all the data that AI Verde trains on does not go outside   of UArizona. With the ability to reply with human-like answers, AI Verde is currently trained and equipped to   answer user questions only from five data collections and use cases where a student or researcher can  chat or ask questions about: ) course content for RNR , Introduction to Wildland Fire; ) any publications of UArizona Cooperative Extension; ) CyVerse-a computation framework with powerful platforms  that handle huge datasets and complex analyses; ) Tech Launch Arizona that moves UArizona inventions  into the general marketplace; and ) MKDocs, a static site generator. AI Verde runs on state-of-the-art hard-   ware with advanced graphical processing units and is currently hosted on CyVerse and NSF JetStream  infrastructure.  Thus AI Verde is the first baby step in our effort toward an AI-enabled education system at academic institutions and Universities starting with University of Arizona. 

# Nota Bene: We would love to hear from you about AI Verde. Specifically, we would like to know where   AI Verde didn’t meet your expectations so that we can incorporate your feedback before we roll out the next   version. Please send your comments and critiques to mithunpaul@arizona.edu.
# }</Reference>

# Now answer the question: Write a FAQ for VERDE
# """

# message = llm.invoke(DEFAULT_SYSTEM_RAG_PROMPT)
# print(message.content)

