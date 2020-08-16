using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Common
{
    public class Parameter
    {
        public string Name { get; set; }
        public object Type { get; set; }
        public DbType Value { get; set; }
    }
}
