using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete
{
    class HockeyTeams : ITeam
    {
        
        Random rnd = new Random();
        public string Name { get; set; }
        public int Skill { get; set; }


        public HockeyTeams()
        {
            this.Name = Name;
            this.Skill = Skill;
          
        }

        public HockeyTeams(string name, int skill)
        {

            

            HockeyTeams färjestad = new HockeyTeams("Färjestad", 70);
            HockeyTeams djurgården = new HockeyTeams("Djurgården", 60);
            HockeyTeams örebro = new HockeyTeams("Örebro", 50);
            HockeyTeams brynäs = new HockeyTeams("Brynäs", 55);
            HockeyTeams linköping = new HockeyTeams("Linköping", 75);
            HockeyTeams södertälje = new HockeyTeams("Södertälje", 30);
            HockeyTeams växjö = new HockeyTeams("Växjö", 90);
            HockeyTeams skellefteå = new HockeyTeams("Skellefteå", 80);

        }
        public void Run()
        {
            
            int rndTeam = rnd.Next(8);
            //int rndTeam = rnd.Next(8);
            foreach (var item in HockeyTeams()
            {
                Console.WriteLine(item);
            }
        }
    }
}


