using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;

namespace DolphinFacebook  
{ 
    class DolphinsFacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;
        private IDisplay _disply;

        public DolphinsFacebookClient(IDisplay display)
        {
            _disply = display;

        }
        public void Subscribe(IFacebookClient publisher)
        {

            publisher.NewWallPost += _disply.DisplayWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= WriteNewWallPost;
        }

        public void WriteNewWallPost(string wallPost)

        {
            _disply.DisplayWallPost(wallPost);
            NewWallPost?.Invoke(wallPost);
        }
    }
}
