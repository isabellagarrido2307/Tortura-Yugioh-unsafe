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
        public AlaEscudo()
        {
            setNombre("Ala Escudo");
            setDireccion("Defensa");
            setAtaque(100);
            setDefensa(1000);
            setVidas(2);
            setModo(true);
            if (getModo())
            {
                setSalud(100);
            }
            else
            {
                setSalud(1000);
            }
            setTurnosDeEstado(0);
        }
    }
    public class AlejandroLapiz : Monstruos
    {
        public AlejandroLapiz() 
        {
            setNombre("Alejandro Roba Lapices");
            setDireccion("Ataque");
            setAtaque(1000);
            setDefensa (1000);
            setVidas(1);
            setModo(true);
            if (getModo())
            {
                setSalud(1000);
            }
            else
            {
                setSalud(1000);
            }
            setTurnosDeEstado(0);
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            setAtaque(getAtaque() / 2);
        }
    }
    public unsafe class Alfonsina : Monstruos
    {
        public Alfonsina() 
        {
            setNombre("Alfonsina Peluche");
            setDireccion("Defensa");
            setAtaque(1000);
            setDefensa(1200);
            setVidas(1);
            setModo(true);
            if (getModo())
            {
                setSalud(1000);
            }
            else
            {
                setSalud(1200);
            }
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
        public AndresAbsoluto()
        {
            setNombre("Andres el Absoluto");
            setDireccion("Ataque");
            setAtaque(0);
            setDefensa(0);
            setVidas(1);
            setModo(true);
            if (getModo())
            {
                setSalud(0);
            }
            else
            {
                setSalud(0);
            }

        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
                Nodo* aux = CampoAliado->cabeza;
                while (aux != null)
                {
                    aux->getMonstruo().setAtaque(0);
                    aux->getMonstruo().setDefensa(0);
                    aux = aux->getSiguiente();
                }
        }

    }
    public class AngelIntegral : Monstruos
    {
        public AngelIntegral() 
        {
                setNombre("Angel Hombre Integral");
                setDireccion("Ataque");
                setAtaque(2000);
                setDefensa(2000);
                setVidas(1);
                setModo(true);
                setSalud(getAtaque());
            }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            this.setAtaque(getAtaque()+100);
        }
    }
    public class AymaraPeluche : Monstruos
    {
        public AymaraPeluche() 
        {
            setNombre("Aymara Reina Peluche");
            setDireccion("Ataque");
            setAtaque(1700);
            setDefensa(1300);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoAliado->cabeza;
            int contador = 0;
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            if (contador <= 6)
            {
                CampoAliado->Insertar(new Alfonsina());
            }
        }
    }
    public class CaballeroOscuro : Monstruos
    {
        public CaballeroOscuro() 
        {
             setNombre("Caballero Oscuro");
             setDireccion("Ataque");
             setAtaque(1800);
             setDefensa(1600);
             setVidas(1);
             setModo(true);
             setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {

        }
    }
    public unsafe class ChacinDomino : Monstruos
    {
        public ChacinDomino() 
        {
            setNombre("Chacin Domino");
            setDireccion("Ataque");
            setAtaque(1600);
            setDefensa(1400);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
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
    public unsafe class DragonFuego : Monstruos
    {
        public DragonFuego()
        {
            setNombre("Dragon de Fuego");
            setDireccion("Ataque");
            setAtaque(2500);
            setDefensa(2000);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo, ListaMonstruos* CementerioAliado, ListaMonstruos* CementerioEnemigo, Monstruos* CartaAtacar)
        {
            if (CartaAtacar->getDefensa() < 1500)
            {
                CampoEnemigo->Eliminar(*CartaAtacar);
            }
        }
    }
    public unsafe class FamiliaUnida : Monstruos
    {
        public FamiliaUnida()
        {
            setNombre("Familia Ingeniera Unida");
            setDireccion("Defensa");
            setAtaque(99999);
            setDefensa(99999);
            setVidas(1);
            setModo(true);
            setSalud(99999);
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoAliado->cabeza;
            while (aux != null)
            {
                aux->getMonstruo().setAtaque(9999);
                aux->getMonstruo().setDefensa(9999);
                aux = aux->getSiguiente();
            }
        }
    }
    public unsafe class GabrielConductor : Monstruos
    {
        public GabrielConductor()
        {
            setNombre("Gabriel Experto Conductor");
            setDireccion("Ataque");
            setAtaque(1500);
            setDefensa(1200);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            setAtaque(getAtaque() + 100);
        }
    }
    public unsafe class GinoPeloCotufa : Monstruos
    {
        public GinoPeloCotufa()
        {
            setNombre("Gino Pelo e Cotufa");
            setDireccion("Ataque");
            setAtaque(1700);
            setDefensa(1300);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoEnemigo->cabeza;
            int contador = 0;
            while (aux != null)
            {
                contador++;
                aux = aux->getSiguiente();
            }
            setAtaque(getAtaque() + contador * 100);
        }
    }
    public unsafe class GuerreroRelampago : Monstruos
    {
        public GuerreroRelampago()
        {
            setNombre("Guerrero Relampago");
            setDireccion("Ataque");
            setAtaque(1900);
            setDefensa(1200);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoAtaque(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoAliado->cabeza;
            while (aux != null)
            {
                aux->getMonstruo().setAtaque(aux->getMonstruo().getAtaque() + 100);
                aux = aux->getSiguiente();
            }
        }
    }
    public unsafe class Imitador : Monstruos
    {
        public Imitador()
        {
            setNombre("Imitador");
            setDireccion("Ataque");
            setAtaque(0);
            setDefensa(0);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoEnemigo->cabeza;
            int defensa = 0;
            int ataque = 0;
            while (aux != null)
            {
                if (aux->getMonstruo().getAtaque() < ataque)
                {
                    ataque = aux->getMonstruo().getAtaque();
                }
                if (aux->getMonstruo().getDefensa() < defensa)
                {
                    defensa = aux->getMonstruo().getDefensa();
                }
                aux = aux->getSiguiente();
            }
            setDefensa(defensa);
            setAtaque(ataque);
        }
    }
    public unsafe class Isabella : Monstruos
    {
        public Isabella()
        {
            setNombre("Isabella Fan Gatuna");
            setDireccion("Ataque");
            setAtaque(1300);
            setDefensa(1600);
            setVidas(1);
            setModo(true);
            setSalud(getAtaque());
        }
        public unsafe void EfectoDespliegue(ListaMonstruos* CampoAliado, ListaMonstruos* CampoEnemigo)
        {
            Nodo* aux = CampoEnemigo->cabeza;
            while (aux != null)
            {
                aux->getMonstruo().setAtaque(getAtaque()-400);
                aux->getMonstruo().setDefensa(getDefensa()-400);
                aux = aux->getSiguiente();
            }
        }
    }
}
