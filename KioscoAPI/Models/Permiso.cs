using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace digitalArsv1.Models
{
    public class Permiso
    {
        [Key]
        public int id { get; set; }
        public string acceso { get; set; } = string.Empty;
        public int id_usuario { get; set; }

            [ForeignKey("id_usuario")]
            public Usuario Usuario { get; set;}

    }
}