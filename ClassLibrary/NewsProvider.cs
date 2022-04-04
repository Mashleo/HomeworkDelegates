using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NewsProvider
    {
        public event EventHandler<NewsInfoEventArgs> NewNewsInfo;                //это евенты на которые подписываем людей
        public event EventHandler<NewsInfoEventArgs> NewSportNewsInfo;
        public event EventHandler<NewsInfoEventArgs> NewWeatherNewsInfo;
        public event EventHandler<NewsInfoEventArgs> NewAcidentNewsInfo;
        public event EventHandler<NewsInfoEventArgs> NewHumorNewsInfo;
        public void NewNews(string category)   //добавление новости
        {
            Console.WriteLine($"\n\t News site, have a new news - {category}\n"); //знаю что консоль лучше не вставлять в библиотеке класса. но для красоты в нашем случае решил сделать
            RaiseNewsInfo(category);
        }
        protected virtual void RaiseNewsInfo(string category)
        {
            if (category == "News")
            {
                EventHandler<NewsInfoEventArgs> newNewsInfo = NewNewsInfo; //генерация события
                if (newNewsInfo != null) //проверка подписчиков
                {
                    newNewsInfo(this, new NewsInfoEventArgs(category));
                }

            }
            else if (category == "Sport")
            {
                EventHandler<NewsInfoEventArgs> newNewsInfo = NewSportNewsInfo;
                if (newNewsInfo != null)
                {
                    newNewsInfo(this, new NewsInfoEventArgs(category));
                }

            }
            else if (category == "Weather")
            {
                EventHandler<NewsInfoEventArgs> newNewsInfo = NewWeatherNewsInfo;
                if (newNewsInfo != null)
                {
                    newNewsInfo(this, new NewsInfoEventArgs(category));
                }

            }
            else if (category == "Acident")
            {
                EventHandler<NewsInfoEventArgs> newNewsInfo = NewAcidentNewsInfo;
                if (newNewsInfo != null)
                {
                    newNewsInfo(this, new NewsInfoEventArgs(category));
                }

            }
            else if (category == "Humor")
            {
                EventHandler<NewsInfoEventArgs> newNewsInfo = NewHumorNewsInfo;
                if (newNewsInfo != null)
                {
                    newNewsInfo(this, new NewsInfoEventArgs(category));
                }

            }

        }
    }
}
