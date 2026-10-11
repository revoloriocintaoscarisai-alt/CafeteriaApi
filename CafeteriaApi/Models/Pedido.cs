using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaApi.Models
{
    [Table("pedidos")]
    public class Pedido
    {
        [Key]
        [Column("id_pedido")]
        public int IdPedido { get; set; }

        [Column("cliente")]
        public string Cliente { get; set; } = string.Empty;

        [Column("producto")]
        public string Producto { get; set; } = string.Empty;

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("precio_unit")]
        public decimal PrecioUnit { get; set; }

        [Column("subtotal")]
        public decimal Subtotal { get; set; }

        [Column("estado")]
        public string Estado { get; set; } = "Pendiente";
    }
}
