using System;
using System.Drawing;
using System.Windows.Forms;

namespace PagosCredito
{
    public partial class Form1 : Form
    {
        double Credito, Min_Prestamo, Max_Prestamo, Min_Interes, Max_Interes, Incremento, Pago;
        int Tipos_Interes, Tiempo_Mes;

        private void msOpciones_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void msPrestamos_Meses_Click(object sender, EventArgs e)
        {
            msPrestamos_Tiempo.Enabled = true;
            msPrestamos_Tiempo.Checked = true;
            msPrestamos_Meses.Enabled = false;
            msPrestamos_Meses.Checked = false;
        }

        private void msPrestamos_Tiempo_Click(object sender, EventArgs e)
        {
            msPrestamos_Tiempo.Enabled = false;
            msPrestamos_Tiempo.Checked = false;
            msPrestamos_Meses.Enabled = true;
            msPrestamos_Meses.Checked = true;
        }

        private void msAyuda_AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diego Florian", "Mi programa");
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void msOpciones_Instrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.\tIngresa tu Credito.\n2.\tPulse [Pagos] para visualizar los pagos.\n3.\tBusque el pago correspondiente, mensual.\n4.\tPulse [Amortizar].\n5.\tPuede copiarlos con `Ctrl + C`", "Como usarlo");
        }

        public Form1()
        {
            InitializeComponent();
            ImprimirTabla(4, 4);
        }

        private void ImprimirTabla(int filas, int columnas)
        {
            for (int c = 1; c <= columnas; c++)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "Columna " + c;
                dgDatosDeImprension.Columns.Add(columna);
            }

