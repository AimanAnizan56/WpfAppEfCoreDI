using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WpfAppEfCoreDI.Appliciation.Services;
using WpfAppEfCoreDI.Domain.Entities;

namespace WpfAppEfCoreDI.Presentation.ViewModels
{
    public partial class CreateProductViewModel: ObservableObject
    {
        IProductService _productService;
        public CreateProductViewModel(IProductService productService)
        {
            _productService = productService;
        }

        [ObservableProperty]
        private string name = string.Empty;
        [ObservableProperty]
        private string price = string.Empty;
        [ObservableProperty]
        private string shortDescription = string.Empty;
        [ObservableProperty]
        private string quantity = string.Empty;

        [RelayCommand]
        private async Task CreateProduct()
        {
            if(string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Price) ||
                string.IsNullOrWhiteSpace(ShortDescription) ||
                string.IsNullOrWhiteSpace(Quantity))
            {
                MessageBox.Show("Some fields are missing.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var product = new Product
            {
                Name = Name,
                ShortDescription = ShortDescription,
                Quantity = Quantity,
                Price = Price,
            };
            bool isSuccess = await _productService.CreateProductAsync(product);
            if (!isSuccess)
            {
                MessageBox.Show("Could not create product.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBox.Show("Product created.", "", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        [RelayCommand]
        private void ClearInput()
        {
            Name = string.Empty;
            Price = string.Empty;
            ShortDescription = string.Empty;
            Quantity = string.Empty;
        }
    }
}
