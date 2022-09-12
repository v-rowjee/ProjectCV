using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class Education
    {
        public string title { get; set; }
        public bool university { get; set; }

        public Education(string title, bool university)
        {
            this.title = title;
            this.university = university;
        }
    }

    internal class Training : Education
    {
        public int date { set; get; }
        public string overview { set; get; }

        public Training(string title, int date, string overview) : base(title,false)
        {
            this.title = title;
            this.date = date;
            this.overview = overview;
        }


        public override string ToString()
        {
            return $"{title} ( {date} )";
        }
    }

    internal class Course : Education
    {
        public int level { set; get; }
        public List<string> modules { set; get; }
        public List<string> projects { set; get; }

        public Course(string title, int level, List<string> modules, List<string> projects) : base(title,true)
        {
            this.title = title;
            this.level = level;
            this.modules = modules;
            this.projects = projects;
        }

        public override string ToString()
        {
            return $"{title} ( Year {level} )";
        }
    }

    internal class EducationMenu : Menu
    {
        public List<Training> trainingList { get; set; }
        public List<Course> courseList { get; set; }

        public EducationMenu() : base()
        {
            trainingList = new List<Training>();
            courseList = new List<Course>();
        }

        public void Add(Training t)
        {
            trainingList.Add(t);
        }

        public void Add(Course c)
        {
            courseList.Add(c);
        }

        public override void Display()
        {
            Console.Clear();
            Console.WriteLine("EDUCATION");
            for (int i = 0; i < courseList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {courseList[i]}");
            }
            for (int i= 0; i < trainingList.Count; i++)
            {
                Console.WriteLine($"{courseList.Count + i + 1}. {trainingList[i]}");
            }
            Console.WriteLine($"{courseList.Count + trainingList.Count + 1}. Go back");

        }

        public override void DetailsOf(int choice)
        {
            if(choice <= courseList.Count)
            {
                Console.Write("Modules: ");
                for (int i = 0; i < courseList[choice-1].modules.Count; i++)
                {
                    Console.Write($"{courseList[choice-1].modules[i]}, ");
                }
                Console.WriteLine("");
                Console.Write("Projects: ");
                for (int i = 0; i < courseList[choice-1].projects.Count; i++)
                {
                    Console.Write($"{courseList[choice-1].projects[i]}, ");
                }
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine($"Overview: {trainingList[choice-courseList.Count-1].overview}");
            }
        }

        public override int GetSelection()
        {
            int choice = -1;

            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            while (choice < 1 || choice > courseList.Count + trainingList.Count + 1)
            {
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());
            }

            return choice;
        }
    }
}
