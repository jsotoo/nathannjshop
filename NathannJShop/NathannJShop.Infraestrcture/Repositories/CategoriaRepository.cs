using NathannJShop.Core.Entities;
using NathannJShop.Core.Interfaces;
using NathannJShop.Infraestructure.Data;
using NathannJShop.Infraestructure.Repositories.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NathannJShop.Infraestructure.Repositories
{
    public class CategoriaRepository : EfCoreRepository<Categoria, NathannJShopContext>
    {

        private readonly NathannJShopContext _context;
        public CategoriaRepository(NathannJShopContext context) 
            : base(context)
        {
            _context = context;
        }
       
    }
}
