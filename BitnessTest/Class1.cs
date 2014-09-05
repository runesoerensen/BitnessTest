using SharpSvn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BitnessTest
{
    public class Class1
    {
        [Fact]
        public void Foo()
        {
            var client = new SvnRepositoryClient();
            Assert.Equal(1, 1);
        }
    }
}
