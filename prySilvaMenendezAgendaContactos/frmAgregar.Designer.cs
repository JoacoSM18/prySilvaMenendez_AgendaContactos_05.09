namespace prySilvaMenendezAgendaContactos
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lstCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje1.Location = new System.Drawing.Point(101, 9);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(504, 34);
            this.lblMensaje1.TabIndex = 0;
            this.lblMensaje1.Text = "Usted Ha Seleccionado la Opcion de";
            this.lblMensaje1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(288, 37);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Ingrese el Nombre del Nuevo Contacto";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(45, 176);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(292, 37);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Ingrese el Numero del Nuevo Contacto";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(427, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblOpcion
            // 
            this.lblOpcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOpcion.Location = new System.Drawing.Point(243, 56);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(264, 34);
            this.lblOpcion.TabIndex = 5;
            this.lblOpcion.Text = "Agregar Un Contacto";
            this.lblOpcion.Click += new System.EventHandler(this.lblOpcion_Click);
            // 
            // lstCategoria
            // 
            this.lstCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCategoria.FormattingEnabled = true;
            this.lstCategoria.Items.AddRange(new object[] {
            "FAMILIA",
            "TRABAJO",
            "AMIGOS"});
            this.lstCategoria.Location = new System.Drawing.Point(427, 240);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(178, 28);
            this.lstCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(45, 243);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(348, 32);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Seleccione la Categoria para el Nuevo Contacto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(496, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 47);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(427, 187);
            this.mskNumero.Mask = "000-000-0000";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(100, 26);
            this.mskNumero.TabIndex = 9;
            this.mskNumero.Click += new System.EventHandler(this.mskNumero_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Red;
            this.btnVolver.Location = new System.Drawing.Point(49, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 47);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(668, 355);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mskNumero);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lstCategoria);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMensaje1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Un Contacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox lstCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.Button btnVolver;
    }
}