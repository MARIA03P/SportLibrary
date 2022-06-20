using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLibrary
{
    public enum SportType
    {
        Runner,
        Jumper,
        Footbol,
        Biker
            
    }
    public interface Sportsman
    {
        public object ToDo(params object[] massiv);

        public double GetResult();
    

    }
}
