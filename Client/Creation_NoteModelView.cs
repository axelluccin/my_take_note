using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;
using GalaSoft.MvvmLight;
using Client.NoteManagerService;
using System.Windows;

namespace Client
{
    internal class Creation_NoteModelView : ViewModelBase
    {
        private int userIdentification;
        private Window app;
        private PriseNoteViewModel psn;

        public Creation_NoteModelView(int userIdentification, Window app, PriseNoteViewModel psn)
        {
            this.userIdentification = userIdentification;
            this.app = app;
            this.psn = psn;
        }

        private ICommand _Validation;
        public ICommand Validation
        {
            get { return _Validation ?? (_Validation = new RelayCommand(ValidationExecute)); }
        }
        private void ValidationExecute()
        {
            IService1 context = new Service1Client();
            if (Texte != "" && Titre != "")
            {
                if(context.AddNote(Titre, Texte, userIdentification) == 0)
                {
                    MessageBox.Show("Problème Ajout Note de la base de données");
                }
                else
                {
                    psn.UpdateExecute();
                    app.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
        }

        private string _Texte;
        public string Texte { get { return _Texte; } set { _Texte = value; RaisePropertyChanged("Texte"); } }

        private string _Titre;
        public string Titre { get { return _Titre; } set { _Titre = value;  RaisePropertyChanged("Titre"); } }
    }
}