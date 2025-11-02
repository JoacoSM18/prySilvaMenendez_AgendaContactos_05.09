namespace prySilvaMenendezAgendaContactos
{
    partial class frmEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            this.lblOpcion2 = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lstContactosEditar = new System.Windows.Forms.ComboBox();
            this.lblContactoEditar = new System.Windows.Forms.Label();
            this.lblNumeroEditar = new System.Windows.Forms.Label();
            this.lblNombreEditar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.mskNuevoNumero = new System.Windows.Forms.MaskedTextBox();
            this.lstNuevaCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblOpcion2
            // 
            this.lblOpcion2.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOpcion2.Location = new System.Drawing.Point(246, 59);
            this.lblOpcion2.Name = "lblOpcion2";
            this.lblOpcion2.Size = new System.Drawing.Size(239, 34);
            this.lblOpcion2.TabIndex = 7;
            this.lblOpcion2.Text = "Editar un Contacto";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.Location = new System.Drawing.Point(83, 9);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(504, 34);
            this.lblMensaje2.TabIndex = 6;
            this.lblMensaje2.Text = "Usted Ha Seleccionado la Opcion de";
            this.lblMensaje2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Red;
            this.btnVolver.Location = new System.Drawing.Point(33, 358);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 47);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.Location = new System.Drawing.Point(521, 358);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 47);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lstContactosEditar
            // 
            this.lstContactosEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstContactosEditar.FormattingEnabled = true;
            this.lstContactosEditar.Location = new System.Drawing.Point(411, 122);
            this.lstContactosEditar.Name = "lstContactosEditar";
            this.lstContactosEditar.Size = new System.Drawing.Size(159, 28);
            this.lstContactosEditar.TabIndex = 13;
            // 
            // lblContactoEditar
            // 
            this.lblContactoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoEditar.Location = new System.Drawing.Point(84, 122);
            this.lblContactoEditar.Name = "lblContactoEditar";
            this.lblContactoEditar.Size = new System.Drawing.Size(286, 31);
            this.lblContactoEditar.TabIndex = 14;
            this.lblContactoEditar.Text = "Seleccione el Contacto a Editar";
            // 
            // lblNumeroEditar
            // 
            this.lblNumeroEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEditar.Location = new System.Drawing.Point(85, 179);
            this.lblNumeroEditar.Name = "lblNumeroEditar";
            this.lblNumeroEditar.Size = new System.Drawing.Size(236, 27);
            this.lblNumeroEditar.TabIndex = 15;
            this.lblNumeroEditar.Text = "Ingrese el Nuevo Numero";
            // 
            // lblNombreEditar
            // 
            this.lblNombreEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEditar.Location = new System.Drawing.Point(85, 236);
            this.lblNombreEditar.Name = "lblNombreEditar";
            this.lblNombreEditar.Size = new System.Drawing.Size(236, 29);
            this.lblNombreEditar.TabIndex = 16;
            this.lblNombreEditar.Text = "Ingrese el Nuevo Nombre";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Seleccione la Nueva Categoria";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(411, 237);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(159, 26);
            this.txtNuevoNombre.TabIndex = 18;
            // 
            // mskNuevoNumero
            // 
            this.mskNuevoNumero.Location = new System.Drawing.Point(411, 180);
            this.mskNuevoNumero.Mask = "000-000-0000";
            this.mskNuevoNumero.Name = "mskNuevoNumero";
            this.mskNuevoNumero.Size = new System.Drawing.Size(111, 26);
            this.mskNuevoNumero.TabIndex = 19;
            this.mskNuevoNumero.Click += new System.EventHandler(this.mskNuevoNumero_Click);
            // 
            // lstNuevaCategoria
            // 
            this.lstNuevaCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNuevaCategoria.FormattingEnabled = true;
            this.lstNuevaCategoria.Items.AddRange(new object[] {
            "FAMILIA",
            "TRABAJO",
            "AMIGOS"});
            this.lstNuevaCategoria.Location = new System.Drawing.Point(411, 300);
            this.lstNuevaCategoria.Name = "lstNuevaCategoria";
            this.lstNuevaCategoria.Size = new System.Drawing.Size(159, 28);
            this.lstNuevaCategoria.TabIndex = 20;
            // 
            // frmEditar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(668, 417);
            this.Controls.Add(this.lstNuevaCategoria);
            this.Controls.Add(this.mskNuevoNumero);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreEditar);
            this.Controls.Add(this.lblNumeroEditar);
            this.Controls.Add(this.lblContactoEditar);
            this.Controls.Add(this.lstContactosEditar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblOpcion2);
            this.Controls.Add(this.lblMensaje2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Un Contacto";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpcion2;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox lstContactosEditar;
        private System.Windows.Forms.Label lblContactoEditar;
        private System.Windows.Forms.Label lblNumeroEditar;
        private System.Windows.Forms.Label lblNombreEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.MaskedTextBox mskNuevoNumero;
        private System.Windows.Forms.ComboBox lstNuevaCategoria;
    }
}