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
    class ProfessorDAO
    {

        public static bool Incluir(Professor Professor)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                //Adiciona
                db.Professor.Add(Professor);
                db.SaveChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }
        //altera
        public static bool Alterar(Professor Professor)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                db.Entry(Professor).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Exclui
        public static bool Excluir(Professor Professor)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                db.Professor.Remove(Professor);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Lista com o numero fixo
        public static IOrderedEnumerable<Professor> ObterProfessores()
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                return db.Professor.ToList().OrderBy(x => x.nome);
            }
            catch
            {
                return null;
            }
        }//Essa função faz busca no banco por cpf, mas vou usalá pra ver se não tem mais nenhum cpf cadatrado igual
        public static Professor ObterProfessorPorcpf(Professor Professor)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                return db.Professor.FirstOrDefault(x => x.cpf.Equals(Professor.cpf));
            }
            catch
            {
                return null;
            }
        }
    }
}
