using mvcsimples.Models;
using mvcsimples.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcsimples.Data
{
    public class SeedingService 
    {
        private mvcsimplesContext _context;

        public SeedingService(mvcsimplesContext context)
        {
            _context = context;
        }
        public void seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any()||
                _context.SalesRecords.Any())
            {
                return; //Testa se o banco já foi criado
            }
            // precisei deixar o identity_insert ON  para inserir dados na base
            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletrônicos");
           
            Seller s1 = new Seller(1, "teste","email", new DateTime(1998,4,21), 1000.00, d1);
           
            SalesRecord sr1 = new SalesRecord(1, new DateTime(1998, 4, 1), 10000.0, SaleStatus.Billed, s1);
           
            _context.Department.AddRange(d1, d2);
           
            _context.Seller.AddRange(s1);
           
            _context.SalesRecords.AddRange(sr1);
           
            _context.SaveChanges();

        }
    }
}
