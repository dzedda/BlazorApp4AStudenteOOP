using Newtonsoft.Json;

namespace BlazorApp4A.Models
{
    public class Borsista : Studente
    {
        private static string dataSourceString = @"Data/Source/borsista.json";
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

        public override void Serializza()
        {
            File.WriteAllText(dataSourceString, JsonConvert.SerializeObject(this));
        }
        public static new Borsista Deserializza()
        {
            Borsista? x;
            x = JsonConvert.DeserializeObject<Borsista>(File.ReadAllText(dataSourceString));
            return x;

        }
    }
}
