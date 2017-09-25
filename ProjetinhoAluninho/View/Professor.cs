using ProjetinhoAluninho.DAO;
using ProjetinhoAluninho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetinhoAluninho.View
{
    public partial class Tela2 : Form
    {
        private Professor professor;
        private bool modoEdicao;

        public Tela2()
        {
            InitializeComponent();
        }

        public void init(Professor p, bool modoEdicao)
        {
            if (modoEdicao)
            {
                professor = p;
                nomep.Text = p.nome;
                cpfp.Text = p.cpf;
                rgp.Text = p.rg;
                endp.Text = p.endereco;
                telp.Text = p.telefone;
                codp.Text = p.codigo;
                emailp.Text = p.email;
            }
            else
            {
                professor = new Professor();
            }
            //this refencia ao próprio objeto Professor que está em execução, tipo pegar ele mesmo
            //Ou um médico fazendo cirurgia em si mesmo
            this.modoEdicao = modoEdicao;
        }

        public object ProfessorDao { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomep.Text != "" && cpfp.Text != "" && rgp.Text != "" && endp.Text != ""
                && telp.Text != "" && codp.Text != "" && emailp.Text != "")
            {
                //objeto aluno igual java 
                professor.nome = nomep.Text;
                professor.cpf = cpfp.Text;
                professor.rg = rgp.Text;
                professor.endereco = endp.Text;
                professor.telefone = telp.Text;
                professor.email = emailp.Text;
                professor.codigo = codp.Text;


                if (Validacoes.ValidarCpf(professor))
                {
                    //Se for no modo edição, ele entra para editar sem se preocupar com o CPF
                    //Do contrário, ele só entra quando não houver o cpf no banco
                    if (modoEdicao || ProfessorDAO.ObterProfessorPorcpf(professor) == null)
                    {
                        if (modoEdicao)
                        {
                            if (ProfessorDAO.Alterar(professor))
                            {
                                MessageBox.Show("Professor editado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Erro ao tentar editar o professor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (ProfessorDAO.Incluir(professor))
                            {
                                MessageBox.Show("Professor cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Erro ao tentar incluir o professor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        Program.atualizarListas();
                    }
                    else
                    {
                        MessageBox.Show("Professor já cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("CPF inválido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Limparcampos()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }
        }

        private void Tela2_Load(object sender, EventArgs e)
        {

        }
    }
}
