using Newtonsoft.Json;

namespace BlazorApp4A.Models
{
    public class Gruppo
    {
        private static string dataSourceString = @"Data/Source/gruppo.json";
        public List<Studente> StudenteList { get; set; } = new List<Studente>();
        public List<Borsista> BorsistaList { get; set; } = new List<Borsista>();

        public virtual void Serializza()
        {
            File.WriteAllText(dataSourceString, JsonConvert.SerializeObject(this));
        }

        public static Gruppo Deserializza()
        {
            Gruppo? x;
            x = JsonConvert.DeserializeObject<Gruppo>(File.ReadAllText(dataSourceString));
            return x;

        }
    }
}
