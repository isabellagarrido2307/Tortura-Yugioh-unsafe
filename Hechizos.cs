﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public unsafe class Hechizos
    {
        private string nombre;
        private string direccion;
        public Hechizos()
        {
            nombre = "";
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string _direccion)
        {
            direccion = _direccion;
        }
        public void activarEfecto(Monstruos* Monstruo, ListaMonstruos* Campo, ListaMonstruos* Cementerio, int* Vida)
        {
            
        }
    }
}
