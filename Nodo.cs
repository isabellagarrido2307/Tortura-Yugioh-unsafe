using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class Nodo
    {
        public Nodo* siguiente {  get; set; }
        public Monstruos* monstruo { get; set; }
        public Nodo(Monstruos* _monstruo)
        {
            monstruo = _monstruo;
            siguiente = null;
        }
        
    }
}
