using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NTI.INV
{
    public class Categoria
    {
        [Key]
        [Column(TypeName = "varchar(5)")]
        public string IdCategoria { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string? Nombre { get; set; }
    }

    public class Permisos
    {
        [Key]
        [Column(TypeName = "varchar(5)")]
        public string? IdPermisos { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? TipoPermiso { get; set; }
    }

    public class Productos
    {
        [Key]
        [Column(TypeName = "varchar(5)")]
        public string Codigo { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string? Nombre { get; set; }

        [ForeignKey("Categoria")]
        [Column(TypeName = "varchar(5)")]
        public string? IdCategoria { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal? Precio { get; set; }

        public int? Stock { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }

    public class Usuarios
    {
        [Key]
        [Column(TypeName = "varchar(5)")]
        public string Codigo { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string? Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Correo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Usuario { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Password { get; set; }

        [ForeignKey("Permisos")]
        [Column(TypeName = "varchar(5)")]
        public string? IdPermisos { get; set; }

        public virtual Permisos? Permisos { get; set; }
    }
}
