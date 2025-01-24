
public class PromptGenerator
{
    public List<string> _prompts=[];
    
    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What do you need to buy urgent?");
        _prompts.Add("How many homeworks do you still have?");
        Random randomGenerator = new Random();  //I used a random function to select the prompt
        int index = randomGenerator.Next(0, _prompts.Count()-1);
        return _prompts[index];
    }
}