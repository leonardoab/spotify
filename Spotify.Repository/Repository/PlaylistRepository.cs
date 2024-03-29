﻿using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Account;
using Spotify.Domain.Account.Repository;
using Spotify.Domain.Album;
using Spotify.Repository.Context;
using Spotify.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Repository.Repository
{
    public class PlaylistRepository : Repository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(SpotifyContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Playlist>> ObterTodasPlaylists()
        {
            return await this.Query.Include(x => x.Musicas).ToListAsync();
        }
    }
}
