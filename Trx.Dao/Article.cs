using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trx.Dao
{
    public class Article
    {
        public Guid ArticleId { get; set; }
        public string ArticleContent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
