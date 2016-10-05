using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;
using System;
using System.Windows.Controls;
using System.Collections;
using Client.NoteManagerService;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;

namespace Client
{
    public class NoteViewModel : ViewModelBase
    {
        #region Command_Mainwindow
        //se connecter
        private ICommand _SeConnecter;
        public ICommand SeConnecter
        {
            get { return _SeConnecter ?? (_SeConnecter = new RelayCommand<object>(SeConnecterExecute)); }
        }

        private void SeConnecterExecute(object parameter)
        {
            PasswordBox pass = parameter as PasswordBox;
            Service1Client app = new Service1Client();
            if (Pseudo != "")
            {
                //suremment rajouter une sécurité pour pouvoir se connecter au client lourd !
                UserIdentification = app.Connection(Pseudo, pass.Password);
                if (UserIdentification != 0)
                {
                    Prise_De_Note psn = new Prise_De_Note();
                    psn.DataContext = new PriseNoteViewModel(UserIdentification, psn);
                    psn.Show();
                    Application.Current.MainWindow.Close();
                }
                else
                {
                    MessageBox.Show("Mauvais Nom d'utilisateur ou mauvais mot de passe !");
                }
            }
        }
        #endregion

        #region Properties_Mainwindow
        private string _Pseudo = "";
        public string Pseudo { get { return _Pseudo; } set { _Pseudo = value; RaisePropertyChanged("Pseudo"); } }

        private int _UserIdentification;
        public int UserIdentification { get { return _UserIdentification; } set { _UserIdentification = value; RaisePropertyChanged("UserIdentification"); } }
        #endregion
    }
}
