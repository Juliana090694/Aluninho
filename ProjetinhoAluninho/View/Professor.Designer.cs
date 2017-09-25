namespace ProjetinhoAluninho.View
{
    partial class Tela2
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
            this.nomep = new System.Windows.Forms.TextBox();
            this.rgp = new System.Windows.Forms.TextBox();
            this.endp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailp = new System.Windows.Forms.TextBox();
            this.telp = new System.Windows.Forms.MaskedTextBox();
            this.cpfp = new System.Windows.Forms.MaskedTextBox();
            this.codp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(244, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(346, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nomep
            // 
            this.nomep.Location = new System.Drawing.Point(107, 24);
            this.nomep.Name = "nomep";
            this.nomep.Size = new System.Drawing.Size(293, 20);
            this.nomep.TabIndex = 2;
            // 
            // rgp
            // 
            this.rgp.Location = new System.Drawing.Point(107, 108);
            this.rgp.Name = "rgp";
            this.rgp.Size = new System.Drawing.Size(293, 20);
            this.rgp.TabIndex = 4;
            // 
            // endp
            // 
            this.endp.Location = new System.Drawing.Point(107, 152);
            this.endp.Name = "endp";
            this.endp.Size = new System.Drawing.Size(293, 20);
            this.endp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "R.G. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone :";
            // 
            // emailp
            // 
            this.emailp.Location = new System.Drawing.Point(107, 240);
            this.emailp.Name = "emailp";
            this.emailp.Size = new System.Drawing.Size(293, 20);
            this.emailp.TabIndex = 12;
            // 
            // telp
            // 
            this.telp.Location = new System.Drawing.Point(107, 189);
            this.telp.Mask = "(999) 000-0000";
            this.telp.Name = "telp";
            this.telp.Size = new System.Drawing.Size(293, 20);
            this.telp.TabIndex = 13;
            // 
            // cpfp
            // 
            this.cpfp.Location = new System.Drawing.Point(107, 65);
            this.cpfp.Mask = "999\\.999\\.999\\-99";
            this.cpfp.Name = "cpfp";
            this.cpfp.Size = new System.Drawing.Size(293, 20);
            this.cpfp.TabIndex = 14;
            // 
            // codp
            // 
            this.codp.Location = new System.Drawing.Point(107, 287);
            this.codp.Name = "codp";
            this.codp.Size = new System.Drawing.Size(293, 20);
            this.codp.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cod Funcionario :";
            // 
            // Tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 385);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.codp);
            this.Controls.Add(this.cpfp);
            this.Controls.Add(this.telp);
            this.Controls.Add(this.emailp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endp);
            this.Controls.Add(this.rgp);
            this.Controls.Add(this.nomep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tela2";
            this.Text = "Cadastro Professor";
            this.Load += new System.EventHandler(this.Tela2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nomep;
        private System.Windows.Forms.TextBox rgp;
        private System.Windows.Forms.TextBox endp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailp;
        private System.Windows.Forms.MaskedTextBox telp;
        private System.Windows.Forms.MaskedTextBox cpfp;
        private System.Windows.Forms.TextBox codp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}