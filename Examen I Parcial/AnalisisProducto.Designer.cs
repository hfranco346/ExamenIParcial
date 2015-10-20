namespace Examen_I_Parcial
{
    partial class frmReview
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
            this.gbAnalisis = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.gbAnalisis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnalisis
            // 
            this.gbAnalisis.Controls.Add(this.btnSalir);
            this.gbAnalisis.Controls.Add(this.btnAceptar);
            this.gbAnalisis.Controls.Add(this.txtNombre);
            this.gbAnalisis.Controls.Add(this.txtEmail);
            this.gbAnalisis.Controls.Add(this.txtValor);
            this.gbAnalisis.Controls.Add(this.txtComentarios);
            this.gbAnalisis.Controls.Add(this.lblComentarios);
            this.gbAnalisis.Controls.Add(this.lblValor);
            this.gbAnalisis.Controls.Add(this.lblEmail);
            this.gbAnalisis.Controls.Add(this.lblNombre);
            this.gbAnalisis.Controls.Add(this.lstProductos);
            this.gbAnalisis.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnalisis.Location = new System.Drawing.Point(12, 12);
            this.gbAnalisis.Name = "gbAnalisis";
            this.gbAnalisis.Size = new System.Drawing.Size(680, 417);
            this.gbAnalisis.TabIndex = 0;
            this.gbAnalisis.TabStop = false;
            this.gbAnalisis.Text = "Seleccione el producto a realizar su reseña/análisis";
            this.gbAnalisis.Enter += new System.EventHandler(this.gbAnalisis_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(349, 373);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(184, 33);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(130, 373);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(184, 33);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(307, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 30);
            this.txtNombre.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(307, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(307, 187);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(339, 30);
            this.txtValor.TabIndex = 7;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(307, 245);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComentarios.Size = new System.Drawing.Size(339, 113);
            this.txtComentarios.TabIndex = 6;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(300, 220);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(114, 22);
            this.lblComentarios.TabIndex = 4;
            this.lblComentarios.Text = "Comentarios";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(300, 162);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(98, 22);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valoración";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(300, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(164, 22);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(303, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(166, 22);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 22;
            this.lstProductos.Location = new System.Drawing.Point(32, 46);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(238, 312);
            this.lstProductos.TabIndex = 0;
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.gbAnalisis);
            this.MaximizeBox = false;
            this.Name = "frmReview";
            this.Text = "Reseña/Análisis de productos - AdventureWorks";
            this.Load += new System.EventHandler(this.frmReview_Load);
            this.gbAnalisis.ResumeLayout(false);
            this.gbAnalisis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnalisis;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lstProductos;
    }
}

