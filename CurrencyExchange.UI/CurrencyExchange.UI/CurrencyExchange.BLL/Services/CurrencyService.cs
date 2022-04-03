using CurrencyExchange.BLL.DTO;
using CurrencyExchange.DAL.Context;
using CurrencyExchange.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.BLL.Services
{
    public class CurrencyService
    {
        IRepository<Currency> currencyRepository;

        public CurrencyService()
        {
            currencyRepository = new CurrencyRepository(new CurrencyContext());
        }

        public IEnumerable<CurrencyDTO> GetAll()
        {
            return currencyRepository
                        .GetAll()
                            .Select(cur => new CurrencyDTO
                            {
                                CurrencyId = cur.CurrencyId,
                                CurrencyName = cur.CurrencyName,
                                PurchasePrice = cur?.PurchasePrice,
                                SellPrice = cur?.SellPrice,
                                BankName = cur.BankName,
                                Relevance = cur?.Relevance
                            });
        }

        public CurrencyDTO Delete(CurrencyDTO currencyDTO)
        {
            Currency currencyToRemove = currencyRepository.Get(currencyDTO.CurrencyId);
            currencyRepository.Delete(currencyToRemove);
            currencyRepository.SaveChanges();
            return currencyDTO;
        }

        public void AddOrUpdate(CurrencyDTO currencyDTO)
        {
            Currency currencyToAdd = new Currency();

            currencyToAdd.CurrencyId = currencyDTO.CurrencyId;
            currencyToAdd.CurrencyName = currencyDTO.CurrencyName;
            currencyToAdd.PurchasePrice = currencyDTO.PurchasePrice;
            currencyToAdd.SellPrice = currencyDTO.SellPrice;
            currencyToAdd.BankName = currencyDTO.BankName;
            currencyToAdd.Relevance = currencyDTO.Relevance;

            currencyRepository.CreateOrUpdate(currencyToAdd);
            currencyRepository.SaveChanges();
        }
    }
}
