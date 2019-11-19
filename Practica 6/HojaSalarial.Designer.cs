/*
* PRÁCTICA.............: Práctica 6
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario. Controles básicos.
* FECHA de ENTREGA.....: 21 de Diciembre de 2017
*/

using System.Windows.Forms;

namespace Practica_6
{
    partial class HojaSalarial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Constantes
        private const string TITULO = "Calcule su Hoja Salarial";
        #endregion

        #region Componentes
        #endregion

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HojaSalarial));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtExtras = new System.Windows.Forms.TextBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.txtTrienios = new System.Windows.Forms.TextBox();
            this.lblTrienios = new System.Windows.Forms.Label();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.lblHijos = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.dateLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblLiquidacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.pnlNomina = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtLiquidacion = new System.Windows.Forms.TextBox();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.txtTotalDesc = new System.Windows.Forms.TextBox();
            this.lblTotalDesc = new System.Windows.Forms.Label();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.txtDesempleo = new System.Windows.Forms.TextBox();
            this.lblDesempleo = new System.Windows.Forms.Label();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.lblSS = new System.Windows.Forms.Label();
            this.txtTotalDev = new System.Windows.Forms.TextBox();
            this.lblTotalDev = new System.Windows.Forms.Label();
            this.txtPagaExtra = new System.Windows.Forms.TextBox();
            this.lblPagaExtra = new System.Windows.Forms.Label();
            this.txtExtrasDev = new System.Windows.Forms.TextBox();
            this.lblExtrasDev = new System.Windows.Forms.Label();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.txtSalBase = new System.Windows.Forms.TextBox();
            this.lblSalBase = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblDevengos = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.pnlDatos.SuspendLayout();
            this.pnlNomina.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(261, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(327, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule su Hoja Salarial";
            // 
            // pnlDatos
            // 
            this.pnlDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.comboCat);
            this.pnlDatos.Controls.Add(this.txtExtras);
            this.pnlDatos.Controls.Add(this.lblExtras);
            this.pnlDatos.Controls.Add(this.txtTrienios);
            this.pnlDatos.Controls.Add(this.lblTrienios);
            this.pnlDatos.Controls.Add(this.txtHijos);
            this.pnlDatos.Controls.Add(this.lblHijos);
            this.pnlDatos.Controls.Add(this.lblCat);
            this.pnlDatos.Controls.Add(this.dateLiquidacion);
            this.pnlDatos.Controls.Add(this.btnCalcular);
            this.pnlDatos.Controls.Add(this.lblLiquidacion);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.txtDNI);
            this.pnlDatos.Controls.Add(this.lblDNI);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(3, 3);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(864, 249);
            this.pnlDatos.TabIndex = 1;
            // 
            // txtExtras
            // 
            this.txtExtras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtras.Location = new System.Drawing.Point(810, 117);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(32, 22);
            this.txtExtras.TabIndex = 7;
            this.txtExtras.Text = "0";
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblExtras.Location = new System.Drawing.Point(632, 117);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(146, 20);
            this.lblExtras.TabIndex = 22;
            this.lblExtras.Text = "Nº Horas Extras";
            // 
            // txtTrienios
            // 
            this.txtTrienios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrienios.Location = new System.Drawing.Point(554, 117);
            this.txtTrienios.Name = "txtTrienios";
            this.txtTrienios.Size = new System.Drawing.Size(30, 22);
            this.txtTrienios.TabIndex = 6;
            this.txtTrienios.Text = "0";
            // 
            // lblTrienios
            // 
            this.lblTrienios.AutoSize = true;
            this.lblTrienios.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrienios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTrienios.Location = new System.Drawing.Point(394, 117);
            this.lblTrienios.Name = "lblTrienios";
            this.lblTrienios.Size = new System.Drawing.Size(102, 20);
            this.lblTrienios.TabIndex = 20;
            this.lblTrienios.Text = "Nº Trienios";
            // 
            // txtHijos
            // 
            this.txtHijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHijos.Location = new System.Drawing.Point(323, 117);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(32, 22);
            this.txtHijos.TabIndex = 5;
            this.txtHijos.Text = "0";
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHijos.Location = new System.Drawing.Point(215, 117);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(80, 20);
            this.lblHijos.TabIndex = 18;
            this.lblHijos.Text = "Nº Hijos";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCat.Location = new System.Drawing.Point(15, 117);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(91, 20);
            this.lblCat.TabIndex = 16;
            this.lblCat.Text = "Categoría";
            // 
            // dateLiquidacion
            // 
            this.dateLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLiquidacion.Location = new System.Drawing.Point(725, 64);
            this.dateLiquidacion.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateLiquidacion.Name = "dateLiquidacion";
            this.dateLiquidacion.Size = new System.Drawing.Size(117, 22);
            this.dateLiquidacion.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalcular.Location = new System.Drawing.Point(323, 162);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(177, 64);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular Hoja Salarial";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.Enter += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblLiquidacion
            // 
            this.lblLiquidacion.AutoSize = true;
            this.lblLiquidacion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquidacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLiquidacion.Location = new System.Drawing.Point(394, 65);
            this.lblLiquidacion.Name = "lblLiquidacion";
            this.lblLiquidacion.Size = new System.Drawing.Size(302, 20);
            this.lblLiquidacion.TabIndex = 12;
            this.lblLiquidacion.Text = "Período de liquidación (mm/aaaa)";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(130, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(712, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLetras_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_PierdeFoco);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombre.Location = new System.Drawing.Point(15, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(130, 64);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(225, 23);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.Leave += new System.EventHandler(this.txtDNI_PierdeFoco);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDNI.Location = new System.Drawing.Point(15, 64);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 20);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // pnlNomina
            // 
            this.pnlNomina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNomina.Controls.Add(this.btnSalir);
            this.pnlNomina.Controls.Add(this.btnModificar);
            this.pnlNomina.Controls.Add(this.txtLiquidacion);
            this.pnlNomina.Controls.Add(this.lblLiquido);
            this.pnlNomina.Controls.Add(this.txtTotalDesc);
            this.pnlNomina.Controls.Add(this.lblTotalDesc);
            this.pnlNomina.Controls.Add(this.txtIRPF);
            this.pnlNomina.Controls.Add(this.lblIRPF);
            this.pnlNomina.Controls.Add(this.txtDesempleo);
            this.pnlNomina.Controls.Add(this.lblDesempleo);
            this.pnlNomina.Controls.Add(this.txtSS);
            this.pnlNomina.Controls.Add(this.lblSS);
            this.pnlNomina.Controls.Add(this.txtTotalDev);
            this.pnlNomina.Controls.Add(this.lblTotalDev);
            this.pnlNomina.Controls.Add(this.txtPagaExtra);
            this.pnlNomina.Controls.Add(this.lblPagaExtra);
            this.pnlNomina.Controls.Add(this.txtExtrasDev);
            this.pnlNomina.Controls.Add(this.lblExtrasDev);
            this.pnlNomina.Controls.Add(this.txtAntiguedad);
            this.pnlNomina.Controls.Add(this.lblAntiguedad);
            this.pnlNomina.Controls.Add(this.txtSalBase);
            this.pnlNomina.Controls.Add(this.lblSalBase);
            this.pnlNomina.Controls.Add(this.lblDescuentos);
            this.pnlNomina.Controls.Add(this.lblDevengos);
            this.pnlNomina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNomina.Location = new System.Drawing.Point(3, 258);
            this.pnlNomina.Name = "pnlNomina";
            this.pnlNomina.Size = new System.Drawing.Size(864, 480);
            this.pnlNomina.TabIndex = 2;
            this.pnlNomina.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalir.Location = new System.Drawing.Point(470, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(233, 75);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificar.Location = new System.Drawing.Point(132, 386);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(242, 75);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar Datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtLiquidacion
            // 
            this.txtLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLiquidacion.Enabled = false;
            this.txtLiquidacion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquidacion.Location = new System.Drawing.Point(352, 324);
            this.txtLiquidacion.Name = "txtLiquidacion";
            this.txtLiquidacion.Size = new System.Drawing.Size(172, 23);
            this.txtLiquidacion.TabIndex = 23;
            this.txtLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblLiquido.Location = new System.Drawing.Point(229, 324);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(94, 20);
            this.lblLiquido.TabIndex = 22;
            this.lblLiquido.Text = "LÍQUIDO";
            // 
            // txtTotalDesc
            // 
            this.txtTotalDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDesc.Enabled = false;
            this.txtTotalDesc.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesc.Location = new System.Drawing.Point(674, 250);
            this.txtTotalDesc.Name = "txtTotalDesc";
            this.txtTotalDesc.Size = new System.Drawing.Size(100, 23);
            this.txtTotalDesc.TabIndex = 21;
            this.txtTotalDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDesc
            // 
            this.lblTotalDesc.AutoSize = true;
            this.lblTotalDesc.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDesc.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDesc.Location = new System.Drawing.Point(425, 250);
            this.lblTotalDesc.Name = "lblTotalDesc";
            this.lblTotalDesc.Size = new System.Drawing.Size(154, 20);
            this.lblTotalDesc.TabIndex = 20;
            this.lblTotalDesc.Text = "Total Descuentos";
            // 
            // txtIRPF
            // 
            this.txtIRPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIRPF.Enabled = false;
            this.txtIRPF.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIRPF.Location = new System.Drawing.Point(674, 141);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(100, 23);
            this.txtIRPF.TabIndex = 17;
            this.txtIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRPF.ForeColor = System.Drawing.Color.Red;
            this.lblIRPF.Location = new System.Drawing.Point(425, 141);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(140, 20);
            this.lblIRPF.TabIndex = 16;
            this.lblIRPF.Text = "Retención IRPF";
            // 
            // txtDesempleo
            // 
            this.txtDesempleo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesempleo.Enabled = false;
            this.txtDesempleo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesempleo.Location = new System.Drawing.Point(674, 98);
            this.txtDesempleo.Name = "txtDesempleo";
            this.txtDesempleo.Size = new System.Drawing.Size(100, 23);
            this.txtDesempleo.TabIndex = 15;
            this.txtDesempleo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDesempleo
            // 
            this.lblDesempleo.AutoSize = true;
            this.lblDesempleo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesempleo.ForeColor = System.Drawing.Color.Red;
            this.lblDesempleo.Location = new System.Drawing.Point(425, 98);
            this.lblDesempleo.Name = "lblDesempleo";
            this.lblDesempleo.Size = new System.Drawing.Size(226, 20);
            this.lblDesempleo.TabIndex = 14;
            this.lblDesempleo.Text = "Cotiz. Seguro Desempleo";
            // 
            // txtSS
            // 
            this.txtSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSS.Enabled = false;
            this.txtSS.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Location = new System.Drawing.Point(674, 58);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 23);
            this.txtSS.TabIndex = 13;
            this.txtSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSS.ForeColor = System.Drawing.Color.Red;
            this.lblSS.Location = new System.Drawing.Point(425, 58);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(209, 20);
            this.lblSS.TabIndex = 12;
            this.lblSS.Text = "Cotiz. Seguridad Social";
            // 
            // txtTotalDev
            // 
            this.txtTotalDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDev.Enabled = false;
            this.txtTotalDev.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDev.Location = new System.Drawing.Point(191, 250);
            this.txtTotalDev.Name = "txtTotalDev";
            this.txtTotalDev.Size = new System.Drawing.Size(100, 23);
            this.txtTotalDev.TabIndex = 11;
            this.txtTotalDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDev
            // 
            this.lblTotalDev.AutoSize = true;
            this.lblTotalDev.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDev.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalDev.Location = new System.Drawing.Point(19, 250);
            this.lblTotalDev.Name = "lblTotalDev";
            this.lblTotalDev.Size = new System.Drawing.Size(139, 20);
            this.lblTotalDev.TabIndex = 10;
            this.lblTotalDev.Text = "Total Devengos";
            // 
            // txtPagaExtra
            // 
            this.txtPagaExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagaExtra.Enabled = false;
            this.txtPagaExtra.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaExtra.Location = new System.Drawing.Point(191, 185);
            this.txtPagaExtra.Name = "txtPagaExtra";
            this.txtPagaExtra.Size = new System.Drawing.Size(100, 23);
            this.txtPagaExtra.TabIndex = 9;
            this.txtPagaExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPagaExtra
            // 
            this.lblPagaExtra.AutoSize = true;
            this.lblPagaExtra.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaExtra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPagaExtra.Location = new System.Drawing.Point(19, 185);
            this.lblPagaExtra.Name = "lblPagaExtra";
            this.lblPagaExtra.Size = new System.Drawing.Size(101, 20);
            this.lblPagaExtra.TabIndex = 8;
            this.lblPagaExtra.Text = "Paga Extra";
            // 
            // txtExtrasDev
            // 
            this.txtExtrasDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtrasDev.Enabled = false;
            this.txtExtrasDev.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtrasDev.Location = new System.Drawing.Point(191, 141);
            this.txtExtrasDev.Name = "txtExtrasDev";
            this.txtExtrasDev.Size = new System.Drawing.Size(100, 23);
            this.txtExtrasDev.TabIndex = 7;
            this.txtExtrasDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblExtrasDev
            // 
            this.lblExtrasDev.AutoSize = true;
            this.lblExtrasDev.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrasDev.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblExtrasDev.Location = new System.Drawing.Point(19, 141);
            this.lblExtrasDev.Name = "lblExtrasDev";
            this.lblExtrasDev.Size = new System.Drawing.Size(118, 20);
            this.lblExtrasDev.TabIndex = 6;
            this.lblExtrasDev.Text = "Horas Extras";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAntiguedad.Enabled = false;
            this.txtAntiguedad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntiguedad.Location = new System.Drawing.Point(191, 98);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 23);
            this.txtAntiguedad.TabIndex = 5;
            this.txtAntiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAntiguedad.Location = new System.Drawing.Point(19, 98);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(108, 20);
            this.lblAntiguedad.TabIndex = 4;
            this.lblAntiguedad.Text = "Antigüedad";
            // 
            // txtSalBase
            // 
            this.txtSalBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalBase.Enabled = false;
            this.txtSalBase.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalBase.Location = new System.Drawing.Point(191, 58);
            this.txtSalBase.Name = "txtSalBase";
            this.txtSalBase.Size = new System.Drawing.Size(100, 23);
            this.txtSalBase.TabIndex = 3;
            this.txtSalBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSalBase
            // 
            this.lblSalBase.AutoSize = true;
            this.lblSalBase.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBase.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSalBase.Location = new System.Drawing.Point(19, 58);
            this.lblSalBase.Name = "lblSalBase";
            this.lblSalBase.Size = new System.Drawing.Size(115, 20);
            this.lblSalBase.TabIndex = 2;
            this.lblSalBase.Text = "Salario Base";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblDescuentos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescuentos.Location = new System.Drawing.Point(420, 17);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(128, 20);
            this.lblDescuentos.TabIndex = 1;
            this.lblDescuentos.Text = "DESCUENTOS";
            // 
            // lblDevengos
            // 
            this.lblDevengos.AutoSize = true;
            this.lblDevengos.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblDevengos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDevengos.Location = new System.Drawing.Point(19, 17);
            this.lblDevengos.Name = "lblDevengos";
            this.lblDevengos.Size = new System.Drawing.Size(107, 20);
            this.lblDevengos.TabIndex = 0;
            this.lblDevengos.Text = "DEVENGOS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlDatos);
            this.flowLayoutPanel1.Controls.Add(this.pnlNomina);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(871, 743);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // comboCat
            // 
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(130, 113);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(63, 24);
            this.comboCat.TabIndex = 4;
            // 
            // HojaSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 744);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HojaSalarial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoja Salarial";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlNomina.ResumeLayout(false);
            this.pnlNomina.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Panel pnlDatos;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDNI;
        private Label lblDNI;
        private Button btnCalcular;
        private Label lblLiquidacion;
        private Panel pnlNomina;
        private Label lblDevengos;
        private TextBox txtAntiguedad;
        private Label lblAntiguedad;
        private TextBox txtSalBase;
        private Label lblSalBase;
        private Label lblDescuentos;
        private TextBox txtLiquidacion;
        private Label lblLiquido;
        private TextBox txtTotalDesc;
        private Label lblTotalDesc;
        private TextBox txtIRPF;
        private Label lblIRPF;
        private TextBox txtDesempleo;
        private Label lblDesempleo;
        private TextBox txtSS;
        private Label lblSS;
        private TextBox txtTotalDev;
        private Label lblTotalDev;
        private TextBox txtPagaExtra;
        private Label lblPagaExtra;
        private TextBox txtExtrasDev;
        private Label lblExtrasDev;
        private Button btnSalir;
        private Button btnModificar;
        private DateTimePicker dateLiquidacion;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtExtras;
        private Label lblExtras;
        private TextBox txtTrienios;
        private Label lblTrienios;
        private TextBox txtHijos;
        private Label lblHijos;
        private Label lblCat;
        private ComboBox comboCat;
    }
}

