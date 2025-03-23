using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public class Monstruos
    {
        private string nombre { get; set; }
        private string direccion {  get; set; }
        private int ataque {  get; set; }
        private int defensa { get; set; }
        private bool modo { get; set; }
        private int salud {  get; set; }
        private int turnosDeEstado { get; set; }
        private int vidas {  get; set; }
        public void efecto() { }
        Monstruos(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas)
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
