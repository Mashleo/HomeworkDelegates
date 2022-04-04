using System;
using ClassLibrary;

namespace HomeworkDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsPortal = new NewsProvider();

            var alex = new Client("Alex");
            var oleg = new Client("Oleg");
            var leo = new Client("Leo");
            var nick = new Client("Nick");  //добавили 5 пользователей
            newsPortal.NewNewsInfo += alex.NewNewsIsHere;
            newsPortal.NewAcidentNewsInfo += alex.NewNewsIsHere;
            newsPortal.NewSportNewsInfo += alex.NewNewsIsHere;  //подписывем их на разные новости

            newsPortal.NewAcidentNewsInfo += oleg.NewNewsIsHere;
            newsPortal.NewHumorNewsInfo += oleg.NewNewsIsHere;
            newsPortal.NewNewsInfo += oleg.NewNewsIsHere;
            newsPortal.NewSportNewsInfo += oleg.NewNewsIsHere;

            newsPortal.NewWeatherNewsInfo += leo.NewNewsIsHere;
            newsPortal.NewNewsInfo += leo.NewNewsIsHere;

            newsPortal.NewHumorNewsInfo += nick.NewNewsIsHere;
            newsPortal.NewNewsInfo += nick.NewNewsIsHere;


            //Ну у меня такая реализауия, новость передаю тупо строкой с названием категории.  можно конечно отельный тип. у когторого поле будет определять категорию
            newsPortal.NewNews("News");// стригерило что есть новсть, все кто подписан на этот тип. оповестились
            newsPortal.NewNews("Sport");
            newsPortal.NewNews("Weather");
            newsPortal.NewNews("Acident");
          
            newsPortal.NewNews("Humor");

            newsPortal.NewHumorNewsInfo += alex.NewNewsIsHere;
            newsPortal.NewNews("Humor");
           
            newsPortal.NewHumorNewsInfo -= nick.NewNewsIsHere;
            newsPortal.NewNews("Humor");
            
            newsPortal.NewNews("News");

        }
    }
}
