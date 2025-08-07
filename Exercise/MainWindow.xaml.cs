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

namespace Exercise
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Output.Content = userInput.Text;
            if (userInput.Text == Output.Content.ToString())
            {
                outputStatus.Content = "Msg send successful";
                userInput.Text = "";
            }

            else
            {
                outputStatus.Content = "msg not sent...";
            }


        }

    }
}