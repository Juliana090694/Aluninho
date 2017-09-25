using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoAluninho.Model
{

    [Table("Projeto")]
    public class Projeto
    {
        public int Professor { get; set; }
        [ForeignKey("Id")]
        public virtual Professor professor { get; set; }
        public int Aluno { get; set; }
        [ForeignKey("Id")]
        public virtual Aluno aluno { get; set; }
        public string nomepro { get; set; }
        public DateTime data { get; set; }
        public String descricaodoprojeto { get; set; }
        [Key]
        public int Id { get; set; }

    }
}
