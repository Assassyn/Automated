using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static Automated.Types;

namespace Automated.API.Test.CSharp
{
    public sealed class HappyPathUsage
    {
        public HappyPathUsage()
        {

        }

        [Fact]
        public void ApiCheckCanCreateRequest()
        {
            IRequest request = ApiCheck
                .WithString("https://testwebhooks.com/c/Automated.ApiCheck")
                .WithMethod("POST")
                .WithPayload("{property:'test'}");

            Assert.NotNull(request);
        }
    }
}
