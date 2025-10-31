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
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using A42_EduardoCarcaboso_BindingConObjetoNegocio;

namespace A42_EduardoCarcaboso_BindingConObjetoNegocio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowModel();
            Superheroe superheroe = new Superheroe();



        }
        public void Siguiente(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is MainWindowModel vm)
            {
                vm.Siguiente();
            }

        }

        public void Anterior(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is MainWindowModel vm)
            {
                vm.Anterior();
            }

        }
    }
}