namespace KioscoAPI.Models
{
    public class Productos
    {
        public int id {get; set;}
        public string nombre{get; set;}
        public string descripcion{get; set;}
        public decimal precio {get; set;}
        public int stock {get; set;}
        public int stock_minimo {get; set;}
        public int codigo_barra{get; set;}
        public bool estado{get; set;}        
    }
}
