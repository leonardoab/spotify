using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Account;
using Spotify.Domain.Account.Repository;
using Spotify.Domain.Album.Repository;
using Spotify.Repository.Context;
using Spotify.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    internal class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(SpotifyContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Usuario>> ObterTodosUsuarios()
        {
            return await this.Query.Include(x => x.Playlists).ToListAsync();
        }
    }
}
