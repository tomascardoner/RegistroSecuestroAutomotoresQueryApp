using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroSecuestroAutomotorQueryApp
{
    public partial class formMain : Form
    {
        const string RESULTADO_INACTIVO = "SIN SECUESTRO";
        readonly Color RESULTADO_INACTIVO_COLOR = Color.Green;
        const string RESULTADO_ACTIVO = "SECUESTRO";
        readonly Color RESULTADO_ACTIVO_COLOR = Color.Red;
        const string RESULTADO_URGENTE = "SECUESTRO URGENTE";
        readonly Color RESULTADO_URGENTE_COLOR = Color.Violet;

        public formMain()
        {
            InitializeComponent();
        }

        private void DominioFoco(object sender, EventArgs e)
        {
            textboxDominio.SelectAll();
        }

        private void DominioCambio(object sender, EventArgs e)
        {
            labelEstado.Text = "";
            labelEstado.ForeColor = SystemColors.WindowText;
        }

        private void Consultar(object sender, EventArgs e)
        {
            if (textboxDominio.Text.Trim().Length < 6)
            {
                MessageBox.Show("El dominio debe contener al menos 6 caracteres.", "Dominio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textboxDominio.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            RSAMovil.RSAState rsaState = RSAMovil.RSAMovil.GetStatusRegOffline(textboxDominio.Text.Trim(), "Camara1", out string resultadoOperacion);

            switch (rsaState )
            {
                case RSAMovil.RSAState.INACTIVO:
                    MostrarEstado(RESULTADO_INACTIVO, RESULTADO_INACTIVO_COLOR);
                    break;
                case RSAMovil.RSAState.ACTIVO:
                    MostrarEstado(RESULTADO_ACTIVO, RESULTADO_ACTIVO_COLOR);
                    break;
                case RSAMovil.RSAState.URGENTE:
                    MostrarEstado(RESULTADO_URGENTE, RESULTADO_URGENTE_COLOR);
                    break;
                default:
                    break;
            }

            this.Cursor = Cursors.Default;
        }

        private void MostrarEstado(string texto, Color color)
        {
            labelEstado.Text = texto;
            labelEstado.ForeColor = color;
        }
    }
}
