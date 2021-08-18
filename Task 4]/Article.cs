using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_
{
    class Article
    {
        private string title;
        public string Title
        {
            set => title = value;
            get => title;
        }
        private string magazine;
        public string Magazine
        {
            set => magazine = value;
            get => magazine;
        }
        private double prize;
        public double Prize
        {
            set => prize = value;
            get => prize;
        }

        public Article  (string title, string magazine, double prize)
        {
            this.title = title;
            this.magazine = magazine;
            this.prize = prize;
        }

    }
}
