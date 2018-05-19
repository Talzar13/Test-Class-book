using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Chap18___Making_Your_Own_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ballRed = new Ball(5f, new Color(255,0,0));
            Ball ballGreen = new Ball(10f, new Color(0, 0, 255));
            Ball ballBlue = new Ball(15f, new Color( 0, 255, 0));

            #region MyRegion
            //for (float i = 2; i < 16f; i++)
            //{
            //    if (ballRed.GetSize() % i !=0)
            //    {
            //        ballRed.Throw();
            //    }
            //    else
            //    {
            //        ballRed.Pop();
            //    }
            //}


            //for (float i = 0; i < 16f; i++)
            //{
            //    if (ballGreen.GetSize() % i !=0)
            //    {
            //        ballGreen.Throw();
            //    }
            //    else
            //    {
            //        ballGreen.Pop();
            //    }
            //}


            //for (float i = 0; i < 16f; i++)
            //{
            //    if (ballBlue.GetSize() % i !=0)
            //    {
            //        ballBlue.Throw();
            //    }
            //    else
            //    {
            //        ballBlue.Pop();
            //    }
            //} 
            #endregion


            ballRed.Throw();
            ballRed.Throw();
            ballRed.Throw();
            ballRed.Throw();

            ballBlue.Throw();
            ballBlue.Pop();
            ballBlue.Throw();
            ballBlue.Throw();

            ballGreen.Throw();
            ballGreen.Throw();
            ballGreen.Throw();
            ballGreen.Throw();

            WriteLine($"The red ball was thrown {ballRed.TotalTimesThrown()} times");
            WriteLine($"The blue ball was thrown {ballBlue.TotalTimesThrown()} times.");
            WriteLine($"The green ball was thrown {ballGreen.TotalTimesThrown()} times.");




            Read();
        }






        static void TestingBookClass()
        {
            Book book = new Book("Harry Potter", "J.K. Rowling");
            Book book2 = new Book();
            Book book3 = new Book();


            book3 = book2; //This copies reference to book2, rather than creating a new object. 
            book.SetTitle("Harry Potter and the Half-blood Prince");
            book2.SetTitle("This Book Rocks!");
            book3.SetTitle("Nope This Book Rocks More!");

            book.AssignWordCountFromText("This Stucks");


            WriteLine(book.GetTitle());
            // The two books, (book2, book3) will have the same info as they point to the same reference. 
            WriteLine($"{book2.GetTitle()}");
            WriteLine($"{book3.GetTitle()}");
            WriteLine(book.AssignWordCountFromText("what"));
        }
    }
}
