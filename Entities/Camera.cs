using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliara.Entities
{
    [Serializable]
    public class Camera : INotifyPropertyChanged
    {

        public long Id { get; set; }
        public long NrCamera { get; set; }
        public long Etaj { get; set; }

        public DateTime DataOcupata { get; set; }


        public Camera(long nr, long etaj, DateTime ocupata)
        {
            NrCamera = nr;
            Etaj = etaj;
            DataOcupata = ocupata;
        }  
        
        public Camera(long id, long nr, long etaj, DateTime ocupata) : this(nr, etaj, ocupata)
        {
            Id = id;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
