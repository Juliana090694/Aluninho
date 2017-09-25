using ProjetinhoAluninho.Model;
using ProjetoAluninhos.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoAluninho.DAO
{
    class ProjetoDAO
    {
        public static bool Incluir(Projeto Projeto)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {

                // Aqui ele adiciona 
                db.Projeto.Add(Projeto);
                db.SaveChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }
        //Altera
        public static bool Alterar(Projeto Projeto)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                db.Entry(Projeto).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Exclui
        public static bool Excluir(Projeto Projeto)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                db.Projeto.Remove(Projeto);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Lista com o numero fixo
        public static IOrderedEnumerable<Projeto> ObterProjetos()
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                return db.Projeto.ToList().OrderBy(x => x.nomepro);
            }
            catch
            {
                return null;


            }
        }
    }
}
