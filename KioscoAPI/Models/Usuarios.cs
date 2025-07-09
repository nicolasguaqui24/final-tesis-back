namespace KioscoAPI.Models
{
    public class Usuarios
    {
    public int id{ get; set; }
    public string nombre { get; set; }
    public string usuario { get; set; }
    public bool estado { get; set; }
    public string rol { get; set; }   
    public string password_hash { get; set; }

    // Relación 1:N con Cuenta
  //  public ICollection<Cuenta> Cuentas { get; set; } = new List<Cuenta>();

    //public ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();

    }
}
