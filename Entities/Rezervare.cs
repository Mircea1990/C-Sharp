namespace Imobiliara.Entities
{
    [Serializable]
    public class Rezervare
    {

        public long ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public long NrCamera { get; set; }

        public Rezervare(string nume, string prenume, long camera)
        {
            
            Nume = nume;
            Prenume = prenume;
            NrCamera = camera;
        }

        public Rezervare(long id, string numeSolicitant, string prenumeSolicitant, long cameraSolicitata):
            this(numeSolicitant, prenumeSolicitant, cameraSolicitata)
        {
            ID = id;
        }

    }
}
