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
using WpfApplication1.NoteManager;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //MyMsgError err = new MyMsgError();
        public MainWindow()
        {
            InitializeComponent();
            //connection.DataContext = err;
        }


        /*private void SeConnecter(object sender, RoutedEventArgs e)
        {
            Service1Client context = new Service1Client();
            if (Pseudo.Text != "" && Pass.Password != "")
            { 
                int id = context.Connection(Pseudo.Text, Pass.Password);
                if(id == 0)
                {
                   err.MessageError  = "Mauvais Pseudo ou Mauvais Mot de Passe ! Veuillez vérifier vos informations";
                }
                else
                {
                    //err.MessageError = id.ToString();
                    Prise_Note win = new Prise_Note(id);
                    win.Show();
                    Close();
                }
            }
        }

        class MyMsgError : INotifyPropertyChanged
        {
            string messageerror = "";
            public string MessageError { get { return this.messageerror; } set { this.messageerror = value; Notify("MessageError"); } }

            public event PropertyChangedEventHandler PropertyChanged;

            void Notify(string property)
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }*/
    }
}
