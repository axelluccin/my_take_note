using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.NoteManagerService;
using System.Windows;

namespace Client
{
    class Modification_NoteView : ViewModelBase
    {
        private int iD;

        private Modification_Note modif1;

        private string _texte;
        public string Texte { get { return _texte; } set { _texte = value; RaisePropertyChanged("Texte"); } }

        private string _titre;
        public string Titre { get { return _titre; } set { _titre = value;  RaisePropertyChanged("Titre"); } }

        
        public Modification_NoteView(int iD, string titre, string texte, Modification_Note modif1, PriseNoteViewModel priseNoteViewModel)
        {
            this.iD = iD;
            this.Titre = titre;
            this.Texte = texte;
            this.modif1 = modif1;
            this.priseNoteViewModel = priseNoteViewModel;
        }

        private ICommand _modif;
        private PriseNoteViewModel priseNoteViewModel;

        public ICommand modif
        {
            get { return _modif ?? (_modif = new RelayCommand(modifExecute)); }
        }

        private void modifExecute()
        {
            if(Texte != "" && Titre != "")
            {
                IService1 mod = new Service1Client();
                if(mod.ModificationNote(iD, Titre, Texte))
                {
                    priseNoteViewModel.UpdateExecute();
                    modif1.Close();
                }
                else
                {
                    MessageBox.Show("Erreur de Modification de la note");
                }
            }
        }
    }
}
