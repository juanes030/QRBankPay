using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using QRBankPay.Data.Models;
using QRBankPay.Services;
using Xamarin.CommunityToolkit.ObjectModel;

namespace QRBankPay.ViewModels
{
	public class ClientsViewModel :BaseViewModel
	{
        private readonly IClientService _clientService;

        public ClientsViewModel(IClientService clientService)
        {
           _clientService = clientService;
            AppearingCommand = new AsyncCommand(async () => await OnAppearingAsync());
            Title = "Clients";

        }

        public ObservableRangeCollection<Client> Clients { get; set; } = new ObservableRangeCollection<Client>();

        public ICommand AppearingCommand { get; set; }

        private async Task OnAppearingAsync()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                IsBusy = true;
                var clients = await _clientService.GetClientsAsync();
                if (clients.Count > 0)
                {
                    Clients.ReplaceRange(clients);
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }


    }
}

