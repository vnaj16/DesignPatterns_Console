using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_AppConsole.Classes
{
    public class Namekiano : IEntity
    {
        public string Nombre { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Namekiano(string name)
        {
            Nombre = name;
            PosX = new Random(45).Next(1, 15);
            PosY = new Random(12).Next(1, 15);
        }

        public string Saludar()
        {
            return $"Hola, soy del planeta Namekusei, mi nombre es {Nombre}. ({PosX}, {PosY})";
        }
    }
}
