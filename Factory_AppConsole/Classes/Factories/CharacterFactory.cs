using Factory_AppConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_AppConsole.Classes.Factories
{
    public class CharacterSpecificFactory : IEntityFactory
    {
        string Type; string Nombre;

        public CharacterSpecificFactory(string type, string name)
        {
            Type = type;
            Nombre = name;
        }

        public IEntity CreateEntity()
        {
            Nombre += new Random().Next(1, 15);
            Nombre += new Random().Next(7, 21);
            switch (Type.ToLower())
            {
                case "saiyajin":
                    return new Saiyajin(Nombre);

                case "androide":
                    return new Androide(Nombre);

                case "namekiano":
                    return new Namekiano(Nombre);
                default:
                    return null;

            }
        }
    }
}
