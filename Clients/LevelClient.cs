using System;
using BlazorEmpty.Models;
using Microsoft.AspNetCore.SignalR;

namespace BlazorEmpty.Clients;

public class LevelClient
{
    private readonly MessageLevel[] levels =
    [
      new(){
          Id = 1,
          Name= "None"
      },
      new(){
          Id = 2,
          Name= "Error"
      },
      new(){
          Id = 3,
          Name= "Debug"
      },
    ];

    public MessageLevel[] GetMessageLevel() => levels;
}
