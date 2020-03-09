using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_AppConsole.Classes
{
    public class Saiyajin : IEntity
    {
        public string Nombre { get; set; }
        public int PosX { get ; set; }
        public int PosY { get; set; }

        public Saiyajin(string name)
        {
            Nombre = name;
            PosX = new Random(5).Next(1,15);
            PosY = new Random(18).Next(1, 15);
        }

        public string Saludar()
        {
            return $"Hola, soy un saiyajin, mi nombre es {Nombre}. ({PosX}, {PosY})";
        }
    }
}
