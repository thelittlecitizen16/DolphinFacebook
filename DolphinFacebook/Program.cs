using System;

namespace DolphinFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Disply disply = new Disply();
            FacebookClientFactory facebookClientFactory = new FacebookClientFactory();
            var facebookClientA = facebookClientFactory.CreateClient(disply);
            var facebookClientB = facebookClientFactory.CreateClient(disply);
            facebookClientB.Subscribe(facebookClientA);

            facebookClientA.WriteNewWallPost("Post");
        }
    }
}
