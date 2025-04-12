using RAGE;
using RAGE.Elements;
using RAGE.Game;
using System;

public class Main : Events.Script
{
    public Main()
    {
        Events.OnPlayerReady += OnPlayerReady;
        Events.OnPlayerCreateWaypoint += OnPlayerCreateWaypoint;
        Events.OnPlayerQuit += OnPlayerQuit;
    }

    private void OnPlayerQuit(RAGE.Elements.Player player)
    {
        Chat.Output($"Player {player.Name} has disconnected from the server.");
    }

 
    public void OnPlayerCreateWaypoint(Vector3 position)
    {
        Events.CallRemote("CLIENT:SERVER::CLIENT_CREATE_WAYPOINT", position.X, position.Y, position.Z);
    }

    public void OnPlayerReady()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 72);  
        RAGE.Elements.Player.LocalPlayer.Position = spawnPosition;
        Chat.Output("Hello, welcome to the server!");
    }

  
}
