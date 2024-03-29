﻿using Spotify.Domain.Album;
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
    public class MusicaRepository : Repository<Musica>, IMusicaRepository
    {
        public MusicaRepository(SpotifyContext context) : base(context)
        {
        }
    }
}
