using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoAluninho.Model
{
    [Table("Aluno")]
    public class Aluno
    {

        public Aluno()
        {
            this.Projeto = new HashSet<Projeto>();
        }

        //Define a chave primária
        [Key]
        public int Id { set; get; }
        public String nome { set; get; }
        public String cpf { set; get; }
        public String rg{ set; get; }
        public String matricula { set; get; }
        public String endereco { set; get; }
        public String telefone { set; get; }
        public String email { set; get; }

        //Lista de projeto, que é uma coleção (Interface) para lidar com as chaves
        public virtual ICollection<Projeto> Projeto { get; set; }

    }
}
