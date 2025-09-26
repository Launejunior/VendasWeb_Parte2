using System.Linq;

namespace Sales_Web_MVC_1.Models
{
    public class Seller_Vendedor_
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? BaseSalário { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Sales_Venda_Record> Sales_Vendas { get; set; } 
            = new List<Sales_Venda_Record>();
        public object Sales_Vendas_ { get; set; }

        public Seller_Vendedor_ () { }

        public Seller_Vendedor_(int id, string? nome, string? email, 
            DateTime dataNascimento, string? baseSalário, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            BaseSalário = baseSalário;
            Departamento = departamento;
        }

        public void AddSales(Sales_Venda_Record svr) {
            Sales_Vendas.Add(svr);
        }
        public void RemoveSales(Sales_Venda_Record svr) { 
            Sales_Vendas.Remove(svr);  
        
        }
        public double TotalSales_Vendas(DateTime inicial, DateTime final)
        {
            return Sales_Vendas.Where(svr => svr.Data >= inicial && 
            svr.Data <= final).Sum(svr => svr.AmountQuantidade);

        }


    }
}
