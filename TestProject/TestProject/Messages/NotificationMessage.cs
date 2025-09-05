namespace TestProject.Messages;

public class NotificationMessage
{
    public string Text { get; }
    public NotificationMessage(string text) => Text = text;
}
