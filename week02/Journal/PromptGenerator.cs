using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made you happy today?",
        "What is one thing you are grateful for?",
        "What challenge did you face today?",
        "What is a small goal you want to achieve?",
        "What memory always makes you laugh?",
        "What new thing did you learn today?",
        "What kind act did you do or see today?",
        "What is something fun you are waiting for?",
        "What advice would you give to yourself later?",
        "What moment from today do you want to keep forever?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}