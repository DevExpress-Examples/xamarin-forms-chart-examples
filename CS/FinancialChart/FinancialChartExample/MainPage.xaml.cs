﻿using FinancialChartExample.ViewModels;
using Xamarin.Forms;

namespace FinancialChartExample {
    public partial class MainPage : ContentPage {
        public MainPage() {
            DevExpress.XamarinForms.Charts.Initializer.Init();
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
