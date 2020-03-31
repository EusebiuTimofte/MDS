using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ArtistAlbumsRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistAlbumController : ControllerBase
    {
        public IArtistAlbumsRepository IArtistAlbumsRepository { get; set; }

        public ArtistAlbumController(IArtistAlbumsRepository repository)
        {
            IArtistAlbumsRepository = repository;
        }

        // GET: api/ArtistAlbums
        [HttpGet]
        public ActionResult<IEnumerable<ArtistAlbum>> Get()
        {
            return IArtistAlbumsRepository.GetAll();
        }

        // GET: api/ArtistAlbums/5
        [HttpGet("{id}")]
        public ActionResult<ArtistAlbum> Get(int id)
        {
            return IArtistAlbumsRepository.Get(id);
        }

        // POST: api/ArtistAlbums
        [HttpPost]
        public ArtistAlbum Post(AlbumArtistDTO value)
        {
            ArtistAlbum model = new ArtistAlbum()
            {
                ArtistId = value.ArtistId,
                AlbumId = value.AlbumId
            };
            return IArtistAlbumsRepository.Create(model);

        }

        // PUT: api/ArtistAlbums/5
        [HttpPut("{id}")]
        public ArtistAlbum Put(int id, AlbumArtistDTO value)
        {
            ArtistAlbum model = IArtistAlbumsRepository.Get(id);
            if (value.ArtistId != 0)
            {
                model.ArtistId = value.ArtistId;
            }
            if (value.AlbumId != 0)
            {
                model.AlbumId = value.AlbumId;
            }
            return IArtistAlbumsRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ArtistAlbum Delete(int id)
        {
            ArtistAlbum model = IArtistAlbumsRepository.Get(id);
            return IArtistAlbumsRepository.Delete(model);
        }
    }
}
