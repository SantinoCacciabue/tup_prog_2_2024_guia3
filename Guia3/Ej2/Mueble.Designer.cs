namespace Ej2
{
    partial class Mueble
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
            this.cBtipo = new System.Windows.Forms.ComboBox();
            this.tBlargo = new System.Windows.Forms.TextBox();
            this.tBprecio = new System.Windows.Forms.TextBox();
            this.tBdesc = new System.Windows.Forms.TextBox();
            this.cBmaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBtipo
            // 
            this.cBtipo.FormattingEnabled = true;
            this.cBtipo.Items.AddRange(new object[] {
            "Mesa",
            "Silla"});
            this.cBtipo.Location = new System.Drawing.Point(83, 18);
            this.cBtipo.Name = "cBtipo";
            this.cBtipo.Size = new System.Drawing.Size(121, 21);
            this.cBtipo.TabIndex = 0;
            this.cBtipo.SelectedIndexChanged += new System.EventHandler(this.cBtipo_SelectedIndexChanged);
            // 
            // tBlargo
            // 
            this.tBlargo.Location = new System.Drawing.Point(83, 45);
            this.tBlargo.Name = "tBlargo";
            this.tBlargo.Size = new System.Drawing.Size(86, 20);
            this.tBlargo.TabIndex = 1;
            // 
            // tBprecio
            // 
            this.tBprecio.Location = new System.Drawing.Point(83, 97);
            this.tBprecio.Name = "tBprecio";
            this.tBprecio.Size = new System.Drawing.Size(86, 20);
            this.tBprecio.TabIndex = 2;
            // 
            // tBdesc
            // 
            this.tBdesc.Location = new System.Drawing.Point(83, 71);
            this.tBdesc.Name = "tBdesc";
            this.tBdesc.Size = new System.Drawing.Size(220, 20);
            this.tBdesc.TabIndex = 3;
            // 
            // cBmaterial
            // 
            this.cBmaterial.FormattingEnabled = true;
            this.cBmaterial.Items.AddRange(new object[] {
            "Pino",
            "Algarrobo",
            "Caoba"});
            this.cBmaterial.Location = new System.Drawing.Point(83, 123);
            this.cBmaterial.Name = "cBmaterial";
            this.cBmaterial.Size = new System.Drawing.Size(121, 21);
            this.cBmaterial.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Largo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material";
            // 
            // Aceptar
            // 
            this.Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Aceptar.Location = new System.Drawing.Point(77, 162);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 10;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Location = new System.Drawing.Point(187, 162);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Mueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 202);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBmaterial);
            this.Controls.Add(this.tBdesc);
            this.Controls.Add(this.tBprecio);
            this.Controls.Add(this.tBlargo);
            this.Controls.Add(this.cBtipo);
            this.Name = "Mueble";
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cBtipo;
        public System.Windows.Forms.TextBox tBlargo;
        public System.Windows.Forms.TextBox tBprecio;
        public System.Windows.Forms.TextBox tBdesc;
        public System.Windows.Forms.ComboBox cBmaterial;
        public System.Windows.Forms.Button Aceptar;
        public System.Windows.Forms.Button Cancelar;
    }
}