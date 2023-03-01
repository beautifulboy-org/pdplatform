using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Platform.Utils
{
    public class TestConfig
    { 
        public DemoTest TestDemo { get; set; }
    }

    public class DemoTest
    {
        public string Name { get; set; }

        public string Age { get; set; }
    }
}
