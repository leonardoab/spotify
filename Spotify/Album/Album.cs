using Spotify.Cross.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Domain.Album
{
    public class Album : Entity<Guid>
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public string Nome { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public DateTime DataLancamento { get; set; }
        public string Backdrop { get; set; }
        public IList<Musica> Musicas { get; set; }
        
    }
}
