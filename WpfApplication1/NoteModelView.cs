using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    public class NoteModelView : ViewModelBase
    {
        #region Command

        private ICommand _SeConnecter;
        public ICommand SeConnecter
        {
            get { return _SeConnecter ?? (_SeConnecter = new RelayCommand(SeConnecterExecute)); }
        }

        private void SeConnecterExecute()
        {
            MessageError = "Erreur lors de la saisise";
        }
        #endregion

        #region Property

        //Pseudonyme
        string _Pseudo;
        public string Pseudo { get { return _Pseudo; } set { _Pseudo = value; RaisePropertyChanged("Pseudo"); } }

        //Message Erreur
        string _MessageError;
        public string MessageError { get { return _MessageError; } set { _MessageError = value; RaisePropertyChanged("MessageError"); } }

        #endregion
    }
}
