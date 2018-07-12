using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.DAO
{
    public class Context : DbContext
    {
        public Context() : base("default")
        {
        }
    }
}
