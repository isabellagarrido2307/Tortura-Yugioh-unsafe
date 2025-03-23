namespace Proyecto_Yu_Gi_Oh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void InicializarCartas()
        {
            //Monstruos AlaEscudo = new Monstruos("Ala Escudo", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\AlaEscudo.jpg", 100, 1000, false, 3);
            //Monstruos AlejandroLapiz = new Monstruos("Alejandro Roba Lapices", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\AlejandroLapiz.jpg", 1000, 1000, false, 1);
            //Monstruos Alfonsina = new Monstruos("Alfonsina Peluche", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\Alfonsina.jpg", 1000, 1200, false, 1);
            //Monstruos AndresAbsoluto = new Monstruos("Andres el Absoluto", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\AndresAbsoluto.jpg", 2000, 2500, false, 1);
            //Monstruos AngelIntegral = new Monstruos("Angel hombre Integral", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\AngelIntegral.jpg", 2000, 2500, false, 1);
            //Monstruos AymaraPeluche = new Monstruos("Aymara Reina Peluche", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\AymaraPeluche.jpg", 1700, 1300, false, 1);
            //Monstruos CaballeroOscuro = new Monstruos("Caballero Oscuro", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\CaballeroOscuro.jpg", 1800, 1600, false, 1);
            //Monstruos ChacinDomino = new Monstruos("Chacin Domino", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\ChacinDomino.jpg", 1600, 1400, false, 1);
            //Monstruos DragonFuego = new Monstruos("Dragon de Fuego", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\DragonFuego.jpg", 2500, 2000, false, 1);
            //Monstruos FamiliaUnida = new Monstruos("Familia Ingeniera Unida", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\FamiliaUnida.jpg", 9999, 9999, false, 1);
            //Monstruos GabrielExperto = new Monstruos("Gabriel Experto Conductor", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\GabrielExperto.jpg", 1500, 1200, false, 1);
            //Monstruos GinoPeloCotufa = new Monstruos("Gino Pelo e Cotufa", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\GinoPeloCotufa.jpg", 1700, 1300, false, 1);
            //Monstruos GolemPiedra = new Monstruos("Golem de Piedra", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\GolemPiedra.jpg", 2000, 2500, false, 1);
            //Monstruos GuerreroRelampago = new Monstruos("Guerrero Relampago", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\GuerreroRelampago.jpg", 1900, 1200, false, 1);
            //Monstruos Imitador = new Monstruos("Imitador", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\Imitador.jpg", 0, 0, false, 1); //No tiene ataque ni defensa
            //Monstruos IsabellaGatos = new Monstruos("Isabella Fan Gatuna", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\IsabellaGatos.jpg", 1300, 1600, false, 1);
            //Monstruos Kuriboh = new Monstruos("Kuriboh", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\Kuriboh.jpg", 500, 500, false, 1);
            //Monstruos KuribohAlado = new Monstruos("Kuriboh Alado", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\KuribohAlado.jpg", 500, 500, false, 1);
            //Monstruos LadronFantasma = new Monstruos("Ladron Fantasma", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\LadronFantasma.jpg", 1600, 1400, false, 1);
            //Monstruos MagoSombrio = new Monstruos("Mago Sombrio", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\MagoSombrio.jpg", 1700, 1300, false, 1);
            //Monstruos MiguelMondaquera = new Monstruos("Miguel Mondaquera", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\MiguelMondaquera.jpg", 1600, 1700, false, 1);
            //Monstruos PollueloSonico = new Monstruos("Polluelo Sonico", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\PollueloSonico.jpg", 900, 900, false, 1);
            //Monstruos RataBlindada = new Monstruos("Rata Blindada", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\RataBlindada.jpg", 500, 2000, false, 1);
            //Monstruos RoedorMalicioso = new Monstruos("Roedor Malicioso", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\RoedorMalicioso.jpg", 1400, 1200, false, 1);
            //Monstruos RompeEscudos = new Monstruos("Rompe Escudos", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\RompeEscudos.jpg", 1000, 800, false, 1);
            //Monstruos SebastianGacha = new Monstruos("Sebastian, señor del Gacha", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\SebastianGacha.jpg", 1200, 1300, false, 1);
            //Monstruos SergioEmbaucador = new Monstruos("Sergio el Embaucador", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\SergioEmbaucador.jpg", 1500, 1500, false, 1);
            //Monstruos SliferCielo = new Monstruos("Slifer señor del Cielo", "\\Tortura-Yugioh-unsafe\\Material Yu-Gi-Oh\\Yu-Gi-Oh\\Cartas\\Monstruos\\SliferCielo.jpg", 0, 0, false, 1); //No tiene ataque ni defensa


        }
    }
}
