using Spotify.Models.Fatory;

namespace Spotify.Models
{
    public class Banda
    {
        
        //public int id { get; set; }        
        public string Nome { get; set; }
        public string? Descricao { get; set; }

        public string Foto { get; set; }

        public IList<Album> Albums { get; set; }

        public void CreateAlbum(string nome, IList<Musica> musicas)
        {
            var album = AlbumFactory.Create(nome, musicas);
            this.Albums.Add(album);
        }

        public int QuantidadeAlbuns()
            => this.Albums.Count;

        public IEnumerable<Musica> ObterMusicas()
            => this.Albums.SelectMany(x => x.Musicas).AsEnumerable();



    }
}