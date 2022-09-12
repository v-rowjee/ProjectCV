using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class SkillMenu
    {
        public List<string> skillList { get; set; }
        public SkillMenu() => skillList = new List<string>();
        public void Add(string skill) => skillList.Add(skill);

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("PERSONAL SKILLS");
            for (int i = 0; i < skillList.Count; i++)
                Console.WriteLine($"{i + 1}. {skillList[i]}");
            Console.WriteLine($"[ Press any key to go back ]");
            Console.ReadLine();
        }
    }

    internal class TechSkillMenu
    {
        public List<string> techSkillList;
        public TechSkillMenu() => techSkillList = new List<string>();
        public void Add(string skill) => techSkillList.Add(skill);

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("PERSONAL SKILLS");
            for (int i = 0; i < techSkillList.Count; i++)
                Console.WriteLine($"{i + 1}. {techSkillList[i]}");
            Console.WriteLine("[ Press any key to go back ]");
            Console.ReadLine();
        }
    }

    internal class ContactMenu
    {
        public int phone { get; set; }
        public List<string> emails { get; set; }
        public List<string> socials { get; set; }
        public ContactMenu()
        {
            emails = new List<string>();
            socials = new List<string>();
        }
        public void Add(int phone, List<string> emails, List<string> socials)
        {
            this.phone = phone;
            this.emails.AddRange(emails);
            this.socials.AddRange(socials);
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("CONTACT DETAILS");
            Console.WriteLine($"Phone: {phone}");
            Console.Write("Emails: ");
            for (int i = 0; i < emails.Count; i++)
            {
                Console.Write(emails[i] + ", ");
            }
            Console.WriteLine();
            Console.Write("Socials: ");
            for (int i = 0; i < socials.Count; i++)
            {
                Console.Write(socials[i] + ", ");
            }
            Console.WriteLine("\n[ Press any key to go back ]");
            Console.ReadLine();
        }

    }
}
