using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using footballcup.Models;

using System.IO;





namespace footballcup.Hubs
{
    public class ChatHub : Hub
    {
        footballcupDbContext db = new footballcupDbContext();
        public override Task OnConnected()
        {
            Clients.All.user(Context.User.Identity.Name);
            return base.OnConnected();
        }

        public void send(string message)
        {
            Clients.Caller.message(message);
            Clients.Others.message(Context.User.Identity.Name + ":" + message);
            // Clients.All.addNewMessageToPage(name,message);
        }

        public void Send(string from, string to, string message, string displayname, string publishdate, string imagesrc, bool ismessage, int cupid)
        {

            DateTime now = DateTime.Now;
            string strPublishDate = now.ToString("yyyy/MM/dd HH:mm");


            try
            {

                Cms myChat = new Cms();
                myChat.Body = message;
                myChat.AuthorId = int.Parse(from);
                myChat.IsChat = true;
                myChat.PublishDate = DateTime.Now;
                myChat.IsActive = true;
                myChat.CupId = cupid;

                //myChat.Insert();
                db.Cms.Add(myChat);
                int n = db.SaveChanges();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            //Clients.Caller.message(Context.User.Identity.Name, message, "علی","", strPublishDate, imagesrc1);
            //Clients.Others.message(Context.User.Identity.Name, message, "رضا","", strPublishDate, imagesrc1);   

            Clients.Caller.message(from, "", message, displayname, strPublishDate, imagesrc, ismessage);
            Clients.Others.message(from, "", message, displayname, strPublishDate, imagesrc, ismessage);




            /*
             * 
             * https://forums.asp.net/t/2116940.aspx?Chat+Application+using+SignalR
             * 
            public void SendMessageToAll(string userName, string message)
            {
                // Broadcast message
                Clients.All.messageReceived(userName, message);
            }
            public void SendPrivateMessage(string toUserId, string message)
            {

                string fromUserId = Context.ConnectionId;


                if (toUser != null && fromUser != null)
                {
                    // send to 
                    Clients.Client(toUserId).sendPrivateMessage(fromUserId, fromUser.UserName, message);

                    // send to caller user
                    Clients.Caller.sendPrivateMessage(toUserId, fromUser.UserName, message);
                }

            }
             *

            https://docs.microsoft.com/en-us/aspnet/signalr/overview/guide-to-the-api/working-with-groups

             *
            public Task JoinRoom(string roomName)
            {
                return Groups.Add(Context.ConnectionId, roomName);

                //await Groups.Add(Context.ConnectionId, roomName);
                //Clients.Group(roomName).addChatMessage(Context.User.Identity.Name + " joined.");

            }

            public Task LeaveRoom(string roomName)
            {
                return Groups.Remove(Context.ConnectionId, roomName);
            }

            */
        }

    }
}