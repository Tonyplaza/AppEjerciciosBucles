namespace AppEjerciciosBucles
{
    partial class frmBucleFor
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
            this.btnLlenarLista = new System.Windows.Forms.Button();
            this.btnOrdenarLista = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLlenarLista
            // 
            this.btnLlenarLista.Location = new System.Drawing.Point(70, 56);
            this.btnLlenarLista.Name = "btnLlenarLista";
            this.btnLlenarLista.Size = new System.Drawing.Size(138, 23);
            this.btnLlenarLista.TabIndex = 0;
            this.btnLlenarLista.Text = "Llenar la lista de numeros";
            this.btnLlenarLista.UseVisualStyleBackColor = true;
            this.btnLlenarLista.Click += new System.EventHandler(this.btnLlenarLista_Click);
            // 
            // btnOrdenarLista
            // 
            this.btnOrdenarLista.Location = new System.Drawing.Point(244, 55);
            this.btnOrdenarLista.Name = "btnOrdenarLista";
            this.btnOrdenarLista.Size = new System.Drawing.Size(90, 23);
            this.btnOrdenarLista.TabIndex = 1;
            this.btnOrdenarLista.Text = "Ordenar la lista";
            this.btnOrdenarLista.UseVisualStyleBackColor = true;
            this.btnOrdenarLista.Click += new System.EventHandler(this.btnOrdenarLista_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(70, 112);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(138, 121);
            this.lstNumeros.TabIndex = 2;
            this.lstNumeros.SelectedIndexChanged += new System.EventHandler(this.lstNumeros_SelectedIndexChanged);
            // 
            // frmBucleFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 270);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnOrdenarLista);
            this.Controls.Add(this.btnLlenarLista);
            this.Name = "frmBucleFor";
            this.Text = "Ejemplo bucle for";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlenarLista;
        private System.Windows.Forms.Button btnOrdenarLista;
        private System.Windows.Forms.ListBox lstNumeros;
    }
}