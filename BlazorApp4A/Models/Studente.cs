namespace BlazorApp4A.Models
{
    public class Studente
    {
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
			
		}

		public string Sezione
		{
			get { return sezione; }
			
		}


		public byte Anno
		{
			get { return anno; }
		}


		public string Nome
		{
			get { return nome; }			
		}

	}
}
