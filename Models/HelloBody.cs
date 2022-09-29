using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HelloBody
    {
        public HelloBody(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
