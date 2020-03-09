using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_AppConsole
{
    public interface IEntity
    {
        string Nombre { get; set; }
        int PosX { get; set; }
        int PosY { get; set; }

        string Saludar();
   
    }
}
