using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.BLL.DTO
{
    public class CurrencyDTO
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SellPrice { get; set; }
        public string BankName { get; set; }
        public DateTime? Relevance { get; set; }
    }
}
