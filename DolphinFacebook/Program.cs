using System;

namespace DolphinFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayA displyA = new DisplayA();
            DisplayB displyB = new DisplayB();
            DisplayC displyC = new DisplayC();
            FacebookClientFactory facebookClientFactory = new FacebookClientFactory();

            var facebookClientA = facebookClientFactory.CreateClient(displyA);
            var facebookClientB = facebookClientFactory.CreateClient(displyB);
            var facebookClientC = facebookClientFactory.CreateClient(displyC);

            facebookClientB.Subscribe(facebookClientA);
            facebookClientC.Subscribe(facebookClientA);
            facebookClientA.WriteNewWallPost("Post");

            facebookClientB.Unsubscribe(facebookClientA);
            facebookClientA.WriteNewWallPost("Post");

            facebookClientC.Unsubscribe(facebookClientA);
        }
    }
}
