namespace KioscoAPI.Models
{
    public class Ventas
    {
        public int id {get; set;}
        public datatime fecha {get; set;}
        public decimal total {get; set;}
        public string tipo_venta{get; set;}
        public decimal saldo_pendiente{get; set;}
        public date fecha_pago_pactado{get; set;}
        
    }
}
