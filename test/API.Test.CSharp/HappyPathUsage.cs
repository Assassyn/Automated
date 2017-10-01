// <copyright file="HappyPathUsage.cs" company="Picums">
// Copyright (c) Picums. All rights reserved.
// </copyright>

using Xunit;

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
            ApiCheck
                .WithString("https://testwebhooks.com/c/Automated.ApiCheck")
                .WithMethod("POST")
                .WithPayload("{property:'test'}");
        }
    }
}
