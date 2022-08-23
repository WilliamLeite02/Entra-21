namespace app
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbnome = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbtelefone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbtelefone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(202, 83);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(46, 15);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome :";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(202, 136);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(42, 15);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "Email :";
            this.lbemail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbtelefone
            // 
            this.lbtelefone.AutoSize = true;
            this.lbtelefone.Location = new System.Drawing.Point(187, 186);
            this.lbtelefone.Name = "lbtelefone";
            this.lbtelefone.Size = new System.Drawing.Size(57, 15);
            this.lbtelefone.TabIndex = 2;
            this.lbtelefone.Text = "Telefone :";
            this.lbtelefone.Click += new System.EventHandler(this.lbtelefone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(267, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Por favor preencha o formulário.";
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(254, 80);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(279, 23);
            this.tbnome.TabIndex = 4;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(254, 133);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(279, 23);
            this.tbemail.TabIndex = 5;
            // 
            // tbtelefone
            // 
            this.tbtelefone.Location = new System.Drawing.Point(254, 183);
            this.tbtelefone.Name = "tbtelefone";
            this.tbtelefone.Size = new System.Drawing.Size(279, 23);
            this.tbtelefone.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Inserir Imagem";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(287, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 131);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbtelefone);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbtelefone);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbnome);
            this.Name = "App";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbnome;
        private Label lbemail;
        private Label lbtelefone;
        private Label label4;
        private TextBox tbnome;
        private TextBox tbemail;
        private TextBox tbtelefone;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}