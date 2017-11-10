using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete
{
    class Game : Teams
    {

        private List<Teams> rndList;
        Random rnd = new Random();
        
        public List<Teams> TeamList()
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
            rndList = TeamList();

            int rndTeam = rnd.Next(8);
            foreach (var item in rndList)
            {
                
                Console.WriteLine(item + " X " + item );
            }
            
        }
    }
}
           

       
            
            
           
            

            

        
        
       





