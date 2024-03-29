﻿using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Album;
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
    public class BandaRepository : Repository<Banda>, IBandaRepository
    {
        public BandaRepository(SpotifyContext context) : base(context)
        {


        }

        public async Task<IEnumerable<Banda>> ObterTodasBandas()
        {
            return await this.Query.Include(x => x.Albuns).ToListAsync();
        }
    }
}
