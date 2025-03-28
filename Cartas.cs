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
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            ListaMonstruos* aux = CampoAliado;
            while (aux->cabeza != null)
            {
                if (aux->cabeza->getMonstruo().getNombre() == "Aymara Reina Peluche")
                {
                    this.setAtaque(2000);
                    this.setDefensa(2200);
                    return;
                }
                aux->cabeza = aux->cabeza->getSiguiente();
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
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            this.setAtaque(getAtaque()+100);
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
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo)
        {
            ListaMonstruos* aux = CampoEnemigo;
            while (aux->cabeza!= null)
            {
                if (aux->cabeza->getMonstruo().getAtaque() < this.getAtaque())
                {
                    CementerioEnemigo->Insertar(aux->cabeza->getMonstruo());
                    CampoEnemigo->Eliminar(aux->cabeza->getMonstruo());
                }
            }
        }
    }

}
