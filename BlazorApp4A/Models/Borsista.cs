namespace BlazorApp4A.Models
{
    public class Borsista : Studente
    {
        private decimal borsa;        

        public Borsista(string Nome, string Sezione,decimal Borsa) : base(Nome, Sezione)
        {
            borsa = Borsa;
        }

        public override void Diplomati()
        {
            base.Diplomati();
            borsa = 0;
        }


        public decimal Borsa
        {
            get { return borsa; }
            set { borsa = value; }
        }
    }
}
