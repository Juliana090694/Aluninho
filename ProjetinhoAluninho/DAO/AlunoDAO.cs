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
    class AlunoDAO
    {


        public static bool Incluir(Aluno Aluno)
        {
            //adiciona
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                db.Aluno.Add(Aluno);
                db.SaveChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }
        //altera
        public static bool Alterar(Aluno Aluno)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                db.Entry(Aluno).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Remove
        public static bool Excluir(Aluno Aluno)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                db.Aluno.Remove(Aluno);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Lista Com o numro fixo que nos foi ensinado. 
        public static IOrderedEnumerable<Aluno> ObterAlunos()
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                return db.Aluno.ToList().OrderBy(x => x.nome);
            }
            catch
            {
                return null;
            }
        }
        //Essa função faz busca no banco por cpf, mas vou usalá pra ver se não tem mais nenhum cpf cadatrado igual
        public static Aluno ObterAlunoPorcpf(Aluno Aluno)
        {
            TccEntities db = SingletonTcc.Instance.Context;
            try
            {
                return db.Aluno.FirstOrDefault(x => x.cpf.Equals(Aluno.cpf));
            }
            catch
            {
                return null;
            }
        }
    }
}
