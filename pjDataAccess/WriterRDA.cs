using pjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pjDataAccess
{
    public class WriterRDA
    {
        private KitchenContext _context;
        public WriterRDA(KitchenContext context)
        {
            _context = context;
        }
        public List<Writer> GetAll()
        {
            return _context.Writers.ToList();
        }
        public Writer Get(int id)
        {
            Writer rw = _context.Writers.FirstOrDefault(e => e.id == id);
            return rw;
        }
    }
}
