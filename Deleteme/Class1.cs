using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestCore;
using TestCore.ResultReporting;

namespace Deleteme
{
    [FeatureId("Feature A")]
    [ProductId("Product")]
    [Category("some category")]
    public class Class1 : BaseTest
    {
        [TestId("Some test")]
        public void test()
        {
            
        }

        protected override string Release()
        {
            return "foobar";
        }
    }
}
