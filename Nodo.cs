using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class Nodo
    {
        public Monstruos* siguiente {  get; set; }
        public Monstruos* Monstruo { get; set; }
        public Nodo(Monstruos* _monstruo)
        {
            Monstruo = _monstruo;
            siguiente = null;
        }
        
    }
}
