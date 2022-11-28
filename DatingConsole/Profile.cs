using System;

namespace DatingConsole
{
    class Profile
    {
        // Fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // Constructors
        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            string[] hobbies;
        }
    }
}