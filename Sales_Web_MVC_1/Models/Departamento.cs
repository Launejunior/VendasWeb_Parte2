using System.Collections.Generic;
using System.Linq;

namespace Sales_Web_MVC_1.Models
{
    public class Departamento
    {
        public int Id  { get; set; }
        public string? Nome { get; set; }
        public ICollection<Seller_Vendedor_> Seller_Vendedors { get; set; } 
            = new List<Seller_Vendedor_>();

        public Departamento() { }

        public Departamento(int id, string? nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddSeller_Vendedor_(Seller_Vendedor_ seller_Vendedor_)
        {
            Seller_Vendedors.Add(seller_Vendedor_);
        }
        public double TotalSaler_Vendedor_(DateTime inicial, DateTime final)
        {
            return Seller_Vendedors.Sum(Seller_Vendedor_ => 
            Seller_Vendedor_.TotalSales_Vendas(inicial, final));
        }
    }
}
