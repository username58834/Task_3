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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnExit_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnCount_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            double c = double.Parse(Txt_C.Text);
            double d = double.Parse(Txt_D.Text);

            double res = 2 * c + 82 * d;
            Txt_Result.Text = res.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void AfterChanging()
    {
        if(Txt_C.Text.Length == 0 || Txt_D.Text.Length == 0)
        {
            BtnCount.IsEnabled = false;
        }
        else
        {
            BtnCount.IsEnabled = true;
        }

        Txt_Result.Text = "";
    }
    private void Txt_C_TextChanged(object sender, TextChangedEventArgs e)
    {
        AfterChanging();
    }

    private void Txt_D_TextChanged(object sender, TextChangedEventArgs e)
    {
        AfterChanging();
    }
}