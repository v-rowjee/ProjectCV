using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class Experience
    {
        public string companyName { set; get; }
        public int dateFrom { set; get; }
        public int dateTo { set; get; }
        public string description { set; get; }

        public Experience(string companyName, int dateFrom, int dateTo, string description) : base()
        {
            this.companyName = companyName;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.description = description;
        }

        public Experience(string name)
        {
            this.companyName = name;
            this.dateFrom = 2022;
            this.dateTo = 2022;
            this.description = "Test Description";
        }

        public override string ToString()
        {
            if (dateFrom == dateTo)
                return $"{companyName} ( {dateFrom} )";
            else
                return $"{companyName} ( {dateFrom} - {dateTo} )";
        }
    }

    internal class ExperienceMenu : Menu
    {
        public List<Experience> experienceList { get; set; }

        public ExperienceMenu() : base()
        {
            experienceList = new List<Experience>();
        }

        public void Add(Experience e)
        {
            experienceList.Add(e);
        }

        public override void Display()
        {
            Console.Clear();
            Console.WriteLine("EXPERIENCE");
            for (int i = 0; i < experienceList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {experienceList[i].ToString()}");
            }
            Console.WriteLine($"{experienceList.Count + 1}. Go back");

        }

        public override void DetailsOf(int choice)
        {
            Console.WriteLine(experienceList[choice-1].description);
        }

        public override int GetSelection()
        {
            int choice = -1;

            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            while (choice < 1 || choice > experienceList.Count + 1)
            {
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());
            }

            return choice;
        }
    }
}
