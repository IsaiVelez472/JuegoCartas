using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JuegoCartas
{
    public class Carta
    {
        private int indice;
        private bool yaSeUso;

        public Carta(Random r)
        {
            indice = r.Next(52) + 1;
            yaSeUso = false;
        }

        public Pinta ObtenerPinta()
        {
            if (indice <= 13)
            {
                return Pinta.TREBOL;
            }
            else if (indice <= 26)
            {
                return Pinta.PICA;
            }
            else if (indice <= 39)
            {
                return Pinta.CORAZON;
            }
            else
            {
                return Pinta.DIAMANTE;
            }
        }

        public NombreCarta ObtenerNombre()
        {
            int residuo = indice % 13;
            if (residuo == 0)
            {
                residuo = 13;
            }
            return (NombreCarta)Enum.GetValues(typeof(NombreCarta)).GetValue(residuo - 1);
        }

        public int ObtenerValorASumar()
        {
            int puntosASumar = (int)ObtenerNombre() + 1;

            if (puntosASumar == 1 || puntosASumar >= 11)
            {
                puntosASumar = 10;
            }

            return puntosASumar;
        }

        public void mostrar(ListView lv)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.ImageIndex = indice - 1;
            lv.Items.Add(lvi);
        }

        public void marcarCartaUsada()
        {
            yaSeUso = true;
        }

        public bool getYaSeUso()
        {
            return yaSeUso;
        }

        public int getIndice()
        {
            return indice;
        }
    }
}
