using System.Windows.Forms;

namespace JuegoCartas
{
    public partial class Frmjuego : Form
    {
        Jugador jugador1, jugador2;


        public Frmjuego()
        {
            InitializeComponent();
            jugador1 = new Jugador();
            jugador2 = new Jugador();
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            jugador1.Repartir();
            jugador1.Mostrar(lvJugador1);

            jugador2.Repartir();
            jugador2.Mostrar(lvJugador2);
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            switch (TcJugadores.SelectedIndex)
            {
                case 0:
                    MessageBox.Show($"{jugador1.ObtenerGrupos()} \n\n\n {jugador1.ObtenerEscaleras()}", "Escaleras");
                    MessageBox.Show(jugador1.ObtenerSumatorias(), "Sumatoria de puntos");

                    break;
                case 1:
                    MessageBox.Show(jugador2.ObtenerGrupos());
                    MessageBox.Show(jugador2.ObtenerEscaleras());
                    break;
            }
        }
    }
}
