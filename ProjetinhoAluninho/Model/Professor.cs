using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoAluninho.Model
{
    [Table("Professor")]
    public class Professor
    {
        public Professor()
        {
            this.Projeto = new HashSet<Projeto>();
        }

        [Key]
        public int Id { set; get; }
        public String nome { set; get; }
        public String cpf { set; get; }
        public String rg { set; get; }
        public String codigo { set; get; }
        public String endereco { set; get; }
        public String telefone { set; get; }
        public String email { set; get; }

        public virtual ICollection<Projeto> Projeto { get; set; }

    }
}
