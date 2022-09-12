using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new MainMenu();
            menu.Intro();

            while(true)
            {
                menu.Display();
                int MenuSelection = menu.GetSelection();

                if (MenuSelection == 1)
                {
                    ExperienceMenu subMenu = new ExperienceMenu();
                    AddExperiences(subMenu); // just adding a bunch of hardcoded experiences

                    subMenu.Display();
                    int SubMenuSelection = subMenu.GetSelection();

                    while (SubMenuSelection != subMenu.experienceList.Count + 1) // while GoBack not selected
                    {
                        subMenu.DetailsOf(SubMenuSelection); // display desc of chosen experience
                        SubMenuSelection = subMenu.GetSelection();
                    }
                }
                else if (MenuSelection == 2)
                {
                    EducationMenu subMenu = new EducationMenu();
                    AddEducations(subMenu); // just adding a bunch of hardcoded educations

                    subMenu.Display();
                    int SubMenuSelection = subMenu.GetSelection();

                    while (SubMenuSelection != subMenu.courseList.Count + subMenu.trainingList.Count + 1) // while GoBack not selected
                    {
                        subMenu.DetailsOf(SubMenuSelection); // display desc of chosen education
                        SubMenuSelection = subMenu.GetSelection();
                    }
                }
                else if (MenuSelection == 3)
                {
                    SkillMenu subMenu = new SkillMenu();
                    AddSkills(subMenu);
                    subMenu.Display();
                }
                else if (MenuSelection == 4)
                {
                    TechSkillMenu subMenu = new TechSkillMenu();
                    AddTechSkills(subMenu);
                    subMenu.Display();
                }
                else if (MenuSelection == 5)
                {
                    ContactMenu subMenu = new ContactMenu();
                    AddContact(subMenu);
                    subMenu.Display();
                }

                Console.Clear();
            }
        }

        private static void AddContact(ContactMenu contact)
        {
            contact.Add(
                59749958,
                new List<string>() { "vedrowjee@gmail.com" , "ved2001@gmail.com" },
                new List<string>() { "linkedin.com/vedrowjee" }
            );      
        }

        private static void AddTechSkills(TechSkillMenu skill)
        {
            skill.Add("C#");
            skill.Add("Front-end");
        }

        private static void AddSkills(SkillMenu skill)
        {
            skill.Add("Problem-solving");
            skill.Add("Leadership");
        }

        private static void AddEducations(EducationMenu education)
        {
            Console.WriteLine("Im here");
            education.Add(new Training("Rosetta",2022,"Improvement in french"));
            education.Add(new Course("Computer Science", 1, new List<string>() { "Maths", "Database", "Programming" }, new List<string>() { "Railway management system" }));
        }

        private static void AddExperiences(ExperienceMenu experience)
        {
            experience.Add(new Experience("Ceridian",2022,2022,"Internship"));
            experience.Add(new Experience("Aloha",2021,2022,"Trainee at Aloha Company"));
            experience.Add(new Experience("Test"));
        }
    }
}
