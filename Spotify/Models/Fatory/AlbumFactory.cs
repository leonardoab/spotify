namespace Spotify.Models.Fatory
{
    public class AlbumFactory
    {
        public static Album Create(string nome, Musica musica) {

            return new Album()
            {
                Musicas = new List<Musica>() { musica }

            };
        
        }

    }
}
