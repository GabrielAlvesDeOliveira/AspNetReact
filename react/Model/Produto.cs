using System.ComponentModel.DataAnnotations.Schema;

namespace react.Model
{
    [Table("Produto")]
    public class Produto
    {

        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string? Nome { get; set; }
    }
}
