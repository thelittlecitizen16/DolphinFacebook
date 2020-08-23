using System;

namespace DolphinFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayA displayA = new DisplayA();
            DisplayB displayB = new DisplayB();
            DisplayC displayC = new DisplayC();
            FacebookClientFactory facebookClientFactory = new FacebookClientFactory();

            var facebookClientA = facebookClientFactory.CreateClient(displayA);
            var facebookClientB = facebookClientFactory.CreateClient(displayB);
            var facebookClientC = facebookClientFactory.CreateClient(displayC);

            facebookClientB.Subscribe(facebookClientA);
            facebookClientC.Subscribe(facebookClientA);
            facebookClientA.WriteNewWallPost("Post");

            facebookClientB.Unsubscribe(facebookClientA);
            facebookClientA.WriteNewWallPost("Post");

            facebookClientC.Unsubscribe(facebookClientA);
        }
    }
}
