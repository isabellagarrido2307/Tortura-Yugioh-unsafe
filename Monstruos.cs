using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public class Monstruos
    {
        public string nombre { get; set; }
        public string direccion {  get; set; }
        public int ataque {  get; set; }
        public int defensa { get; set; }
        public bool modo { get; set; }
        public int salud {  get; set; }
        public int turnosDeEstado { get; set; }
        public int vidas {  get; set; }
        public void efecto() { }
        public Monstruos(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas)
        {
            this.nombre = _nombre;
            this.direccion = _direc;
            this. ataque = _atq;
            this.defensa = _def;
            this.vidas = _vidas;
            this.modo = _modo;
            if (this.modo == false)
            {
                this.salud = defensa;
            } else
            {
                this.salud = ataque;
            }
        }
        public void CambiarModo()
        {
            if (modo == false)
            {
                salud = ataque;
                modo = true;
            }
            else
            {
                salud = defensa;
                modo = false;
            }
        }
        public void EfectoDespliegue() { }
    }
}
