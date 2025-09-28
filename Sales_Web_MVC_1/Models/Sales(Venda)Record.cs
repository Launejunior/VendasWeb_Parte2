using Sales_Web_MVC_1.Models.Enum;
using System.Linq;

namespace Sales_Web_MVC_1.Models
{
    public class Sales_Venda_Record
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double AmountQuantidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public SalesStatus Status { get; set; }
        public Seller_Vendedor_ Seller_Vendedor_ { get; set; }
        public Sales_Venda_Record() { }

        public Sales_Venda_Record(int id, DateTime data, double amountQuantidade,
            DateTime dataNascimento, SalesStatus status, 
            Seller_Vendedor_ seller_Vendedor_)
        {
            Id = id;
            Data = data;
            AmountQuantidade = amountQuantidade;
            DataNascimento = dataNascimento;
            Status = status;
            Seller_Vendedor_ = seller_Vendedor_;
        }
    }
}
