using System.Runtime.CompilerServices;

namespace JuegoCartas
{
    public class Jugador
    {
        private const int TOTAL_CARTAS = 10;
        private Carta[] cartas;
        private Random r = new Random();


        public void Repartir()
        {
            cartas = new Carta[TOTAL_CARTAS];

            for (int i = 0; i < TOTAL_CARTAS; i++)
            {
                cartas[i] = new Carta(r);
            }
        }

        public void Mostrar(ListView lv)
        {
            lv.Items.Clear();
            foreach (Carta carta in cartas)
            {
                carta.mostrar(lv);
            }
        }

        public string ObtenerGrupos()
        {
            string mensaje = "No se encontraron grupos";
            int[] contadores = new int[Enum.GetValues(typeof(NombreCarta)).Length];

            if (cartas != null && cartas.Length > 0)
            {
                foreach (Carta carta in cartas)
                {
                    contadores[(int)carta.ObtenerNombre()]++;
                }

                foreach (Carta carta in cartas)
                {
                    if (contadores[(int)carta.ObtenerNombre()] >= 3)
                    {
                        carta.marcarCartaUsada();
                    }
                }
            }


            bool hayGrupos = false;
            int posicionContador = 0;
            foreach (int contador in contadores)
            {
                if (contador >= 3)
                {
                    if (!hayGrupos)
                    {
                        mensaje = "Se encontraron los siguientes grupos:\n";
                        hayGrupos = true;
                    }
                    mensaje += Enum.GetValues(typeof(Grupo)).GetValue(contador).ToString() + " de " + Enum.GetValues(typeof(NombreCarta)).GetValue(posicionContador).ToString() + "\n";
                }
                posicionContador++;
            }

            return mensaje;
        }

        public string ObtenerSumatorias()
        {
            int puntosTotales = 0;
            string mensajePuntos = "";

            if (cartas != null && cartas.Length > 0)
            {
                foreach (Carta carta in cartas)
                {
                    int cartaPuntos = carta.ObtenerValorASumar();

                    if (carta.getYaSeUso()) cartaPuntos = 0;

                    puntosTotales += cartaPuntos;
                    mensajePuntos += $"\n+ {cartaPuntos} puntos por {(carta.getYaSeUso() ? "" : "no")} usar {carta.ObtenerNombre()} de {carta.ObtenerPinta()}";
                }
            }

            return $"Puntos totales: {puntosTotales} \n {mensajePuntos}";
        }

        public string ObtenerEscaleras()
        {
            int[] indices = new int[TOTAL_CARTAS];
           
            string mensajePuntos = "";

            int cont = 0;
            if (cartas != null && cartas.Length > 0)
            {
                foreach (Carta carta in cartas)
                {
                    mensajePuntos += "\n " + carta.getIndice();
                    indices[cont] = carta.getIndice();
                    cont++;
                }
            }

            var rango1 = Enumerable.Range(1, 13).ToArray();
            var rango2 = Enumerable.Range(14, 13).ToArray();
            var rango3 = Enumerable.Range(27, 13).ToArray();
            var rango4 = Enumerable.Range(40, 13).ToArray();

            string mensaje = "";
            mensaje += BuscarConsecutivos(indices, rango1, 0, cartas) + " \n\n";
            mensaje += BuscarConsecutivos(indices, rango2, 1, cartas) + " \n\n";
            mensaje += BuscarConsecutivos(indices, rango3, 2, cartas) + " \n\n";
            mensaje += BuscarConsecutivos(indices, rango4, 3, cartas) + " \n\n";

            return mensaje;
        }


        static string BuscarConsecutivos(int[] numeros, int[] rango, int idPinta, Carta[] cartas)
        {
            int[] numerosEnRango = new int[numeros.Length];
            int count = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >= rango[0] && numeros[i] <= rango[rango.Length - 1])
                {
                    numerosEnRango[count] = numeros[i];
                    count++;
                }
            }

            Array.Resize(ref numerosEnRango, count);
            Array.Sort(numerosEnRango);
            //MessageBox.Show($"Números en el rango {nombreRango}: {string.Join(", ", numerosEnRango)}", "Resultados");

            int consecutivos = 1;

            int[][] escaleras = new int[TOTAL_CARTAS][];
            int contEscalerasGuardadas = 0;

