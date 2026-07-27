using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using WpfAppEfCoreDI.Presentation.Views;

namespace WpfAppEfCoreDI.Presentation.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        private Frame? _navigationFrame;
        private readonly CreateProductPage _createProductPage;
        private readonly ListProductsPage _listProductsPage;
        public MainViewModel(CreateProductPage createProductPage, ListProductsPage listProductsPage )
        {
            _createProductPage = createProductPage;
            _listProductsPage = listProductsPage;
        }

        public void RegisterFrame(Frame frame)
        {
            _navigationFrame = frame;
        }

        [RelayCommand]
        private void NavigateToCreatePage()
        {
            _navigationFrame!.Navigate(_createProductPage);
        }

        [RelayCommand]
        private void NavigateToListProductsPage()
        {
            _navigationFrame!.Navigate(_listProductsPage);
        }
    }
}
