using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MarioShopDbContext dbContext;
        public MarioShopDbContext Init()
        {
            if (dbContext == null)
            {
                dbContext = new MarioShopDbContext();
            }
            return dbContext;
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}