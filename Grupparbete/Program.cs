using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete
{
    class Program
    {
        static void Main(string[] args)
        {
            Teams.HV71 teams = new Teams.HV71();
            Console.WriteLine(teams.Name);
            Game game = new Game();
            game.Run();
        }
    }
}
