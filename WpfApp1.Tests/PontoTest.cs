using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WpfApp1.Testes
{
    public class PontoTest
    {
        [Fact]
        public void DevePossuirXY()
        {
            var p = new Ponto(10,20);

            Assert.Equal(10, p.X);
            Assert.Equal(20, p.Y);
        }

    }
}
