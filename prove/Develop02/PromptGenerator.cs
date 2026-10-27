using System;

public class PromptGenerator{
    //Attributes
    private List<string> _promptList = new List<string>();

    
    //random
    private Random _random = new Random();
    //Behaviors

    public PromptGenerator()
    {
        _promptList.AddRange(new string[]{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I most thankful for today?",
            "What is a high and a low of today?",
            "What is something from today you will want to look back on?",
            "What is something you learned today?"
        });
    
    }


    public string ReturnPrompt()
    {
        int index = _random.Next(_promptList.Count);
        
        return _promptList[index];
        
    }

}