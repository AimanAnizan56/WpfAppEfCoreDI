using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppEfCoreDI.Presentation.ViewModels;

namespace WpfAppEfCoreDI.Presentation.Views
{
    /// <summary>
    /// Interaction logic for CreateProductPage.xaml
    /// </summary>
    public partial class CreateProductPage : Page
    {
        public CreateProductPage(CreateProductViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void AllowPriceOnly(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            string newText = textBox!.Text.Insert(textBox.CaretIndex, e.Text);

            // Matches valid decimal numbers (e.g., 10, 10.5, 10.55)
            Regex regex = new Regex(@"^\d*\.?\d{0,2}$");
            e.Handled = !regex.IsMatch(newText);
        }
        private void AllowQuantityOnly(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
