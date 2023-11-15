﻿

using Newtonsoft.Json;

namespace BlazorApp4A.Models
{
    public class Studente
    {
        private static string dataSourceString = @"Data/Source/studente.json";
        private string nome;
		private byte anno;
		private string sezione;
		private bool diplomato;

        public Studente(string Nome, string Sezione)
        {
			nome = Nome;
			sezione=Sezione;
			anno = 1;
			diplomato = false;
        }

        public void Promuovi()
		{
			anno++;
		}

		public virtual void Diplomati()
		{
			diplomato= true;
		}


		public bool Diplomato
		{
			get { return diplomato; }
			set { diplomato = value; }
			
		}

		public string Sezione
		{
			get { return sezione; }
			set { sezione = value; }
			
		}


		public byte Anno
		{
			get { return anno; }
			set { anno = value; }
		}


		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public void Serializza()
		{
            JsonSerializer mySerializer = new JsonSerializer();
            StreamWriter myStream = new StreamWriter(dataSourceString);
            mySerializer.Serialize(myStream, this);
            myStream.Close();
        }
        public static Studente Deserializza()
        {
			Studente? x;
            JsonSerializer mySerializer = new JsonSerializer();
            StreamReader myStream = new StreamReader(dataSourceString);
            x=mySerializer.Deserialize(myStream, typeof (Studente)) as Studente;
            myStream.Close();
			return x;
        }
    }
}
