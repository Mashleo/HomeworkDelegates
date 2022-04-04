using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Client
    {
        private string name;
        public Client(string name)
        {
            this.name = name;
        }
        public void NewNewsIsHere(object sender, NewsInfoEventArgs e)
        {
            Console.WriteLine($"{name}: have a new news in category {e.News}"); //знаю что консоль лучше не вставлять в библиотеке класса. но для красоты в нашем случае решил сделать
        }
    }
}
