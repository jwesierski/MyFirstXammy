using System.ComponentModel;
using MyFirstXammy.ViewModels;
using Xamarin.Forms;

namespace MyFirstXammy.Views
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