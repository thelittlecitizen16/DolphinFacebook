﻿using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;
namespace DolphinFacebook
{
    public class FacebookClientFactory : IFacebookClientFactory
    {
        public IFacebookClient CreateClient(IDisplay display)
        {
            return new DolphinsFacebookClient(display);
        }
    }
}
