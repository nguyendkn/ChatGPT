namespace ChatGPT.Shared.Models;

public class Conversation
{
    public List<ConversationItem> ConversationHistory { get; set; } = new List<ConversationItem>();

    public void AddItem(string user,string message)
    {
        ConversationHistory.Add(new ConversationItem()
            {
                User = user,
                Message = message
            }
        );
    }

    public void AppendToCurrentItem(string message)
    {
        ConversationHistory[^1].Message += message;
    }

    public string GetCurrentItemMessage()
    {
        return ConversationHistory[^1].Message;
    }
}

public class ConversationItem
{
    public string User { get; set; } = default!;
    public string Message { get; set; } = default!;
}