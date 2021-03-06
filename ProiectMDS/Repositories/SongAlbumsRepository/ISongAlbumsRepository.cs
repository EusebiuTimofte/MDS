﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.SongAlbumsRepository
{
    public interface ISongAlbumsRepository
    {
        List<SongAlbum> GetAll();
        SongAlbum Get(int Id);
        SongAlbum Create(SongAlbum SongAlbum);
        SongAlbum Update(SongAlbum SongAlbum);
        SongAlbum Delete(SongAlbum SongAlbum);
    }
}
