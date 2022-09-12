using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal abstract class Menu
    {
        public void Intro()
        {
            Console.WriteLine("INTRO");
            Console.WriteLine("Hi, I'm Ved Rowjee and I am currently an intern at Ceridian.\nI am also studying a Computer Science programme at the University of Mauritus.\n");
        }

        public virtual void Display()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Experience \n2. Education \n3. Skills \n4. Technological Skills \n5. Contact Details");
        }

        public virtual int GetSelection()
        {
            int choice = -1;

            Console.Write("Choice: ");
            int.TryParse(Console.ReadLine(), out choice);

            while (choice < 1 || choice > 5)
            {
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);
            }

            return choice;
        }

        public abstract void DetailsOf(int choice);
    }

    internal class MainMenu : Menu
    {
        public override void DetailsOf(int choice)
        {
            throw new NotImplementedException();
        }
    }

}
