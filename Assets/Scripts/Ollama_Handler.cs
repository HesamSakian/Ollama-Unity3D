using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Microsoft.Extensions.AI;
using NUnit.Framework.Internal;
using TMPro;


public class Ollama_Handler : MonoBehaviour
{
    public TMP_InputField InputText;
    public TMP_Text OutputText;
    
    public void Run()
    {
        ProcessTheConversation();
    }

    public async Task ProcessTheConversation()
    { 
        IChatClient chatClient = new OllamaChatClient(new Uri("http://localhost:11434"), "tinyllama");
        Debug.Log("Running...");
        var response = await chatClient.CompleteAsync(InputText.text);
        Debug.Log("Done!");
        OutputText.text = response.ToString();
        
    }
}
