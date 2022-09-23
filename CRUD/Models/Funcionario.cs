using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRUD.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Column("IdFuncionario")]
        [Display(Name = "IdFuncionario")]
        [Key]
        public int IdFuncionario { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("RG")]
        [Display(Name = "RG")]
        public string RG { get; set; }

        [Column("Emissor")]
        [Display(Name = "Orgão emissor do RG")]
        public string Emissor { get; set; }

        [Column("Titulo")]
        [Display(Name = "Titulo de elitor")]
        public string Titulo { get; set; }

        [Column("CNH")]
        [Display(Name = "CNH")]
        public string CNH { get; set; }

        [Column("Gestor")]
        [Display(Name = "Considerar como gestor")]
        public bool Gestor { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereço")]
        public string Logradouro { get; set; }

        [Column("Numero")]
        [Display(Name = "Numero")]
        public int Numero { get; set; }

        [Column("Bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Column("Refencia")]
        [Display(Name = "Ponto de Refencia")]
        public string Refencia { get; set; }

    }
}
