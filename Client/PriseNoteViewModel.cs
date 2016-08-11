using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;
using Client.NoteManagerService;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Client
{
    internal class PriseNoteViewModel : ViewModelBase
    {
        private int userIdentification;
        private Window win;
        

        public PriseNoteViewModel(int userIdentification, Window win)
        {
            this.userIdentification = userIdentification;
            this.win = win;
            UpdateExecute();
        }

        private ICommand _CreatNote;
        public ICommand CreatNote
        {
            get { return _CreatNote ?? (_CreatNote = new RelayCommand(CreatNoteExecute)); }
        }

        private void CreatNoteExecute()
        {
            Creation_Note app = new Creation_Note ();
            app.DataContext = new Creation_NoteModelView(userIdentification, app, this);
            app.Show();
            UpdateExecute();
        }

        private ICommand _Deco;
        public ICommand Deco
        {
            get { return _Deco ?? (_Deco = new RelayCommand(DecoExecute)); }
        }

        private void DecoExecute()
        {
            IService1 d = new Service1Client();
            if (d.Disconnection(userIdentification))
            {
                win.Close();
            }
            else
            {
                MessageBox.Show("Problème de déconnexion");
            }
        }

        private ICommand _modif_note;
        public ICommand modif_note
        {
            get { return _modif_note ?? (_modif_note = new RelayCommand<MyNote>(modif_noteExecute)); }
        }

        private void modif_noteExecute(MyNote parameter)
        {
            Modification_Note modif = new Modification_Note();
            modif.DataContext = new Modification_NoteView(parameter.ID, parameter.Titre, parameter.Texte, modif, this);
            modif.Show();
            UpdateExecute();
        }

        private ICommand _sup_note;
        public ICommand sup_note
        {
            get { return _sup_note ?? (_sup_note = new RelayCommand<MyNote>(sup_noteExecute)); }
        }

        private void sup_noteExecute(MyNote parameter)
        {
            IService1 sup = new Service1Client();
            sup.RemoveNote(parameter.ID);
            UpdateExecute();
        }
        /*
        private ICommand _Update;
        public ICommand Update
        {
            get { return _Update ?? (_Update = new RelayCommand(UpdateExecute)); }
        }
        */
        public void UpdateExecute()
        {
            listNote.Clear();
            IService1 c = new Service1Client();
            MyNote[] m = c.Notes(this.userIdentification);
            for (int i = 0; i < m.Length; i++)
            {
                listNote.Add(m[i]);
            }
        }

        ObservableCollection<MyNote> _listNote = new ObservableCollection<MyNote>();
        public ObservableCollection<MyNote> listNote
        {
            get { return _listNote; }
            set { _listNote = value; RaisePropertyChanged("listNote"); }
        }
    }
}