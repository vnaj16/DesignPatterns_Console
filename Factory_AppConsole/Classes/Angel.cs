using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_AppConsole.Classes
{
    public class Angel : IEntity
    {
        public string Nombre { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Angel(string name)
        {
            Nombre = name;
        }

        public string Saludar()
        {
            return "Soy un angel";
        }
    }
}
