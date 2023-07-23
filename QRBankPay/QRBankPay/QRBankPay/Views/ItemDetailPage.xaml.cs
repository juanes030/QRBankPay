using QRBankPay.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace QRBankPay.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}