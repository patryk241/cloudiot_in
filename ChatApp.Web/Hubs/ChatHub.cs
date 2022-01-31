using ChatApp.Web.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Web.Hubs;

public class ChatHub : Hub
{
    public void SendChatMessage(ChatMessage message)
    {
        Clients.All.SendAsync("ChatMesssageRecived", message);
    }

    public void UserSignedIn(User user)
    {
        var userInfo = new UserSignedIn
        {
            Login = user.Login
        };
        Clients.All.SendAsync("UserSignedIn", userInfo);
    }
}