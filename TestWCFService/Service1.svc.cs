using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestWCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        //Ajout d'un utilisateur
        public int AddUser(string Pseudo, string Pass)
        {
            User ajout_utilisateur = new User()
            {
                Pseudonyme = Pseudo,
                Password = Pass,
                Connected = true
            };

            context = new Model1Container();
            if (getIdUser(Pseudo) == 0)
            {
                context.User.Add(ajout_utilisateur);
                context.SaveChanges();
                return getIdUser(Pseudo);
            }
            else
                return 0;
        }

        //Déconnexion d'un utilisateur
        public bool Disconnection(int identification)
        {
            context = new Model1Container();

            context.User.Find(identification).Connected = false;

            context.SaveChanges();
            return true;
        }

        //Connexion d'un utilisateur
        public int Connection(string Pseudo, string Pass)
        {
            context = new Model1Container();

            var result = from query in context.User
                         where query.Pseudonyme == Pseudo && query.Password == Pass
                         select query;

            if (result.Count() == 1)
            {
                result.First().Connected = true;
                context.SaveChanges();
                return result.First().Id;
            } 
            else
                return 0;
        }

        //Ajout d'une note
        public int AddNote(string title, string note, int identification)
        {
            context = new Model1Container();

            Note n = new Note()
            {
                Titre = title,
                Creation = DateTime.Now,
                Modification = DateTime.Now,
                Texte = note,
                UserId = identification
            };

            if (getIdNote(n.Titre, identification) == 0 && context.User.Find(identification).Connected)
            {
                context.Note.Add(n);
                context.SaveChanges();
                return getIdNote(title, identification);
            }

            return 0;
        }

        //Modification d'une note
        public bool ModificationNote(int identification, string Ti, string Te)
        {
            context = new Model1Container();

            Note result = context.Note.Find(identification) ;

            if (result != null && context.User.Find(result.UserId).Connected)
            {
                result.Titre = Ti;
                result.Texte = Te;
                result.Modification = DateTime.Now;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        //Effacer une note
        public bool RemoveNote(int identification)
        {
            context = new Model1Container();

            Note result = context.Note.Find(identification);

            if (result != null && context.User.Find(result.UserId).Connected)
            {
                context.Note.Remove(result);
                context.SaveChanges();
                return true;
            }
            return false;
        }


        //Récuperation d'un list de note
        public MyNote[] Notes(int identification)
        {
            context = new Model1Container();

            var result = from query in context.Note
                         where query.UserId == identification
                         select query;

            List<MyNote> n = new List<MyNote>();
            foreach (var y in result)
            {
                n.Add(new MyNote { ID = y.Id, Titre = y.Titre, Modification = y.Modification, Texte = y.Texte  });
            }
            return n.ToArray(); ;
        }

        /*
        //    Private Method and value
        */

        private Model1Container context;

        //Recupération de l'Id utilisateur
        private int getIdUser(string Pseudo)
        {
            context = new Model1Container();
            var result = from query in context.User
                         where query.Pseudonyme == Pseudo
                         select query.Id;

            if (result.Count() == 1)
                return result.First();
            else
                return 0;
        }

        //Récuperation du Pseudonyme
        private string getPseudoUser(int identification)
        {
            context = new Model1Container();
            var result = from q in context.User
                         where q.Id == identification
                         select q.Pseudonyme;
            if (result.Count() == 1)
                return result.First();
            return null;
        }

        //Récuperation de l'Id d'une note
        private int getIdNote(string title, int identification)
        {
            context = new Model1Container();

            var result = from q in context.Note
                         where q.Titre == title && q.UserId == identification
                         select q.Id;

            if (result.Count() == 1)
                return result.First();
            return 0;
        }

        //Savoir si l'utilisateur est connecté
        private bool Connected(int UserId)
        {
            context = new Model1Container();
            return context.User.Find(UserId).Connected;
        }


        /*
        // D'autre méthode
        */

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

       
    }
}
