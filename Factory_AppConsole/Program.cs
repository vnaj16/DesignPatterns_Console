using Factory_AppConsole.Classes;
using Factory_AppConsole.Classes.Factories;
using Factory_AppConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Factory_AppConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            /*IEntity e1 = new Saiyajin("Goku");
            IEntity e2 = new Androide("N.18");

            Console.WriteLine(e1.Saludar());
            Console.WriteLine(e2.Saludar());*/

            /*IEntityFactory Factory = new CharacterSpecificFactory("saiyajin", "Vegeta");*/

            IEntityFactory Factory = new RandomCharacterFactory("");


            /*Console.WriteLine(Factory.CreateEntity().Saludar());
            Thread.Sleep(100);
            Console.WriteLine(Factory.CreateEntity().Saludar());
            Thread.Sleep(100);
            Console.WriteLine(Factory.CreateEntity().Saludar());
            Console.WriteLine(Factory.CreateEntity().Saludar());
            Thread.Sleep(100);
            Console.WriteLine(Factory.CreateEntity().Saludar());
            */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Factory.CreateEntity().Saludar());
                Thread.Sleep(100);
            }

            Console.ReadKey();
        }
    }
}
