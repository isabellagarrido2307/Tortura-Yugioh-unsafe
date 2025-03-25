using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class Nodo
    {
        private Nodo* siguiente {  get; set; }
        private Monstruos monstruo { get; set; }
        public Nodo(Monstruos _monstruo)
        {
            monstruo = _monstruo;
            siguiente = null;
        }
        public Nodo* getSiguiente()
        {
            return siguiente;
        }
        public void setSiguiente(Monstruos _monstruos)
        {
            monstruo = _monstruos;
        }
        
    }
}
