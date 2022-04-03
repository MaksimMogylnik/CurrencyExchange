using CurrencyExchange.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.DAL.Repositories
{
    public class CurrencyRepository : GenericRepository<Currency>
    {
        public CurrencyRepository(DbContext context) : base(context)
        { 
        
        }
    }
}
