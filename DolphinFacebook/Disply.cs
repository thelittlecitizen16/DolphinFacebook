using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;

namespace DolphinFacebook
{
    public class Disply : IDisplay
    {
        public void DisplayWallPost(string wallPost)
        {
            Console.WriteLine(wallPost);     
        }
    }
}
