using ProjetinhoAluninho.Model;
using ProjetinhoAluninho.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetinhoAluninho
{
    static class Program
    {
        //Aqui eu digo que ele existe
        private static Form1 form1;
        private static Tela2 tela2;
        private static Tela3 tela3;
        private static Tela4 tela4;

        [STAThread]
        static void Main()
        {
            //Isso aqui são parâmetros para as janelas e devem ser aplicadas antes de instanciar!
            //EnableVisualStyles diz que o programa pode usar os temas do Windows (7, 8 ou 10)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //E aqui eu instancio (igual ao java)
            form1 = new Form1();
            tela2 = new Tela2();
            tela3 = new Tela3();
            tela4 = new Tela4();
            //Aqui roda a tela principal
            Application.Run(form1);

        }

        public static void openTela2(bool modoEdicao, Professor p)
        {
            tela2.Limparcampos();
            tela2.init(p, modoEdicao);
            tela2.ShowDialog(form1);

        }

        public static void openTela3(bool modoEdicao, Aluno a)
        {
            tela3.Limparcampos();
            tela3.Init(a, modoEdicao);
            tela3.ShowDialog(form1);
        }

        public static void openTela4(bool modoEdicao, Projeto p)
        {
            tela4.Limparcampos();
            tela4.Init(p, modoEdicao);
            tela4.ShowDialog(form1);
        }

        public static void atualizarListas()
        {
            form1.atualizar();
        }
    }
}