            int[] escaleraLargaDesdeA = new int[numerosEnRango.Length];
            bool tieneEscaleraDeA = false;
            int countEscaleraA = 0;

            int[] escaleraLargaHastaK = new int[numerosEnRango.Length];
            int countEscaleraLargaHastaK = 0;

            if (numerosEnRango.Length > 0 && rango.Length > 0 && numerosEnRango[0] == rango[0])
            {
                tieneEscaleraDeA = true;
                escaleraLargaDesdeA[0] = rango[0];
                countEscaleraA++;
            }

            for (int i = 1; i < numerosEnRango.Length; i++)
            {
                if (numerosEnRango[i] == numerosEnRango[i - 1] + 1)
                {
                    consecutivos++;

                    if (consecutivos >= 3)
                    {
                        escaleras[contEscalerasGuardadas] = numerosEnRango.Skip(i - (consecutivos - 1)).Take(consecutivos).ToArray();
                        contEscalerasGuardadas++;
                    }

                    escaleraLargaHastaK[countEscaleraLargaHastaK] = numerosEnRango[i - 1];
                    escaleraLargaHastaK[countEscaleraLargaHastaK + 1] = numerosEnRango[i];
                    countEscaleraLargaHastaK++;

                    if (tieneEscaleraDeA)
                    {
                        escaleraLargaDesdeA[i - 1] = numerosEnRango[i - 1];
                        escaleraLargaDesdeA[i] = numerosEnRango[i];
                        countEscaleraA++;
                    }
                }
                else
                {
                    escaleraLargaHastaK = new int[numerosEnRango.Length];
                    countEscaleraLargaHastaK = 0;

                    if (tieneEscaleraDeA)
                    {
                        tieneEscaleraDeA = false;
                        Array.Resize(ref escaleraLargaDesdeA, countEscaleraA);
                    }

                    consecutivos = 1;
                }

                int lastIndex = numerosEnRango.Length - 1;

                if (i == lastIndex && numerosEnRango[lastIndex] == rango[rango.Length - 1] && countEscaleraA > 0)
                {
                    consecutivos += escaleraLargaDesdeA.Length;
                    if (countEscaleraLargaHastaK == 0)
                    {
                        escaleraLargaHastaK[0] = numerosEnRango[lastIndex];
                    }
                    Array.Resize(ref escaleraLargaHastaK, countEscaleraLargaHastaK + 1);
                    int[] escaleraConcatenada = escaleraLargaHastaK.Concat(escaleraLargaDesdeA).ToArray();

                    if (escaleraConcatenada.Length >= 3)
                    {
                        escaleras[contEscalerasGuardadas++] = escaleraConcatenada;
                    }
                }
            }

            string mensaje = "";

            if (contEscalerasGuardadas > 0)
            {


                marcarCartaComoUsada(contEscalerasGuardadas, escaleras, cartas);
                for (int i = 0; i < contEscalerasGuardadas; i++)
                {
                    for (int j = 0; j < escaleras[i].Length; j++)
                    {
                        int residuo = escaleras[i][j] % 13;
                        if (residuo == 0)
                        {
                            residuo = 13;
                        }

                        mensaje += $"\n {Enum.GetValues(typeof(NombreCarta)).GetValue((residuo - 1)).ToString()} de {Enum.GetValues(typeof(Pinta)).GetValue((idPinta)).ToString()}";
                    }
                    mensaje += $"\n\n ---------------------------------- \n";
                }
            }
            else
            {
                mensaje = $"No se encontraron escaleras de {Enum.GetValues(typeof(Pinta)).GetValue((idPinta)).ToString()}\n";
            }
            return mensaje;
        }

        static void marcarCartaComoUsada(int contEscalerasGuardadas, int[][] escaleras, Carta[] cartas)
        {
            foreach (Carta carta in cartas)
            {
                bool encontrado = false;

                for (int i = 0; i < contEscalerasGuardadas; i++)
                {
                    for (int j = 0; j < escaleras[i].Length; j++)
                    {
                        if (escaleras[i][j] == carta.getIndice())
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    if (encontrado)
                    {
                        carta.marcarCartaUsada();
                        break;
                    }
                }
            }
        }
    }
}
