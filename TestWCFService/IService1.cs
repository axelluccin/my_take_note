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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        int AddUser(string Pseudo, string Pass);

        [OperationContract]
        int Connection(string Pseudo, string Pass);

        [OperationContract]
        bool Disconnection(int identification);

        [OperationContract]
        int AddNote(string title, string note, int identification);

        [OperationContract]
        bool ModificationNote(int identification, string Titre, string Texte);

        [OperationContract]
        bool RemoveNote(int identification);

        [OperationContract]
        MyNote[] Notes(int identification);

        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";
        

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    public class MyNote
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public DateTime Modification { get; set; }
        public string Texte { get; set; }
    }
}
