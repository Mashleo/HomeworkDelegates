using System;

namespace ClassLibrary
{
    public class NewsInfoEventArgs : EventArgs    
    {
        public NewsInfoEventArgs(string news)
        {
            this.News = news;
        }
        public string News { get; private set; }

    }
}
