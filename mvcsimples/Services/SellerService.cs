using mvcsimples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcsimples.Services
{
    public class SellerService
    {
        private readonly mvcsimplesContext _context;

        public SellerService(mvcsimplesContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
