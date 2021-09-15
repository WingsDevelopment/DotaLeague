using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Bot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            test();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void  test()
        {

            try
            {
                DotaClient client = DotaClient.Create("pharalnaga",
                    "Centaur-17",
                    "926BB2F00928E7C5AD23335757D8BB19");

                client.Connect();

                //client.dota.request
                client.Reset();
                client.CreateLobby("test1",
                    "test1",
                    new ulong[] { 76561198135923507 },
                    new ulong[] { });

                //client.InviteToLobby(76561198135923507);
                ////client.InviteToLobby(87828889);

                //client.OnGameFinished += Client_OnGameFinished;
                //client.OnGameStarted += Client_OnLobbyCreated;
                Console.WriteLine("Lobby Started");
                //client.Reset();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Client_OnLobbyCreated(ulong a)
        {
            Console.WriteLine("Match_ID: " + a);
        }

        private static void Client_OnGameFinished(DotaGameResult Outcome)
        {
            if (Outcome == DotaGameResult.Radiant)
            {
                //Radiant Win
                Console.WriteLine("Radiant won");
            }
            else if (Outcome == DotaGameResult.Dire)
            {
                // Dire Win
                Console.WriteLine("Dire won");
            }
            else
            {
                // Error Occured
                Console.WriteLine("Error");
            }
        }
    }
}
