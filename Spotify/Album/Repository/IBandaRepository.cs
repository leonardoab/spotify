using Spotify.Cross.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Domain.Album.Repository
{
    public interface IBandaRepository : IRepository<Banda>
    {
        Task<IEnumerable<Banda>> ObterTodasBandas();
    }
}
