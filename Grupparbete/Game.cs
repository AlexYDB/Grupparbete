using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete
{
    class Game : Teams
    {
        
        
        Random rnd = new Random();
        
        public List<Teams> Teams()
        {
            List<Teams> teams = new List<Teams>();
            teams.Add(new HV71());
            teams.Add(new Brynäs());
            teams.Add(new Södertälje());
            teams.Add(new Djurgården());
            teams.Add(new Örebro());
            teams.Add(new Växjö());
            teams.Add(new Linköping());
            teams.Add(new Färjestad());
            return teams;
        }
        public void Run()
        {
            List<Teams> teams = new List<Teams>();
            
            //game = Teams();

            //List<Teams> teams = new List<Teams>();
            //var amountofTeams = rnd.Next(game.Count -1)
            //string nameofTeam = teams[amountofTeams];
            //Console.WriteLine(nameofTeam);
        }

    }
            

        
        
       
}





