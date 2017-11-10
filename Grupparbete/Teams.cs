using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete
{
    class Teams : ITeam
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Skill}";
        }

        public class HV71 : Teams, ITeam
        {
            
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public HV71()
            {
                this.Name = "HV71";
                this.Skill = 75;
            }
        }
        public class Djurgården : Teams, ITeam
        {
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public Djurgården()
            {
                this.Name = "Djurgården";
                this.Skill = 60;
            }
        }

        public class Färjestad : Teams, ITeam
        {
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public Färjestad()
            {
                this.Name = "Färjestad";
                this.Skill = 85;
            }
        }

        public class Örebro : Teams, ITeam
        {
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public Örebro()
            {
                this.Name = "Örebro";
                this.Skill = 50;
            }
        }

        public class Södertälje : Teams, ITeam
        {
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public Södertälje()
            {
                this.Name = "Södertälje";
                this.Skill = 30;
            }
        }

        public class Brynäs : Teams, ITeam
        {
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public Brynäs()
            {
                this.Name = "Brynäs";
                this.Skill = 45;
            }
        }

        public class Växjö : Teams, ITeam
        {
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public Växjö()
            {
                this.Name = "Växjö";
                this.Skill = 90;
            }
        }

        public class Linköping : Teams, ITeam
        {
            new public string Name { get; set; }
            new public int Skill { get; set; }

            public Linköping()
            {
                this.Name = "Linköping";
                this.Skill = 70;
            }
        }


    }
   
}
