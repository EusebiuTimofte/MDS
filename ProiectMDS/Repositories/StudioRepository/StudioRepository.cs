using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.StudioRepository
{
    public class StudioRepository
    {
        public Context _context { get; set; }

        public StudioRepository(Context context)
        {
            _context = context;
        }

        public Studio Create(Studio Studio)
        {
            var result = _context.Add<Studio>(Studio);
            _context.SaveChanges();
            return result.Entity;
        }

        public Studio Get(int Id)
        {
            return _context.Studios.SingleOrDefault(x => x.Id == Id);
        }

        public List<Studio> GetAll()
        {
            return _context.Studios.ToList();
        }

        public Studio Update(Studio Studio)
        {
            _context.Entry(Studio).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Studio;
        }

        public Studio Delete(Studio Studio)
        {
            var result = _context.Remove(Studio);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
