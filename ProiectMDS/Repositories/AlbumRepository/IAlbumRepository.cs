using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.AlbumRepository
{
    public interface IAlbumRepository
    {
        List<Album> GetAll();
        Album Get(int Id);
        Album Create(Album album);
        Album Update(Album album);
        Album Delete(Album album);

    }
}
