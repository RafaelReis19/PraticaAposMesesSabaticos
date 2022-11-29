using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProjectFistAfterCurso.Models
{
    [Table("Product")]
    public class Product
    {
        [Column("IdProduto")]
        [Display(Name = "Código")]
        [Key]
        public int IdProduto { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome Time")]
        public string NmProduto { get; set; }

        [Column("NotaProduto")]
        [Display(Name = "Nota Time")]
        public int NtProduto { get; set; }
    }
}
