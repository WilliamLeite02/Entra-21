
namespace ProjetoX
{
    partial class FrmCard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCard = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdoMasc = new System.Windows.Forms.RadioButton();
            this.rdoFem = new System.Windows.Forms.RadioButton();
            this.lblBairro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtMun = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.lblTell = new System.Windows.Forms.Label();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSit = new System.Windows.Forms.Label();
            this.cobSit = new System.Windows.Forms.ComboBox();
            this.lblAla = new System.Windows.Forms.Label();
            this.cboAla = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.ForeColor = System.Drawing.Color.Maroon;
            this.lblCard.Location = new System.Drawing.Point(37, 35);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(188, 33);
            this.lblCard.TabIndex = 0;
            this.lblCard.Text = "PACIENTE";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(37, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(87, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Identificação";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 145);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(124, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Paciente";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(37, 194);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(69, 17);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(437, 143);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 17);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo";
            // 
            // rdoMasc
            // 
            this.rdoMasc.AutoSize = true;
            this.rdoMasc.Location = new System.Drawing.Point(514, 141);
            this.rdoMasc.Name = "rdoMasc";
            this.rdoMasc.Size = new System.Drawing.Size(92, 21);
            this.rdoMasc.TabIndex = 5;
            this.rdoMasc.TabStop = true;
            this.rdoMasc.Text = "Masculino";
            this.rdoMasc.UseVisualStyleBackColor = true;
            // 
            // rdoFem
            // 
            this.rdoFem.AutoSize = true;
            this.rdoFem.Location = new System.Drawing.Point(612, 141);
            this.rdoFem.Name = "rdoFem";
            this.rdoFem.Size = new System.Drawing.Size(86, 21);
            this.rdoFem.TabIndex = 6;
            this.rdoFem.TabStop = true;
            this.rdoFem.Text = "Feminino";
            this.rdoFem.UseVisualStyleBackColor = true;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(37, 239);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 17);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Bairro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(153, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(441, 191);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 17);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(499, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 22);
            this.textBox5.TabIndex = 13;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(34, 283);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(67, 17);
            this.lblMunicipio.TabIndex = 14;
            this.lblMunicipio.Text = "Municipio";
            // 
            // txtMun
            // 
            this.txtMun.Location = new System.Drawing.Point(195, 280);
            this.txtMun.Name = "txtMun";
            this.txtMun.Size = new System.Drawing.Size(213, 22);
            this.txtMun.TabIndex = 15;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(450, 283);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 17);
            this.lblUF.TabIndex = 16;
            this.lblUF.Text = "UF";
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "RS",
            "SC",
            "PR",
            "SP",
            "RJ",
            "MS",
            "RO",
            "AC"});
            this.cboUF.Location = new System.Drawing.Point(499, 276);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(71, 24);
            this.cboUF.TabIndex = 17;
            // 
            // lblTell
            // 
            this.lblTell.AutoSize = true;
            this.lblTell.Location = new System.Drawing.Point(32, 323);
            this.lblTell.Name = "lblTell";
            this.lblTell.Size = new System.Drawing.Size(64, 17);
            this.lblTell.TabIndex = 18;
            this.lblTell.Text = "Telefone";
            this.lblTell.Click += new System.EventHandler(this.lblTell_Click);
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(195, 321);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(213, 22);
            this.txtTell.TabIndex = 19;
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(432, 326);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(52, 17);
            this.lblCell.TabIndex = 20;
            this.lblCell.Text = "Celular";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(499, 321);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(180, 22);
            this.txtCell.TabIndex = 21;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(450, 35);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(73, 17);
            this.lblDoc.TabIndex = 22;
            this.lblDoc.Text = "CNPJ/CPF";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(529, 35);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(213, 22);
            this.txtDoc.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 364);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 364);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 22);
            this.txtEmail.TabIndex = 25;
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Location = new System.Drawing.Point(33, 412);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(63, 17);
            this.lblSit.TabIndex = 26;
            this.lblSit.Text = "Situação";
            // 
            // cobSit
            // 
            this.cobSit.FormattingEnabled = true;
            this.cobSit.Items.AddRange(new object[] {
            "Alta",
            "Baixa",
            "Aguardando Diagnóstico",
            "Aguardando Atendimento",
            "Aguardando na enfermaria",
            "Aguardando Parecer Especialista",
            "Observação"});
            this.cobSit.Location = new System.Drawing.Point(106, 409);
            this.cobSit.Name = "cobSit";
            this.cobSit.Size = new System.Drawing.Size(302, 24);
            this.cobSit.TabIndex = 27;
            // 
            // lblAla
            // 
            this.lblAla.AutoSize = true;
            this.lblAla.Location = new System.Drawing.Point(456, 412);
            this.lblAla.Name = "lblAla";
            this.lblAla.Size = new System.Drawing.Size(28, 17);
            this.lblAla.TabIndex = 28;
            this.lblAla.Text = "Ala";
            // 
            // cboAla
            // 
            this.cboAla.FormattingEnabled = true;
            this.cboAla.Items.AddRange(new object[] {
            "UTI",
            "CTI",
            "Laboratório",
            "Enfermaria",
            "Infantíl",
            "Geriatría"});
            this.cboAla.Location = new System.Drawing.Point(499, 412);
            this.cboAla.Name = "cboAla";
            this.cboAla.Size = new System.Drawing.Size(199, 24);
            this.cboAla.TabIndex = 29;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Black;
            this.btnInsert.ForeColor = System.Drawing.Color.Blue;
            this.btnInsert.Location = new System.Drawing.Point(87, 524);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 38);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.ForeColor = System.Drawing.Color.Blue;
            this.btnModificar.Location = new System.Drawing.Point(235, 524);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 38);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Black;
            this.btnApagar.ForeColor = System.Drawing.Color.Blue;
            this.btnApagar.Location = new System.Drawing.Point(422, 524);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(120, 38);
            this.btnApagar.TabIndex = 32;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.ForeColor = System.Drawing.Color.Blue;
            this.btnPrint.Location = new System.Drawing.Point(574, 524);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 38);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // FrmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(791, 643);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cboAla);
            this.Controls.Add(this.lblAla);
            this.Controls.Add(this.cobSit);
            this.Controls.Add(this.lblSit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.lblTell);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtMun);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.rdoFem);
            this.Controls.Add(this.rdoMasc);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCard);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "FrmCard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdoMasc;
        private System.Windows.Forms.RadioButton rdoFem;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtMun;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label lblTell;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSit;
        private System.Windows.Forms.ComboBox cobSit;
        private System.Windows.Forms.Label lblAla;
        private System.Windows.Forms.ComboBox cboAla;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPrint;
    }
}

