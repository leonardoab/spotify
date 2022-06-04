namespace Spotify.Models
{
    public class Album
    {
        
        //public int id { get; set; }
        //public int idBanda { get; set; }
        public string Nome { get; set; }
        
        public DateTime DataLancamento { get; set; }

        public IList<Musica> Musicas { get; set; }




    }
}