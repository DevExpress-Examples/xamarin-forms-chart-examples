using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PieChartExample {
    public partial class App : Application {
        public App() {
            InitializeComponent();
            MainPage = new MainPage();
        }
    }
}
