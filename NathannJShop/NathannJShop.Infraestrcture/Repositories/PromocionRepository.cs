using NathannJShop.Core.Entities;
using NathannJShop.Core.Interfaces;
using NathannJShop.Infraestructure.Data;
using NathannJShop.Infraestructure.Repositories.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Infraestructure.Repositories
{
    public class PromocionRepository : EfCoreRepository<Promocion, NathannJShopContext>
    {
        private readonly NathannJShopContext _context;
        public PromocionRepository(NathannJShopContext context) : base(context)
        {
            _context = context;
        }
    }
}
