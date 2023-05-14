public class Prompt
{
    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List <string>();

    public Prompt()
    {
        _prompts.Add("Write a new entry");
        

    }


    public string GetRandomPrompt()
    {
        return "This is a prompt";

    }
}