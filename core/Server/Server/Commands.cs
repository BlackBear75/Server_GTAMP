using GTANetworkAPI;


class Commands : Script
{
    [Command("pos")]
    public void Cmd_GetPos(Player player)
    {
        Vector3 playerPosition = player.Position;
        Vector3 playerRotation = player.Rotation;

        NAPI.Util.ConsoleOutput($"{playerPosition.X},{playerPosition.Y},{playerPosition.Z}");

        NAPI.Util.ConsoleOutput($"{playerRotation.X},{playerRotation.Y},{playerRotation.Z}");
    }

    [Command("veh")]
    public void Cmd_SpawnVehicle(Player player, string vehicleModel)
    {
        Vehicle vehicle = NAPI.Vehicle.CreateVehicle(NAPI.Util.GetHashKey(vehicleModel), player.Position, player.Rotation.Z, 0, 0);
        vehicle.SetData("owner", player);
        NAPI.Util.ConsoleOutput($"Vehicle {vehicleModel} spawned for {player.Name}");
    }

    [Command("money")]
    public void Cmd_CheckMoney(Player player)
    {
        int balance = player.GetData<int>("money");
        player.SendChatMessage($"Your balance: ${balance}");
    }

    [Command("give")]
    public void Cmd_GiveMoney(Player player, Player targetPlayer, int amount)
    {
        int senderBalance = player.GetData<int>("money");
        if (senderBalance >= amount)
        {
            player.SetData("money", senderBalance - amount);
            int targetBalance = targetPlayer.GetData<int>("money");
            targetPlayer.SetData("money", targetBalance + amount);
            player.SendChatMessage($"You gave ${amount} to {targetPlayer.Name}");
        }
        else
        {
            player.SendChatMessage("You do not have enough money!");
        }
    }


}
