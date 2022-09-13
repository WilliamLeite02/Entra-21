namespace ProjetoMarketing
{
    partial class frmentrada
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.groaviso = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncomprar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groaviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BackgroundImage = global::ProjetoMarketing.Properties.Resources._81MqRau4C3L;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btncomprar);
            this.panel1.Controls.Add(this.groaviso);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.txtcode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 454);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Codigo";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(14, 58);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(141, 20);
            this.txtcode.TabIndex = 1;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(35, 94);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(74, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Digite o Nome";
            this.lblnome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(14, 110);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(141, 20);
            this.txtnome.TabIndex = 3;
            // 
            // groaviso
            // 
            this.groaviso.Controls.Add(this.label3);
            this.groaviso.Controls.Add(this.label2);
            this.groaviso.Location = new System.Drawing.Point(266, 261);
            this.groaviso.Name = "groaviso";
            this.groaviso.Size = new System.Drawing.Size(304, 95);
            this.groaviso.TabIndex = 4;
            this.groaviso.TabStop = false;
            this.groaviso.Text = "m";
            this.groaviso.Enter += new System.EventHandler(this.groaviso_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "COMPRE AGORA O MELHOR TELEFONE CELULAR \r\nSUPORTA 4K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "VEJA SEUS VIDEOS COM A MELHOR QUALIDADE\r\n PARA VOCê E SUA VIDA!\r\n ";
            // 
            // btncomprar
            // 
            this.btncomprar.Location = new System.Drawing.Point(358, 373);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(117, 23);
            this.btncomprar.TabIndex = 5;
            this.btncomprar.Text = "Veja Mais";
            this.btncomprar.UseVisualStyleBackColor = true;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click);
            // 
            // frmentrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmentrada";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groaviso.ResumeLayout(false);
            this.groaviso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groaviso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.Label label3;
    }
}

