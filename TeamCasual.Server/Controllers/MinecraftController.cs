using Microsoft.AspNetCore.Mvc;
using TeamCasual.Common.Minecraft;

namespace TeamCasual.Server.Controllers;

[Route("minecraft")]
[ApiController]
public class MinecraftController : Controller
{
    [HttpGet]
    [Route("servers")]
    public IActionResult GetServers()
    {
        List<MinecraftServer> servers = new()
        {
            new MinecraftServer (
            ServerName: "Dummy Server",
            ServerType: ServerType.Vanilla,
            MinecraftVersion: "1.20",
            State: ServerState.Running,
            AvailabilityZone: "eu-west",
            LaunchTime: DateTime.Now,
            PublicDNS: "www.im-a-server.com",
            PublicIP: "192.168.1.20"
            ),
            new MinecraftServer (
            ServerName: "Test Server",
            ServerType: ServerType.Vanilla,
            MinecraftVersion: "1.19",
            State: ServerState.Stopped,
            AvailabilityZone: "eu-west"
            )
        };

        return Ok(servers);
    }

    [HttpGet]
    [Route("servers/start/{serverName}")]
    public IActionResult StartServer(string serverName)
    {
        if (string.IsNullOrWhiteSpace(serverName))
        {
            throw new ArgumentNullException(nameof(serverName));
        }

        return Ok($"STARTING server: {serverName}");
    }

    [HttpGet]
    [Route("servers/stop/{serverName}")]
    public IActionResult Stop(string serverName)
    {
        if (string.IsNullOrWhiteSpace(serverName))
        {
            throw new ArgumentNullException(nameof(serverName));
        }

        return Ok($"STOPPING server: {serverName}");
    }
}
