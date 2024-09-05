using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CyberDefenseProject
{
    internal class Attack
    {
       
        public string ThreatType { get; set; }

        public int Volume { get; set; }

        public int Sophistication { get; set; }
        public string Target { get; set; }



        //מציאת חומרת התקפה
        public int FormulaCalculatingSeverity()
        {
            if(Target== "Web Server")
            {
                return (Volume * Sophistication) + 10;
            }
            else if(Target== "Database")
            {
                return (Volume * Sophistication) + 15;
            }
            else if (Target== "User Credentials")
            {
                return (Volume * Sophistication) + 20; 
            }
            else
            {
                return (Volume * Sophistication) + 5;
            }
        }
    }
   
}