            string[] fila = new string[columnas + 1];
            for (int f = 1; f <= filas; f++)
                dgDatosDeImprension.Rows.Add(fila);
        }
        private void CalcularPago()
        {
            try
            {
                Credito = double.Parse(udCredito.Text);
                Min_Prestamo = double.Parse(txtMinimo_Prestamo.Text);
                Max_Prestamo = double.Parse(txtMaximo_Pestamo.Text);
                Min_Interes = double.Parse(txtMinimo_Interes.Text);
                Max_Interes = double.Parse(txtMaximo_Interes.Text);
                Incremento = double.Parse(cbIncremento.Text); 
                if (
                    Credito <= 0 |
                    Min_Prestamo <= 0 |
                    Max_Prestamo <= 0 |
                    Incremento <= 0 |
                    Min_Interes <= 0 |
                    Max_Interes <= 0 |
                    Min_Interes >= Max_Interes |
                    Min_Prestamo >= Max_Prestamo
                    )
                        throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Algun Dato NO es Invalido", "¡Error!");
            }
            Tipos_Interes = Convert.ToInt32((Max_Interes * Min_Interes / Incremento) + 1);
            Tiempo_Mes = Convert.ToInt32(Max_Prestamo - Min_Prestamo + 1);

            int Filas = Tipos_Interes, Columnas = Tiempo_Mes;
            if (Tipos_Interes < 18)
                Filas = 18;
            if (Tiempo_Mes < 4)
                Columnas = 4;

            dgDatosDeImprension.Columns.Clear();
            dgDatosDeImprension.Rows.Clear();
            ImprimirTabla(Filas, Columnas);

            string S;
            S = string.Format("{0,5:P2}", Min_Interes / 100);
            for (int f = 0; f <= Tipos_Interes - 1; f++)
                dgDatosDeImprension.Rows[f].HeaderCell.Value = S;

            string Periodo = "Años";
            if (!msPrestamos_Tiempo.Enabled)
                Periodo = "Meses";

            for (int c = 0; c <= Tiempo_Mes - 1; c++)
                dgDatosDeImprension.Columns[c].HeaderText = string.Format("{0,5:P2}", (Min_Prestamo + c) + Incremento);

            int P = 0;
            if (!msPrestamos_Tiempo.Enabled)
                P = 12;
            else
                P = 1;

            double interes;
            int meses;
            string Sin_Interes, Meses;

            for (int f = 0; f <= Tipos_Interes - 1; f++)
            {
                Sin_Interes = dgDatosDeImprension.Rows[f].HeaderCell.Value.ToString();
                Sin_Interes = Sin_Interes.Substring(0, Sin_Interes.IndexOf('%'));
                interes = double.Parse(Sin_Interes) / 100 / 12;

                for (int c = 0; c <= Tiempo_Mes-1; c++)
                {
                    Meses = dgDatosDeImprension.Columns[c].HeaderText;
                    Meses = Meses.Substring(0, Meses.IndexOf('.'));
                    if (Meses.Contains(","))
                        Meses = Meses.Replace(",", string.Empty);
                    meses = (int)Convert.ToInt64(Meses);

                    if (interes == 0.0)
                        Pago = Credito / meses;
                    else
                        Pago = Credito * (interes / (1 - (1 / (Math.Pow(1.0 + interes, Convert.ToDouble(meses))))));
                    S = string.Format("{0,5:P2}", Pago);
                    dgDatosDeImprension.Rows[f].Cells[c].Value = " "+S;
                }
            }
            btnPagos.Enabled = false;
            btnAmotizacion.Enabled = true;
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            CalcularPago();
        }

        private void btnAmotizacion_Click(object sender, EventArgs e)
        {
            Point posicion_celda = dgDatosDeImprension.CurrentCellAddress;

            string Sin_Interes = dgDatosDeImprension.Rows[posicion_celda.Y].HeaderCell.Value.ToString();
            Sin_Interes = Sin_Interes.Substring(0, Sin_Interes.IndexOf("%"));
            double Interes = double.Parse(Sin_Interes);

            int P = 0;
            if (!msPrestamos_Tiempo.Enabled)
                P = 12;
            else
                P = 1;
            string meses = dgDatosDeImprension.Columns[posicion_celda.X].HeaderText;
            meses = meses.Substring(0, meses.IndexOf("."));
            if (meses.Contains(","))
                meses = meses.Replace(",", string.Empty);
            int Meses = int.Parse(meses)*P;
            int Filas = Meses;
            int Columnas = 4;
            if (Filas < 18)
                Filas = 18;

            dgDatosDeImprension.Rows.Clear();
            dgDatosDeImprension.Columns.Clear();
            ImprimirTabla(Filas, Columnas);

            for (int mes = 0; mes <= Meses-1; mes++)
                dgDatosDeImprension.Rows[mes].HeaderCell.Value = string.Format("{0,5:D}", mes+1);

            string[] titulos = new string[]{ "Capital", "Interes", "Capital Pendiente", "Total de Interes" };
            for (int tit = 0; tit < titulos.Length; tit++)
                dgDatosDeImprension.Columns[tit].HeaderText = titulos[tit];

            double Intereses_Mensuales = 0, Credito_Pendiente = Credito, Capital_Mensual_Amortizado = 0, Total_Interes = 0;
            for (int mes = 0; mes <= Meses-1; mes++)
            {
                Intereses_Mensuales = Credito_Pendiente * Interes;
                Capital_Mensual_Amortizado = Pago - Intereses_Mensuales;
                Credito_Pendiente -= Capital_Mensual_Amortizado;
                Total_Interes -= Intereses_Mensuales;

                dgDatosDeImprension.Rows[mes].Cells[0].Value = string.Format("{0,14:N2}", Intereses_Mensuales);
                dgDatosDeImprension.Rows[mes].Cells[1].Value = string.Format("{0,14:N2}", Credito_Pendiente);
                dgDatosDeImprension.Rows[mes].Cells[2].Value = string.Format("{0,14:N2}", Capital_Mensual_Amortizado);
                dgDatosDeImprension.Rows[mes].Cells[3].Value = string.Format("{0,14:N2}", Total_Interes);
            }
            btnAmotizacion.Enabled = false;
            btnPagos.Enabled = true;
        }
    }
}
