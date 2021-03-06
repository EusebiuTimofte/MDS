﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.SongAlbumsRepository
{
    public class SongAlbumsRepository: ISongAlbumsRepository
    {
        public Context _context { get; set; }

        public SongAlbumsRepository(Context context)
        {
            _context = context;
        }

        public SongAlbum Create(SongAlbum SongAlbum)
        {
            var result = _context.Add<SongAlbum>(SongAlbum);
            _context.SaveChanges();
            return result.Entity;
        }

        public SongAlbum Get(int Id)
        {
            return _context.SongAlbums.SingleOrDefault(x => x.Id == Id);
        }

        public List<SongAlbum> GetAll()
        {
            return _context.SongAlbums.ToList();
        }

        public SongAlbum Update(SongAlbum SongAlbum)
        {
            _context.Entry(SongAlbum).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return SongAlbum;
        }

        public SongAlbum Delete(SongAlbum SongAlbum)
        {
            var result = _context.Remove(SongAlbum);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
