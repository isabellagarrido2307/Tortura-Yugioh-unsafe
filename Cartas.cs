using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Yu_Gi_Oh
{
    public class AlaEscudo : Monstruos
    {
        public AlaEscudo(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {

        }
    }
    public class AlejandroLapiz : Monstruos
    {
        public AlejandroLapiz(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {

        }
    }
    public unsafe class Alfonsina : Monstruos
    {
        public Alfonsina(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {
            
        }
        public void EfectoDespliegue(ListaMonstruos Lista)
        {
            ListaMonstruos aux = Lista;
            while (aux.cabeza != null)
            {
                if (Lista.cabeza->monstruo.nombre == "Aymara Reina Peluche")
                {
                    this.ataque = 2000;
                    this.defensa = 2200;
                    return;
                }
                aux.cabeza = aux.cabeza->siguiente;
            }
        }
    }
    public class AndresAbsoluto : Monstruos
    {
        public AndresAbsoluto(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {

        }
        public void EfectoDespliegue()
        {
            
        }

    }
    public class AngelIntegral : Monstruos
    {
        public AngelIntegral(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {
        }
        public void EfectoAtaque()
        {
            this.ataque += 100;
        }
    }
    public class AymaraPeluche : Monstruos
    {
        public AymaraPeluche(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {
        }
        public void EfectoDespliegue()
        {

        }
    }
    public class CaballeroOscuro : Monstruos
    {
        public CaballeroOscuro(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {
        }
        public void EfectoAtaque()
        {

        }
    }
    public unsafe class ChacinDomino : Monstruos
    {
        public ChacinDomino(string _nombre, string _direc, int _atq, int _def, bool _modo, int _vidas) : base(_nombre, _direc, _atq, _def, _modo, _vidas)
        {
        }

        //AGREGA AUXILIAR
        public ListaMonstruos EfectoAtaque(ListaMonstruos lista, int ataqueDestruido)
        {
            while (lista.cabeza != null)
            {
                if (lista.cabeza->monstruo.ataque < ataqueDestruido)
                {
                    
                    return lista;
                }
                lista.cabeza->monstruo.ataque -= 100;
                lista.cabeza = lista.cabeza->siguiente;
            }
            return lista;
        }
    }

}
