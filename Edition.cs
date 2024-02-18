using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Edition
    {
        private string nam;
        private string fam;
        private int year;

        public string Nam
        {
            get { return (nam != "") ? nam : "Неизвестный"; }
            set { nam = value; }
        }
        public string Fam
        {
            get { return (fam != "") ? fam : "Неизвестный"; }
            set { fam = value; }
        }
        public int Year
        {
            get { return year < 1800 || year > 2024 ? 0 : year; }
            set
            {
                year = value;
            }
        }
        public Edition() { }
        public Edition(string nam, string fam, int year)
        {
            this.Nam = nam;
            this.Fam = fam;
            this.Year = year;
        }
        public void Info()
        {
            Console.Write("Редактировать год: ");
            int edit = int.Parse(Console.ReadLine());
            Year = year + edit;
            Console.Write($"Редактированно: {Year} год");

        }
        public void ShowInfo()
        {
            Console.WriteLine($"\nИздание: {nam}\nИмя и Фамилию Автора Издания: {fam}\nГод Издания: {year}");
            Console.ReadLine();
        }
    }
}
