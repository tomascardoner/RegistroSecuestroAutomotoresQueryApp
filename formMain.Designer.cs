namespace RegistroSecuestroAutomotorQueryApp
{
    partial class formMain
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
            this.labelDominio = new System.Windows.Forms.Label();
            this.textboxDominio = new System.Windows.Forms.TextBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDominio
            // 
            this.labelDominio.AutoSize = true;
            this.labelDominio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDominio.Location = new System.Drawing.Point(12, 15);
            this.labelDominio.Name = "labelDominio";
            this.labelDominio.Size = new System.Drawing.Size(82, 18);
            this.labelDominio.TabIndex = 0;
            this.labelDominio.Text = "Dominio:";
            // 
            // textboxDominio
            // 
            this.textboxDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxDominio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDominio.Location = new System.Drawing.Point(100, 12);
            this.textboxDominio.MaxLength = 7;
            this.textboxDominio.Name = "textboxDominio";
            this.textboxDominio.Size = new System.Drawing.Size(100, 27);
            this.textboxDominio.TabIndex = 1;
            this.textboxDominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxDominio.TextChanged += new System.EventHandler(this.DominioCambio);
            this.textboxDominio.Enter += new System.EventHandler(this.DominioFoco);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(206, 11);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(110, 29);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.Consultar);
            // 
            // labelEstado
            // 
            this.labelEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEstado.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEstado.Location = new System.Drawing.Point(12, 57);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(304, 43);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMain
            // 
            this.AcceptButton = this.buttonConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 109);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.textboxDominio);
            this.Controls.Add(this.labelDominio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Secuestro Automotor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDominio;
        private System.Windows.Forms.TextBox textboxDominio;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label labelEstado;
    }
}

