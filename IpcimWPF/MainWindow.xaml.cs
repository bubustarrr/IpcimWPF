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
            var path = "C:\\Users\\André Norbert\\source\\repos\\IpcimWPF\\IpcimWPF\\csudh.txt";
            var sorok = File.ReadAllLines(path, Encoding.UTF8).Skip(1);
            foreach (string s in sorok)
            {
                string[] darabok = s.Split(';');
                string domainname = darabok[0];
                string ipaddress = darabok[1];
                adatok.Add(new Adatok(domainname, ipaddress));
            }
            dataGrid.ItemsSource = adatok;
        }

        
    }
}