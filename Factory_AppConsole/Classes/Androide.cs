using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_AppConsole.Classes
{
    public class Androide : IEntity
    {
        public string Nombre { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Androide(string name)
        {
            Nombre = name;
            PosX = new Random(20).Next(1, 15);
            PosY = new Random(14).Next(1, 15);
        }

        public string Saludar()
        {
            return $"Hola, soy un androide, mi nombre es {Nombre}. ({PosX}, {PosY})";
        }
    }
}
