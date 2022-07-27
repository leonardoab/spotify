using Spotify.Domain.Album;
using Spotify.Domain.Album.Repository;
using Spotify.Repository.Database;
using Spotify.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Spotify.Repository.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(SpotifyContext context) : base(context)
        {

            
        }

        public async Task<IEnumerable<Album>> ObterTodosAlbuns()
        {
            return await this.Query.Include(x => x.Musicas).ToListAsync();
        }


    }
}
