using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFNepesseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dgTelepulesek = new List<Telepules>();

            StreamReader sr = new StreamReader("Adatok\\kozerdeku_lakossag_2022.csv")
        }

        private void cbMegyek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    public class Telepules
    {
        String megye;
        String telepulesNev;
        String telepulesTipus; //község, nagyközség, város, ...
        int ferfiLakosokSzama;
        int noiLakosokSzama;

        public Telepules(string megye,
                         string telepulesNev,
                         string telepulesTipus,
                         int ferfiLakosokSzama,
                         int noiLakosokSzama)
        {
            this.megye = megye;
            this.telepulesNev = telepulesNev;
            this.telepulesTipus = telepulesTipus;
            this.ferfiLakosokSzama = ferfiLakosokSzama;
            this.noiLakosokSzama = noiLakosokSzama;
        }
        public string Megye { get => megye; }
        public string TelepulesNev { get => telepulesNev; }
        public string TelepulesTipus { get => telepulesTipus; }
        int FerfiLakosokSzama { get => ferfiLakosokSzama; }
        int NoiLakosokSzama { get => noiLakosokSzama; }


    }
}
