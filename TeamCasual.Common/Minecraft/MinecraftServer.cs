namespace TeamCasual.Common.Minecraft;

public record MinecraftServer(string ServerName, ServerType ServerType, string MinecraftVersion, ServerState State,
    string AvailabilityZone, DateTimeOffset? LaunchTime = null, string? PublicDNS = null, string? PublicIP = null);