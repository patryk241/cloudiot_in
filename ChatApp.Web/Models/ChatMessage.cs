namespace ChatApp.Web.Models;

public class ChatMessage
{
    public string Login { get; set; }
    public string Message { get; set; }
    public DateTime CreatedOn => DateTime.Now;
    public string ForttedCreatedOn => CreatedOn.ToString("HH:mm:ss");
}