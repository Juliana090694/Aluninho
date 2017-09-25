using ProjetoAluninhos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoAluninho.DAO
{
    // é para criar algo unico.Algo que só pode ser criado uma vez.
    //no caso daqui ele faz a conecção com o banco tipo ele só conecta uma vez. Tipo filho unico de mãe solteira
    class SingletonTcc
    {
        private static readonly SingletonTcc instance = new SingletonTcc();
        private readonly TccEntities context;

        public SingletonTcc()
        {
            context = new TccEntities();
        }

        public static SingletonTcc Instance
        {
            get
            {
                return instance;
            }
        }

        public TccEntities Context
        {
            get
            {
                return context;
            }
        }
    }
}