using CurrencyExchange.BLL.DTO;
using CurrencyExchange.BLL.Services;
using CurrencyExchange.UI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurrencyExchange.UI.ViewModels
{
    class CurrencyViewModel
    {
        CurrencyService currencyService;
        public ObservableCollection<CurrencyDTO> Currencies { get; set; }
        public CurrencyDTO SelectedCurrency { get; set; }
        public CurrencyViewModel()
        {
            currencyService = new CurrencyService();
            Currencies = new ObservableCollection<CurrencyDTO>(currencyService.GetAll());
            InitCommands();
        }

        public void InitCommands()
        {
            RemoveCurrencyCommand = new RelayCommand((param) =>
            {
                currencyService.Delete(SelectedCurrency);
                Currencies.Remove(SelectedCurrency);
            });

            AddCurrencyCommand = new RelayCommand((param) =>
            {
                currencyService.AddOrUpdate(SelectedCurrency);
                Currencies.Add(SelectedCurrency);
            });

            UpdateCurrencyCommand = new RelayCommand((param) =>
            {
                currencyService.AddOrUpdate(SelectedCurrency);
                Currencies.Remove(SelectedCurrency);
                Currencies.Add(SelectedCurrency);
            });
        }

        public ICommand RemoveCurrencyCommand { get; private set; }

        public ICommand AddCurrencyCommand { get; private set; }

        public ICommand UpdateCurrencyCommand { get; private set; }
    }
}
