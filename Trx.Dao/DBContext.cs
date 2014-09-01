using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trx.Dao
{
    public class BlogDBContext : DbContext 
    {
        public DbSet<Article> Articles { get; set; }
    }
}
