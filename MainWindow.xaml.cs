using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TestWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyMsg obj = new MyMsg();

        public MainWindow()
        {
            InitializeComponent();
            txtName.DataContext = obj;
        }

        private void SeConnecter(object sender, RoutedEventArgs e)
        {
            obj.MsgError = " message d'erreur";

        }

        private void Sinscrire(object sender, RoutedEventArgs e)
        {
            Inscription ins = new Inscription();
            Close();
            ins.Show();
        }

        class MyMsg : INotifyPropertyChanged
        {
            string msgError;
            public string MsgError { get { return msgError; } set { msgError = value; Notify("MsgError"); } }

            private void Notify(string v)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(v));
            }

            public event PropertyChangedEventHandler PropertyChanged;

        }
        /*public event PropertyChangedEventHandler PropertyChanged;

        private void Notify(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }*/
    }
}
