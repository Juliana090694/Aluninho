using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetinhoAluninho.Model;
namespace ProjetoAluninhos.DAO
{
    //Liga o banco
    class TccEntities : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
            modelBuilder.Entity<Professor>().ToTable("Professor");
            //A entidade Projeto precisa do campo aluno (HasRequired)
            //A entidade possui vários projetos (With many)
            //A entidade possui chave estrangeira (int Aluno)
            //E não vai deletar todos os projetos relacionados ao deletar aluno (willCascadeOnDelete)
            modelBuilder.Entity<Projeto>().ToTable("Projeto")
                .HasRequired(e => e.aluno)
                .WithMany(t => t.Projeto)
                .HasForeignKey(e => e.Aluno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projeto>().ToTable("Projeto")
                .HasRequired(e => e.professor)
                .WithMany(t => t.Projeto)
                .HasForeignKey(e => e.Professor)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Aluno> Aluno { set; get; }
        public virtual DbSet<Professor> Professor { set; get; }
        public virtual DbSet<Projeto> Projeto { set; get; }
    }
}

