using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleNote_Manager.TestServiceNote_Manager;

namespace TestConsoleNote_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client app = new Service1Client();

            int id = app.Connection("axel", "1234");
            Console.WriteLine("connected id : " + id);

            int idnote = app.AddNote("Test2", "pour voir si cela marche", id);
            Console.WriteLine("idNote " + idnote);

            bool modif = app.ModificationNote(idnote, "Modification du texte précedent");
            Console.WriteLine("Modification : " + modif);
            Console.ReadLine();

            bool remove = app.RemoveNote(idnote);
            Console.WriteLine("Suppression : " + remove);

            List<Note> res = app.Notes(id);

            if (res != null)
            {
                foreach (Note n in res)
                {
                    Console.WriteLine("titre : " + n.Texte);
                }
            }

            bool disc = app.Disconnection(id);
            Console.WriteLine("disconnected : " + disc);

            app.Close();

        }
    }
}
