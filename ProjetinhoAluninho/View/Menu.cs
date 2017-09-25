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

namespace ProjetinhoAluninho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Seta as listas para os objetos correspondentes obtidos em banco
            objectListView1.SetObjects(ProfessorDAO.ObterProfessores());
            objectListView2.SetObjects(AlunoDAO.ObterAlunos());
            objectListView3.SetObjects(ProjetoDAO.ObterProjetos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.openTela2(false, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //O programa realiza um Cast ↓↓↓↓↓
            if (objectListView1.SelectedObject != null)
                Program.openTela2(true, (Professor)objectListView1.SelectedObject);
            atualizar();
            //Casts servem para converter objetos de um tipo para outro, desde que seja compatíveis
            //No caso desse trecho, o objeto selecionado na lista é pego em sua forma pura (object) e então convertido 
            //para Professor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObject != null)
            {
                DialogResult dr = MessageBox.Show("Deseja realmente excluir esse registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Outro cast, igual ao de cima
                    //A lista não sabe o que ela recebe, nem sabe o que é model, então ela guarda só como objeto
                    ProfessorDAO.Excluir((Professor)objectListView1.SelectedObject);
                    atualizar();
                }
            }     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.openTela3(false, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //O programa realiza um Cast ↓↓↓↓↓
            if (objectListView2.SelectedObject != null)
                Program.openTela3(true, (Aluno)objectListView2.SelectedObject);
            atualizar();
            //Casts servem para converter objetos de um tipo para outro, desde que seja compatíveis
            //No caso desse trecho, o objeto selecionado na lista é pego em sua forma pura (object) e então convertido 
            //para Aluno
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (objectListView2.SelectedObject != null)
            {
                DialogResult dr = MessageBox.Show("Deseja realmente excluir esse registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Outro cast, igual ao de cima
                    //A lista não sabe o que ela recebe, nem sabe o que é model, então ela guarda só como objeto
                    AlunoDAO.Excluir((Aluno)objectListView2.SelectedObject);
                    atualizar();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.openTela4(false, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //O programa realiza um Cast ↓↓↓↓↓
            if (objectListView3.SelectedObject != null)
                Program.openTela4(true, (Projeto)objectListView3.SelectedObject);
            atualizar();
            //Casts servem para converter objetos de um tipo para outro, desde que seja compatíveis
            //No caso desse trecho, o objeto selecionado na lista é pego em sua forma pura (object) e então convertido 
            //para Aluno
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (objectListView3.SelectedObject != null)
            {
                DialogResult dr = MessageBox.Show("Deseja realmente excluir esse registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Outro cast, igual ao de cima
                    //A lista não sabe o que ela recebe, nem sabe o que é model, então ela guarda só como objeto
                    ProjetoDAO.Excluir((Projeto)objectListView3.SelectedObject);
                    atualizar();
                }
            } 
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Atulaiza as coisas do banco 
        public void atualizar()
        {
            objectListView1.SetObjects(ProfessorDAO.ObterProfessores());
            objectListView2.SetObjects(AlunoDAO.ObterAlunos());
            objectListView3.SetObjects(ProjetoDAO.ObterProjetos());
        }
    }
}
