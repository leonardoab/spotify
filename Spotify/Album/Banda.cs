﻿using Spotify.Cross.Entity;
using Spotify.Domain.Album.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Domain.Album
{
    public class Banda : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string Descricao { get; set; }
        public IList<Album> Albuns { get; set; }

        public void CreateAlbum(string nome, IList<Musica> musicas)
        {
            var album = AlbumFactory.Create(nome, musicas);
            this.Albuns.Add(album); 
        }

        public int QuantidadeAlbuns() 
            => this.Albuns.Count;

        public IEnumerable<Musica> ObterMusicas()
            => this.Albuns.SelectMany(x => x.Musicas).AsEnumerable();

    }
}
