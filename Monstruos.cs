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

        public unsafe Monstruos(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas)
        {
            this.nombre = _nombre;
            this.direccion = _direc;
            this. ataque = _atq;
            this.defensa = _def;
            this.vidas = _vidas;
            this.modo = _modo;
            this.turnosDeEstado = 0;
            if (this.modo == false)
            {
                this.salud = defensa;
            } else
            {
                this.salud = ataque;
            }
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public int getAtaque()
        {
            return ataque;
        }
        public int getDefensa()
        {
            return defensa;
        }
        public bool getModo()
        {
            return modo;
        }
        public int getSalud()
        {
            return salud;
        }
        public int getVidas()
        {
            return vidas;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setDireccion(string _direccion)
        {
            direccion = _direccion;
        }
        public void setAtaque(int _ataque)
        {
            ataque = _ataque;
        }
        public void setDefensa(int _defensa)
        {
            defensa = _defensa;
        }
        public void setModo(bool _modo)
        {
            modo = _modo;
        }
        public void setSalud(int _salud)
        {
            salud = _salud;
        }
        public void setVidas(int _vidas)
        {
            vidas = _vidas;
        }
        public void restarVida(int _vidas)
        {
            vidas -= _vidas;
        }
        public void sumarVida(int _vidas)
        {
            vidas += _vidas;
        }
        public int getTurnosDeEstado()
        {
            return turnosDeEstado;
        }
        public void setTurnosDeEstado(int _turnosDeEstado)
        {
            turnosDeEstado = _turnosDeEstado;
        }
        public void cambiarModo()
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
        public unsafe void efectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            
        }
        public unsafe void efectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo)
        {

        }
    }
}
