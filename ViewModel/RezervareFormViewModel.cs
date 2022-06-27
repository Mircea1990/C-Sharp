using Imobiliara.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cazari_Hotel.ViewModel
{
    public class RezervareFormViewModel : INotifyPropertyChanged
    {
        private long _id;
        public long ID
        {
            get { return _id; }
            set
            {
                if (_id == value)
                    return;
                _id = value;
            }
        }

        private string _nume;
        public string Nume
        {
            get { return _nume; }
            set
            {
                if (_nume == value)
                    return;
                _nume = value;
                OnPropertyChanged();
            }
        }

        private string _prenume;
        public string Prenume
        {
            get { return _prenume; }
            set
            {
                if (_prenume == value)
                    return;
                _prenume = value;
                OnPropertyChanged();
            }
        }

        private long _NrCamera;
        public long NrCamera
        {
            get { return _NrCamera; }
            set
            {
                if (_NrCamera == value)
                    return;
                _NrCamera = value;
                OnPropertyChanged();
            }
        }

        public BindingList<Rezervare> Rezervari { get; set; }

        public RezervareFormViewModel()
        {
            Rezervari = new BindingList<Rezervare>();
        }

        public void AddRezervari()
        {
            Rezervari.Add(new Rezervare(Nume, Prenume, NrCamera));
            Nume = Prenume = String.Empty;
            NrCamera = 0;

        }

        public void DeleteRezervare(Rezervare rezervare)
        {
            Rezervari.Remove(rezervare);
        }

 

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
