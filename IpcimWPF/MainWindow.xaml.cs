using System.IO;
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

namespace IpcimWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Adatok
    {
        public string Domainname { get; set; }
        public string Ipaddress { get; set; }

        public Adatok(string domainname, string ipaddress)
        {
            Domainname = domainname;
            Ipaddress = ipaddress;
        }
    }

    public partial class MainWindow : Window
    {
        public List<Adatok> adatok = new List<Adatok>();
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}