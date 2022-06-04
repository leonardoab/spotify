namespace Spotify.Models
{
    public class Banda
    {
        
        //public int id { get; set; }        
        public string Nome { get; set; }
        public string? Descricao { get; set; }

        public string Foto { get; set; }

        public IList<Album> Albuns  { get; set; }





    }
}