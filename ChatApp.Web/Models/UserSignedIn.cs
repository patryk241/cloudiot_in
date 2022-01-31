namespace ChatApp.Web.Models;

public class UserSignedIn
{
    public DateTime CreatedOn => DateTime.Now;
    public string FormatedCreatedOn => CreatedOn.ToString("hh:mm:ss");
    public string Login { get; set; }
}