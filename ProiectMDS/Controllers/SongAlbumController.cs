using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.SongAlbumsRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongAlbumController : ControllerBase
    {
        public ISongAlbumsRepository ISongAlbumsRepository { get; set; }

        public SongAlbumController(ISongAlbumsRepository repository)
        {
            ISongAlbumsRepository = repository;
        }

        // GET: api/SongAlbums
        [HttpGet]
        public ActionResult<IEnumerable<SongAlbum>> Get()
        {
            return ISongAlbumsRepository.GetAll();
        }

        // GET: api/SongAlbums/5
        [HttpGet("{id}")]
        public ActionResult<SongAlbum> Get(int id)
        {
            return ISongAlbumsRepository.Get(id);
        }

        // POST: api/SongAlbums
        [HttpPost]
        public SongAlbum Post(SongAlbumDTO value)
        {
            SongAlbum model = new SongAlbum()
            {
                SongId = value.SongId,
                AlbumId = value.AlbumId
            };
            return ISongAlbumsRepository.Create(model);

        }

        // PUT: api/SongAlbums/5
        [HttpPut("{id}")]
        public SongAlbum Put(int id, SongAlbumDTO value)
        {
            SongAlbum model = ISongAlbumsRepository.Get(id);
            if (value.SongId != 0)
            {
                model.SongId = value.SongId;
            }
            if (value.AlbumId != 0)
            {
                model.AlbumId = value.AlbumId;
            }
            return ISongAlbumsRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public SongAlbum Delete(int id)
        {
            SongAlbum model = ISongAlbumsRepository.Get(id);
            return ISongAlbumsRepository.Delete(model);
        }
    }
}
