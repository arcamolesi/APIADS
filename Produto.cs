using System.ComponentModel.DataAnnotations;

namespace APIADS
{
    public class Produto
    {
        [Key]
        public int id  { get; set; }

        [StringLength(35)]
        public string descricao { get; set; }

        public float quantidade { get; set; }
        public float valor { get; set; }
    }
}
