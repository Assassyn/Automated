// <copyright file="HappyPathUsage.cs" company="Picums">
// Copyright (c) Picums. All rights reserved.
// </copyright>

using Xunit;
using Xunit.Should;

namespace Automated.API.Test.CSharp
{
    public sealed class HappyPathUsage
    {
        public HappyPathUsage()
        {
        }

        [Fact]
        public void SampleCSharpUse()
        {
            var request = ApiCheck
                .WithString("https://testwebhooks.com/c/Automated.ApiCheck")
                .WithMethod("POST")
                .WithPayload("{property:'test'}");

            var response = request.Execute();

            Assert.Equal("200", response.HttpStatusCode);
        }
    }
}
