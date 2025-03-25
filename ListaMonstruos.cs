using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class ListaMonstruos
    {
        public Nodo* cabeza;
        public ListaMonstruos()
        {
            cabeza = null;
        }

        public unsafe void Insertar(Monstruos _monstruo)
        {
            Nodo pepe = new Nodo(_monstruo);
            Nodo* nuevo = &pepe;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo* aux = cabeza;
                while (aux->siguiente != null)
                {
                    aux = aux->siguiente;
                }
                aux->siguiente = nuevo;
            }
        }
        public void Eliminar(Monstruos _monstruo)
        {
            Nodo* aux = cabeza;
            Nodo* aux2 = cabeza;
            if (cabeza->monstruo == _monstruo)
            {
                cabeza = cabeza->siguiente;
                return;
            }
            while (aux != null)
            {
                if (aux->monstruo == _monstruo)
                {
                    aux2->siguiente = aux->siguiente;
                    return;
                }
                aux2 = aux;
                aux = aux->siguiente;
            }
        }
    }
}