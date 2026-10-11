using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaApi.Models
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        [Column("id_producto")]
        public int IdProducto { get; set; }

        [Column("categoria")]
        public string Categoria { get; set; } = string.Empty;

        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("precio")]
        public decimal Precio { get; set; }

        [Column("disponible")]
        public bool Disponible { get; set; } = true;
    }
}
