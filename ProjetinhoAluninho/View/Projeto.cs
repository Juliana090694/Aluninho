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
    public partial class Tela4 : Form
    {
        private Aluno aluno;
        private Professor professor;
        private Projeto projeto;
        private bool modoEdicao;

        public Tela4()
        {
            InitializeComponent();
        }

        public void Init(Projeto p, bool modoEdicao)
        {
            if (modoEdicao)
            {
                projeto = p;
                dateTimePicker1.Value = projeto.data;
                textBox2.Text = projeto.descricaodoprojeto;
                textBox1.Text = projeto.nomepro;
                professor = projeto.professor;
                aluno = projeto.aluno;
                textBox3.Text = aluno.cpf + " - " + aluno.nome;
                textBox4.Text = professor.cpf + " - " + professor.nome;
            }
            else
            {
                projeto = new Projeto();
            }
            //this refencia ao próprio objeto Professor que está em execução, tipo pegar ele mesmo
            //Ou um médico fazendo cirurgia em si mesmo
            this.modoEdicao = modoEdicao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aluno != null && professor != null && dateTimePicker1.Value != null && textBox1.Text != "" && textBox2.Text != "")
            {
                projeto.data = dateTimePicker1.Value;
                projeto.descricaodoprojeto = textBox2.Text;
                projeto.nomepro = textBox1.Text;
                projeto.professor = professor;
                projeto.aluno = aluno;
                projeto.Aluno = aluno.Id;
                projeto.Professor = professor.Id;

                if (modoEdicao)
                {
                    if (ProjetoDAO.Alterar(projeto))
                    {
                        MessageBox.Show("Projeto editado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar editar o projeto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ProjetoDAO.Incluir(projeto))
                    {
                        MessageBox.Show("Projeto cadastrado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar incluir o projeto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Program.atualizarListas();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Aluno a = new Aluno();
                a.cpf = textBox3.Text;
                a = AlunoDAO.ObterAlunoPorcpf(a);
                if (a != null)
                {
                    textBox3.Text = a.cpf + " - " + a.nome;
                    aluno = a;
                    textBox3.ReadOnly = true;
                    button3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                Professor p = new Professor();
                p.cpf = textBox4.Text;
                p = ProfessorDAO.ObterProfessorPorcpf(p);
                if (p != null)
                {
                    textBox4.Text = p.cpf + " - " + p.nome;
                    professor = p;
                    textBox4.ReadOnly = true;
                    button4.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Professor não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //reativa as caixas ou seja limpa
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            button3.Enabled = true;
            button4.Enabled = true;
            //seta a data para hoje
            dateTimePicker1.Value = DateTime.Today;
        }

        private void Tela4_Load(object sender, EventArgs e)
        {

        }
    }
}
