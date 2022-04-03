namespace CurrencyExchange.DAL.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CurrencyContext : DbContext
    {
        public CurrencyContext()
            : base("name=CurrencyContext")
        {

        }

        public virtual DbSet<Currency> Currencies { get; set; }

    }
}