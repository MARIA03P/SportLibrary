using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLibrary
{
    class Footbol : Sportsman
    {
        private string firstname = string.Empty;
        public string FirstName { get { return firstname; } set { this.firstname = value; } }
        
        public string LastName { get; set; }
        public int Age { get; }
        public double Velocity { get; set; }
        public double time { get; set; }
        public SportType SportType { get; set; }

        public double GetResult()
        {
            return time;
        }


        // <summary>
        /// Данный метод имметирует бег спортсмена во время забега. Дистанция, скорость бега, скорость ветра.
        /// </summary>
        public object ToDo(params object[] massiv)
        {
            double distance = (double)massiv[0];
            
            double velocityWind = (double)massiv[1];
            double time = distance / (Velocity + velocityWind);
            this.time = time;
            return time;


        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} - {time}";
        }
    }
}

