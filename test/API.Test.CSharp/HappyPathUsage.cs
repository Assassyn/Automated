/// <copyright file="HappyPathUsage.cs" company="Automated">
///     Automated. All rights reserved.
/// </copyright>
/// <author>Szymon M Sasin</author>

using Xunit;

namespace Automated.API.Test.CSharp
{
    public sealed class HappyPathUsage
    {
        public HappyPathUsage()
        {
        }

        [Theory]
        [InlineData("")]
        public void SampleCSharpUsse(string method)
        {
            var request = ApiCheck
                .WithString("https://testwebhooks.com/c/Automated.ApiCheck")
                .WithMethod("POST")
                .WithPayload("{property:'test'}");
        }
    }
}
