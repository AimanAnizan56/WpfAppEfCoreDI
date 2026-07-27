using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for ListProductsPage.xaml
    /// </summary>
    public partial class ListProductsPage : Page
    {
        public ListProductsPage(ListProductsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
