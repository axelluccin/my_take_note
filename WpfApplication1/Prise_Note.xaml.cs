using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using WpfApplication1.NoteManager;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour Prise_Note.xaml
    /// </summary>
    public partial class Prise_Note : Window
    {
        int UserId;
        List<Note> my_note;
        Service1Client context = new Service1Client();

        public Prise_Note(int identification)
        {
            InitializeComponent();
            this.UserId = identification;
            my_note = context.Notes(this.UserId);

            //list_View_Note.ItemsSource = my_note;

            if (my_note.Count() > 0)
            {
                List<MyNote> list_view_note = new List<MyNote>();
                foreach(Note n in my_note)
                {
                    list_View_Note.Items.Add(n);
                }
                //list_View_Note.ItemsSource = list_view_note;
            }
        }

        private void Modification_Note(object sender, RoutedEventArgs e)
        {
            CreaModif_Note modif = new CreaModif_Note();
            modif.Show();
        }

        private void Suppresion_Note(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("valeur : " + list_View_Note.SelectedValue);
            list_View_Note.Items.Remove(list_View_Note.SelectedItem); 
        }
    }

    class MyNote
    {
        public string Title { get; set; }
        public DateTime Modification { get; set; }
        public string Content { get; set; }
    }
}
