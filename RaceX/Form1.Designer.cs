namespace RaceX
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClima = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnTurno = new System.Windows.Forms.Button();
            this.lstAutos = new System.Windows.Forms.ListBox();
            this.lblGanador = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblClima = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.panelCarril = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Auto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Auto";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(115, 77);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clima de la carrera";
            // 
            // cbClima
            // 
            this.cbClima.FormattingEnabled = true;
            this.cbClima.Location = new System.Drawing.Point(115, 126);
            this.cbClima.Name = "cbClima";
            this.cbClima.Size = new System.Drawing.Size(121, 21);
            this.cbClima.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 38);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Auto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(215, 183);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(162, 40);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar Carrera";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnTurno
            // 
            this.btnTurno.Location = new System.Drawing.Point(124, 248);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(155, 36);
            this.btnTurno.TabIndex = 8;
            this.btnTurno.Text = "Siguiente Turno";
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // lstAutos
            // 
            this.lstAutos.FormattingEnabled = true;
            this.lstAutos.Location = new System.Drawing.Point(415, 12);
            this.lstAutos.Name = "lstAutos";
            this.lstAutos.Size = new System.Drawing.Size(354, 121);
            this.lstAutos.TabIndex = 9;
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGanador.Location = new System.Drawing.Point(411, 329);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(0, 20);
            this.lblGanador.TabIndex = 10;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMensaje.Location = new System.Drawing.Point(416, 363);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(58, 15);
            this.lblMensaje.TabIndex = 11;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // lblClima
            // 
            this.lblClima.AutoSize = true;
            this.lblClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblClima.Location = new System.Drawing.Point(416, 397);
            this.lblClima.Name = "lblClima";
            this.lblClima.Size = new System.Drawing.Size(42, 15);
            this.lblClima.TabIndex = 12;
            this.lblClima.Text = "Clima:";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(124, 317);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(155, 36);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar Carrera";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // panelCarril
            // 
            this.panelCarril.Location = new System.Drawing.Point(419, 139);
            this.panelCarril.Name = "panelCarril";
            this.panelCarril.Size = new System.Drawing.Size(350, 176);
            this.panelCarril.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCarril);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblClima);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lstAutos);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbClima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClima;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.ListBox lstAutos;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblClima;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Panel panelCarril;
    }
}

