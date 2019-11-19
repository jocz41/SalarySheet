/*
* PRÁCTICA.............: Práctica 6
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario. Controles básicos.
* FECHA de ENTREGA.....: 21 de Diciembre de 2017
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class HojaSalarial : Form
    {
        private Empleado e;
        private Nomina n;

        public HojaSalarial()
        {
            InitializeComponent();
            this.dateLiquidacion.Value = DateTime.Now;
            this.dateLiquidacion.MaxDate = DateTime.Now;

            for (int i = 1; i < 4; i++)
            {
                this.comboCat.Items.Add("" + i);
            }
        }

        #region Eventos

        private void btnCalcular_Click(object sender, EventArgs ev)
        {
            if (txtNombre.Text.Length != 0 && txtDNI.Text.Length != 0 && comboCat.SelectedItem != null && 
                txtHijos.Text.Length != 0 && txtTrienios.Text.Length != 0 && txtExtras.Text.Length != 0)
            {
                e = new Empleado(Convert.ToSByte(this.comboCat.SelectedItem.ToString()), Convert.ToSByte(this.txtHijos.Text),
                    Convert.ToSByte(this.txtTrienios.Text), this.txtDNI.Text, this.txtNombre.Text);
                n = new Nomina(e, DateTime.Parse(this.dateLiquidacion.Text), Convert.ToSByte(this.txtExtras.Text));

                this.pnlNomina.Visible = true;
                this.pnlDatos.Enabled = false;
                this.hojaSalarial();
                this.btnModificar.Focus();
                this.btnModificar.Select();
            }
            else
            {
                MessageBox.Show("No debe haber ningún campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs ev)
        {
            Environment.Exit(0);
        }

        private void btnModificar_Click(object sender, EventArgs ev)
        {
            pnlDatos.Enabled = true;
            pnlNomina.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtNombre_PierdeFoco(object sender, EventArgs ev)
        {
            string mensaje = Auxiliar.leerNombre(txtNombre.Text);

            if (mensaje != null)
            {
                txtNombre.ForeColor = Color.Red;

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtNombre.Select();
            }
            else
            {
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtDNI_PierdeFoco(object sender, EventArgs ev)
        {
            string mensaje = Auxiliar.leerDNI(txtDNI.Text);

            if (mensaje != null)
            {
                txtDNI.ForeColor = Color.Red;

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDNI.Select();
            }
            else
            {
                txtDNI.ForeColor = Color.Black;
            }
        }
        
        private void txtNum_PierdeFoco(object sender, EventArgs ev)
        {
            TextBox t = sender as TextBox;
            string mensaje = null;
            
            switch (t.Name)
            {
                case "comboCat":
                    mensaje = Auxiliar.leerNum(t.Text, "CATEGORÍA", 1, 3);
                    break;

                case "txtHijos":
                    mensaje = Auxiliar.leerNum(t.Text, "Nº HIJOS", 0, 20);
                    break;

                case "txtTrienios":
                    mensaje = Auxiliar.leerNum(t.Text, "TRIENIOS", 0, 12);
                    break;

                case "txtExtras":
                    mensaje = Auxiliar.leerNum(t.Text, "HORAS EXTRAS", 0, 15);
                    break;
            }
            
            if (mensaje != null)
            {
                if (t.Name != "comboCat" && t.Text.Length == 0)
                {
                    t.Text = "0";
                    mensaje = null;
                }
                else
                {
                    t.ForeColor = Color.Red;

                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    t.Text = "";
                    t.Select();
                }
            }
            else
            {
                t.ForeColor = Color.Black;
            }
        }

        private void textLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = char.ToUpper(e.KeyChar);

            if (c != (char)(Keys.Back) && (c != '-') && (c < 'A' || c > 'Z'))
            {
                e.Handled = true;
            }
        }

        private void text1al3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != (char)(Keys.Back) && (c < '1' || c > '3'))
            {
                e.Handled = true;
            }
        }

        private void textNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != (char)(Keys.Back) && (c < '0' || c > '9'))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void hojaSalarial()
        {
            double paga = 0;

            // Devengos

            this.txtSalBase.Text = string.Format("{0:0.00}", n.salarioBase());
            this.txtAntiguedad.Text = string.Format("{0:0.00}", n.importeAntiguedad());
            this.txtExtrasDev.Text = string.Format("{0:0.00}", n.importeHorasExtras());

            if (n.FechaNomina.Month == 6 || n.FechaNomina.Month == 12)
                paga = n.devengosPagaExtra();

            this.txtPagaExtra.Text = string.Format("{0:0.00}", paga);
            this.txtTotalDev.Text = string.Format("{0:0.00}", n.totalDevengado());

            // Descuentos

            this.txtSS.Text = string.Format("{0:0.00}", n.cotizacionSegSoc());
            this.txtDesempleo.Text = string.Format("{0:0.00}", n.cotizacionSegDesc());
            this.txtIRPF.Text = string.Format("{0:0.00}", n.retencionIRPF());
            this.txtTotalDesc.Text = string.Format("{0:0.00}", n.totalDescuentos());

            this.txtLiquidacion.Text = string.Format("{0:0.00}", n.liquidoAPercibir());
        }
    }
}
