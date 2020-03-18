using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ArtistRepository
{
    public interface IArtistRepository
    {
        List<Artist> GetAll();
        Artist Get(int Id);
        Artist Create(Artist artist);
        Artist Update(Artist artist);
        Artist Delete(Artist artist);
    }
}
