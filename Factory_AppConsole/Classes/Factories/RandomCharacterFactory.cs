using Factory_AppConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_AppConsole.Classes.Factories
{
    public class RandomCharacterFactory : IEntityFactory
    {
        int Number;
        string Nombre;

        public RandomCharacterFactory(string Nombre)
        {

            this.Nombre = Nombre;
        }

        public IEntity CreateEntity()
        {
            Number = new Random().Next(1, 9);

            if (Number==1 ||  Number ==3 || Number == 8)
            {
                return new Saiyajin(Nombre);
            }
            else if(Number==2 || Number == 5)
            {
                return new Namekiano(Nombre);
            }
            else if (Number == 4)
            {
                return new Angel(Nombre);
            }
            else
            {
                return new Androide(Nombre);
            }
        }
    }
}
