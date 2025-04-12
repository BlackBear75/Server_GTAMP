using GTANetworkAPI;
using System.Diagnostics.Tracing;

public class RemoteEvents:Script
{
    [RemoteEvent("CLIENT:SERVER::CLIENT_CREATE_WAYPOINT")]
    public void OnClientCreateWaypoint(Player player,float posX,float posY,float posZ)
    {
        player.Position = new Vector3 (posX, posY, posZ);
    }

    [Event("OnPlayerQuit")]
    public void OnPlayerQuit(Player player)
    {
        NAPI.Chat.SendChatMessageToAll($"Player {player.Name} has left the server.");
    }
}