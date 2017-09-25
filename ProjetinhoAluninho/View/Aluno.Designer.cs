namespace ProjetinhoAluninho.View
{
    partial class Tela3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nomealu = new System.Windows.Forms.TextBox();
            this.maskcpf = new System.Windows.Forms.MaskedTextBox();
            this.rgaluno = new System.Windows.Forms.TextBox();
            this.endaluno = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.telaluno = new System.Windows.Forms.MaskedTextBox();
            this.emailaluno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(241, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Grava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(343, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancela";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "R.G. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Matricula : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email :";
            // 
            // nomealu
            // 
            this.nomealu.Location = new System.Drawing.Point(78, 16);
            this.nomealu.Name = "nomealu";
            this.nomealu.Size = new System.Drawing.Size(294, 20);
            this.nomealu.TabIndex = 9;
            // 
            // maskcpf
            // 
            this.maskcpf.Location = new System.Drawing.Point(78, 55);
            this.maskcpf.Mask = "999\\.999\\.999\\-99";
            this.maskcpf.Name = "maskcpf";
            this.maskcpf.Size = new System.Drawing.Size(294, 20);
            this.maskcpf.TabIndex = 10;
            // 
            // rgaluno
            // 
            this.rgaluno.Location = new System.Drawing.Point(78, 97);
            this.rgaluno.Name = "rgaluno";
            this.rgaluno.Size = new System.Drawing.Size(294, 20);
            this.rgaluno.TabIndex = 11;
            // 
            // endaluno
            // 
            this.endaluno.Location = new System.Drawing.Point(77, 133);
            this.endaluno.Name = "endaluno";
            this.endaluno.Size = new System.Drawing.Size(295, 20);
            this.endaluno.TabIndex = 12;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(78, 211);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(293, 20);
            this.matricula.TabIndex = 13;
            // 
            // telaluno
            // 
            this.telaluno.Location = new System.Drawing.Point(77, 173);
            this.telaluno.Mask = "(999) 000-0000";
            this.telaluno.Name = "telaluno";
            this.telaluno.Size = new System.Drawing.Size(294, 20);
            this.telaluno.TabIndex = 14;
            // 
            // emailaluno
            // 
            this.emailaluno.Location = new System.Drawing.Point(78, 250);
            this.emailaluno.Name = "emailaluno";
            this.emailaluno.Size = new System.Drawing.Size(293, 20);
            this.emailaluno.TabIndex = 15;
            // 
            // Tela3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 428);
            this.Controls.Add(this.emailaluno);
            this.Controls.Add(this.telaluno);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.endaluno);
            this.Controls.Add(this.rgaluno);
            this.Controls.Add(this.maskcpf);
            this.Controls.Add(this.nomealu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tela3";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.Tela3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nomealu;
        private System.Windows.Forms.MaskedTextBox maskcpf;
        private System.Windows.Forms.TextBox rgaluno;
        private System.Windows.Forms.TextBox endaluno;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.MaskedTextBox telaluno;
        private System.Windows.Forms.TextBox emailaluno;
    }
}