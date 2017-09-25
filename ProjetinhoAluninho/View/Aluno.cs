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
    public partial class Tela3 : Form
    {
        private Aluno aluno;
        private bool modoEdicao;
        public Tela3()
        {
            InitializeComponent();
        }

        public void Init(Aluno a, bool modoEdicao)
        {
            if (modoEdicao)
            {
                aluno = a;
                nomealu.Text = a.nome;
                maskcpf.Text = a.cpf;
                rgaluno.Text = a.rg;
                endaluno.Text = a.endereco;
                telaluno.Text = a.telefone;
                emailaluno.Text = a.email;
                matricula.Text = a.matricula;
            }
            else
            {
                aluno = new Aluno();
            }
            //this refencia ao próprio objeto Professor que está em execução, tipo pegar ele mesmo
            //Ou um médico fazendo cirurgia em si mesmo
            this.modoEdicao = modoEdicao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verifica se não tem campo nulo  se não tiver ele vai pro proximo
            if (nomealu.Text != "" && maskcpf.Text != "" && rgaluno.Text != "" && endaluno.Text != ""
                && telaluno.Text != "" && matricula.Text != "" && emailaluno.Text != "")
            {
                aluno.nome = nomealu.Text;
                aluno.cpf = maskcpf.Text;
                aluno.rg = rgaluno.Text;
                aluno.endereco = endaluno.Text;
                aluno.telefone = telaluno.Text;
                aluno.email = emailaluno.Text;
                aluno.matricula = matricula.Text;


                if (Validacoes.ValidarCpf(aluno))
                {
                    if (modoEdicao || AlunoDAO.ObterAlunoPorcpf(aluno) == null)
                    {
                        if (modoEdicao)
                        {
                            if (AlunoDAO.Alterar(aluno))
                            {
                                MessageBox.Show("Aluno editado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Erro ao tentar editar o aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {

                            if (AlunoDAO.Incluir(aluno))
                            {
                                MessageBox.Show("Aluno cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Erro ao tentar incluir o aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        Program.atualizarListas();
                    }
                    else
                    {
                        MessageBox.Show("Aluno já cadastrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        //limpa campos chamo mo menu
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
        private void Tela3_Load(object sender, EventArgs e)
        {

        }
    }
}
