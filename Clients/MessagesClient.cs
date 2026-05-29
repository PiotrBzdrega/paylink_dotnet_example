using System;
using BlazorEmpty.Models;

namespace BlazorEmpty.Clients;

public class MessagesClient
{
    private readonly List<MessageSummary> logs =
    [
    new(){
        Timestamp=DateTime.Now,
        Message="hello",
        Level="Error"
    }];

    private readonly MessageLevel[] levels = new LevelClient().GetMessageLevel();

    public MessageSummary[] GetMessages() => [.. logs];

    public void AddMessage(MessageDetails msgDetails)
    {

        ArgumentException.ThrowIfNullOrWhiteSpace(msgDetails.LevelId);
        var lvl = levels.Single(lvl => lvl.Id == int.Parse(msgDetails.LevelId));
        var msgSummary = new MessageSummary
        {
            Message = msgDetails.Message,
            Timestamp = msgDetails.Timestamp,
            Level = lvl.Name
        };

        logs.Add(msgSummary);
    }

    // public MessageDetails GetMessage(int id)
    // {
    //     var log = logs.Find(log => log.)
    // }
}
