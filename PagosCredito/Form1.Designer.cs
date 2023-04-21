namespace PagosCredito
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms = new System.Windows.Forms.MenuStrip();
            this.pocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpciones_Instrucciones = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.msOpciones_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrestamos_Tiempo = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrestamos_Meses = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAyuda_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPrestamo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinimo_Prestamo = new System.Windows.Forms.TextBox();
            this.txtMaximo_Pestamo = new System.Windows.Forms.TextBox();
            this.udCredito = new System.Windows.Forms.DomainUpDown();
            this.dgDatosDeImprension = new System.Windows.Forms.DataGridView();
            this.gbInteres = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIncremento = new System.Windows.Forms.ComboBox();
            this.txtMinimo_Interes = new System.Windows.Forms.TextBox();
            this.txtMaximo_Interes = new System.Windows.Forms.TextBox();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnAmotizacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ms.SuspendLayout();
            this.gbPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosDeImprension)).BeginInit();
            this.gbInteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pocionesToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(930, 26);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            // 
            // pocionesToolStripMenuItem
            // 
            this.pocionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOpciones_Instrucciones,
            this.nuevoToolStripMenuItem,
            this.aToolStripMenuItem,
            this.msOpciones_Salir});
            this.pocionesToolStripMenuItem.Name = "pocionesToolStripMenuItem";
            this.pocionesToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.pocionesToolStripMenuItem.Text = "Pociones";
            // 
            // msOpciones_Instrucciones
            // 
            this.msOpciones_Instrucciones.Name = "msOpciones_Instrucciones";
            this.msOpciones_Instrucciones.Size = new System.Drawing.Size(180, 22);
            this.msOpciones_Instrucciones.Text = "Instrucciones";
            this.msOpciones_Instrucciones.Click += new System.EventHandler(this.msOpciones_Instrucciones_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // msOpciones_Salir
            // 
            this.msOpciones_Salir.Name = "msOpciones_Salir";
            this.msOpciones_Salir.Size = new System.Drawing.Size(180, 22);
            this.msOpciones_Salir.Text = "Salir";
            this.msOpciones_Salir.Click += new System.EventHandler(this.msOpciones_Salir_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPrestamos_Tiempo,
            this.msPrestamos_Meses});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // msPrestamos_Tiempo
            // 
            this.msPrestamos_Tiempo.Enabled = false;
            this.msPrestamos_Tiempo.Name = "msPrestamos_Tiempo";
            this.msPrestamos_Tiempo.Size = new System.Drawing.Size(180, 22);
            this.msPrestamos_Tiempo.Text = "Años";
            this.msPrestamos_Tiempo.Click += new System.EventHandler(this.msPrestamos_Tiempo_Click);
            // 
            // msPrestamos_Meses
            // 
            this.msPrestamos_Meses.Checked = true;
            this.msPrestamos_Meses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.msPrestamos_Meses.Name = "msPrestamos_Meses";
            this.msPrestamos_Meses.Size = new System.Drawing.Size(180, 22);
            this.msPrestamos_Meses.Text = "Meses";
            this.msPrestamos_Meses.Click += new System.EventHandler(this.msPrestamos_Meses_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAyuda_AcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // msAyuda_AcercaDe
            // 
            this.msAyuda_AcercaDe.Name = "msAyuda_AcercaDe";
            this.msAyuda_AcercaDe.Size = new System.Drawing.Size(180, 22);
            this.msAyuda_AcercaDe.Text = "Acerca de.";
            this.msAyuda_AcercaDe.Click += new System.EventHandler(this.msAyuda_AcercaDe_Click);
            // 
            // gbPrestamo
            // 
            this.gbPrestamo.Controls.Add(this.label3);
            this.gbPrestamo.Controls.Add(this.label2);
            this.gbPrestamo.Controls.Add(this.txtMinimo_Prestamo);
            this.gbPrestamo.Controls.Add(this.txtMaximo_Pestamo);
            this.gbPrestamo.Font = new System.Drawing.Font("Monotype Corsiva", 9.5F, System.Drawing.FontStyle.Italic);
            this.gbPrestamo.Location = new System.Drawing.Point(16, 75);
            this.gbPrestamo.Name = "gbPrestamo";
            this.gbPrestamo.Size = new System.Drawing.Size(214, 81);
            this.gbPrestamo.TabIndex = 1;
            this.gbPrestamo.TabStop = false;
            this.gbPrestamo.Text = "Meses de Prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mínimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Máximo:";
            // 
            // txtMinimo_Prestamo
            // 
            this.txtMinimo_Prestamo.Location = new System.Drawing.Point(88, 52);
            this.txtMinimo_Prestamo.Name = "txtMinimo_Prestamo";
            this.txtMinimo_Prestamo.Size = new System.Drawing.Size(120, 22);
            this.txtMinimo_Prestamo.TabIndex = 1;
            this.txtMinimo_Prestamo.Text = "4";
            // 
            // txtMaximo_Pestamo
            // 
            this.txtMaximo_Pestamo.Location = new System.Drawing.Point(92, 25);
            this.txtMaximo_Pestamo.Name = "txtMaximo_Pestamo";
            this.txtMaximo_Pestamo.Size = new System.Drawing.Size(116, 22);
            this.txtMaximo_Pestamo.TabIndex = 0;
            this.txtMaximo_Pestamo.Text = "8";
            // 
            // udCredito
            // 
            this.udCredito.Font = new System.Drawing.Font("Monotype Corsiva", 9.5F, System.Drawing.FontStyle.Italic);
            this.udCredito.Location = new System.Drawing.Point(87, 42);
            this.udCredito.Name = "udCredito";
            this.udCredito.Size = new System.Drawing.Size(137, 22);
            this.udCredito.TabIndex = 2;
            // 
            // dgDatosDeImprension
            // 
            this.dgDatosDeImprension.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDatosDeImprension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosDeImprension.Location = new System.Drawing.Point(236, 37);
            this.dgDatosDeImprension.Name = "dgDatosDeImprension";
            this.dgDatosDeImprension.Size = new System.Drawing.Size(682, 282);
            this.dgDatosDeImprension.TabIndex = 3;
            // 
            // gbInteres
            // 
            this.gbInteres.Controls.Add(this.label6);
            this.gbInteres.Controls.Add(this.label5);
            this.gbInteres.Controls.Add(this.label4);
            this.gbInteres.Controls.Add(this.cbIncremento);
            this.gbInteres.Controls.Add(this.txtMinimo_Interes);
            this.gbInteres.Controls.Add(this.txtMaximo_Interes);
            this.gbInteres.Font = new System.Drawing.Font("Monotype Corsiva", 9.5F, System.Drawing.FontStyle.Italic);
            this.gbInteres.Location = new System.Drawing.Point(16, 162);
            this.gbInteres.Name = "gbInteres";
            this.gbInteres.Size = new System.Drawing.Size(214, 107);
            this.gbInteres.TabIndex = 2;
            this.gbInteres.TabStop = false;
            this.gbInteres.Text = "Tipos de Interés";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Incremento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "% Mínimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "% Máximo:";
            // 
            // cbIncremento
            // 
            this.cbIncremento.FormattingEnabled = true;
            this.cbIncremento.Items.AddRange(new object[] {
            "1.00",
            "0.75",
            "0.50",
            "0.25"});
            this.cbIncremento.Location = new System.Drawing.Point(112, 71);
            this.cbIncremento.Name = "cbIncremento";
            this.cbIncremento.Size = new System.Drawing.Size(96, 23);
            this.cbIncremento.TabIndex = 4;
            this.cbIncremento.Text = "1.00";
            // 
            // txtMinimo_Interes
            // 
            this.txtMinimo_Interes.Location = new System.Drawing.Point(107, 45);
            this.txtMinimo_Interes.Name = "txtMinimo_Interes";
            this.txtMinimo_Interes.Size = new System.Drawing.Size(101, 22);
            this.txtMinimo_Interes.TabIndex = 1;
            this.txtMinimo_Interes.Text = "4";
            // 
            // txtMaximo_Interes
            // 
            this.txtMaximo_Interes.Location = new System.Drawing.Point(111, 19);
            this.txtMaximo_Interes.Name = "txtMaximo_Interes";
            this.txtMaximo_Interes.Size = new System.Drawing.Size(97, 22);
            this.txtMaximo_Interes.TabIndex = 0;
            this.txtMaximo_Interes.Text = "8";
            // 
            // btnPagos
            // 
            this.btnPagos.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnPagos.Location = new System.Drawing.Point(16, 275);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(86, 32);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnAmotizacion
            // 
            this.btnAmotizacion.Enabled = false;
            this.btnAmotizacion.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnAmotizacion.Location = new System.Drawing.Point(108, 275);
            this.btnAmotizacion.Name = "btnAmotizacion";
            this.btnAmotizacion.Size = new System.Drawing.Size(122, 32);
            this.btnAmotizacion.TabIndex = 5;
            this.btnAmotizacion.Text = "Amortización";
            this.btnAmotizacion.UseVisualStyleBackColor = true;
            this.btnAmotizacion.Click += new System.EventHandler(this.btnAmotizacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Crédito:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAmotizacion);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.gbInteres);
            this.Controls.Add(this.dgDatosDeImprension);
            this.Controls.Add(this.udCredito);
            this.Controls.Add(this.gbPrestamo);
            this.Controls.Add(this.ms);
            this.MainMenuStrip = this.ms;
            this.Name = "Form1";
            this.Text = "..:: Calculo de Pagos ::..";
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.gbPrestamo.ResumeLayout(false);
            this.gbPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosDeImprension)).EndInit();
            this.gbInteres.ResumeLayout(false);
            this.gbInteres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.GroupBox gbPrestamo;
        private System.Windows.Forms.TextBox txtMinimo_Prestamo;
        private System.Windows.Forms.TextBox txtMaximo_Pestamo;
        private System.Windows.Forms.DomainUpDown udCredito;
        private System.Windows.Forms.DataGridView dgDatosDeImprension;
        private System.Windows.Forms.GroupBox gbInteres;
        private System.Windows.Forms.TextBox txtMinimo_Interes;
        private System.Windows.Forms.TextBox txtMaximo_Interes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnAmotizacion;
        private System.Windows.Forms.ToolStripMenuItem pocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msOpciones_Instrucciones;
        private System.Windows.Forms.ToolStripSeparator aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msOpciones_Salir;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msPrestamos_Tiempo;
        private System.Windows.Forms.ToolStripMenuItem msPrestamos_Meses;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msAyuda_AcercaDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIncremento;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
    }
}

