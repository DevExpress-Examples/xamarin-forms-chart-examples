using FinancialChartExample.ViewModels;
using Xamarin.Forms;

namespace FinancialChartExample {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
