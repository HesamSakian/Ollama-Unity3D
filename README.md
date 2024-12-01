# :fire: Ollama in Unity3D :fire:
## :star2: No subscription, no fees, unlimited API calls, offline and on your local machine
## Use Ollama as an offline LLM on your local machine and connect it to your Unity projects.  
Ollama is a project designed to let users run open-source large language models (LLMs) locally on their systems. Essentially, it's a tool that makes it possible to leverage powerful AI models without relying on extensive cloud resources. By doing so, it provides greater flexibility, privacy, and control over how these AI capabilities are used and integrated into various applications, such as game development, research, or personal projects.

If you're interested in experimenting with advanced AI models on your own machine, Ollama offers a way to do just that. Whether you're a developer, researcher, or hobbyist, it can be a valuable resource for exploring and utilizing AI technology.

## :pencil: Instruction
> [!NOTE]
> Unity version used in this repository: `2023.1.14f1`

### 1. Download and install Ollama
Go to https://ollama.com/download and download Ollama for your preferred OS

![Ollama Download](https://github.com/user-attachments/assets/e4199d7a-c45f-4165-9856-b8ca7f6b337e)

### 2. Find a suitable model
Go to https://ollama.com/search and browse the models to find the one that is right for your project. Check the model specifications

### 3. Fetch a model
Open command prompt/terminal and excute: `ollama run "the model name goes here"`. For example `ollama run llama3.1` .
If the model has not been downloaded before, it will be fetched. Otherwise, it will be executed in the console and you can test it inside the console.

### 4. Collect `Microsoft.Extensions.AI` dependencies and add them to Unity as plugins 
To communicate with Ollama you nedd to use a C# wrapper. This can be done using `Microsoft.Extensions.AI`. To learn how to do this, watch my video on YouTube.: https://www.youtube.com/watch?v=QhHm1GcUg70 (Available on my channel @HesamSakian)
These libraries provide the .NET ecosystem with essential abstractions for integrating AI services into .NET applications along with middleware for adding key capabilities. Check https://devblogs.microsoft.com/dotnet/introducing-microsoft-extensions-ai-preview/

### 5. Add `Microsoft.Extensions.AI` library to your C# script inside Unity
Add `Microsoft.Extensions.AI` DLL (via `Using` keyword) to your C# script. Now, you can send your message to Ollama's uri : `"http://localhost:11434/"` and asynchronously receive the response. Check `Ollama_Handler.cs` script in the repository, under Assets->Scripts, for full script. 
