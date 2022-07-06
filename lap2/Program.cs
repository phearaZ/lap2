using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise2
{
    class Movie
    {
        public string strTitle;
        public string strGenre;
        public int intYear;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie objMovie1;            //part (b) declare an object name of type movie
            objMovie1 = new Movie();    //part (c) instantiate the object objMovie1
            Console.Write("Title: ");
            objMovie1.strTitle = Console.ReadLine();
            Console.Write("Genre: ");
            objMovie1.strGenre = Console.ReadLine();
            Console.Write("year: ");
            objMovie1.intYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Movie is {0}, Genre is {1}, year at {2}", objMovie1.strTitle, objMovie1.strGenre, objMovie1.intYear);
        }
    }
}
