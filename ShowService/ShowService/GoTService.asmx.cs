using System;
using ShowService.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ShowService
{
    /// <summary>
    /// Summary description for GoTService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GoTService : System.Web.Services.WebService
    {
        public List<Character> People { get; set; }

        public GoTService()
        {
            People = new List<Character>();
            GetCharacters();
        }

        [WebMethod]
        public string Hello()
        {
            return "Hello Westeros!";
        }

        [WebMethod]
        public List<Character> GetAllCharacters()
        {
            return People;
        }
        [WebMethod]
        public List<Character> SearchByLastName(string lastName)
        {
            List<Character> matches;
            matches = new List<Character>();

            foreach (var person in People)
            {
                if (person.LastName.ToLower().StartsWith(lastName.ToLower()))
                {
                    matches.Add(person);
                }
            }

            return matches;
        }

        [WebMethod]
        public List<Character> SearchByFirstName(string firstName)
        {
            //implement this
            //case insensitive
            List<Character> matches;
            matches = new List<Character>();

            foreach (var person in People)
            {
                if (person.FirstName.ToLower().StartsWith(firstName.ToLower()))
                {
                    matches.Add(person);
                }
            }
            return matches;
        }

        private void GetCharacters()
        {
            //add more characters
            var john = new Character
            {
                FirstName = "John",
                LastName = "Snow",
                Job = ""
            };

            var bran = new Character
            {
                FirstName = "Brandon",
                LastName = "Stark",
                Job = ""
            };

            var arya = new Character
            {
                FirstName = "Arya",
                LastName = "Stark",
                Job = ""
            };

            var sansa = new Character
            {
                FirstName = "Sansa",
                LastName = "Stark",
                Job = ""
            };

            var rickon = new Character
            {
                FirstName = "Rickon",
                LastName = "Stark",
                Job = ""

            };

            var tyrion = new Character
            {
                FirstName = "Tyrion",
                LastName = "Lannister",
                Job = ""

            };

            var theon = new Character
            {
                FirstName = "Theon",
                LastName = "Greyjoy",
                Job = ""

            };

            People.Add(john);
            People.Add(bran);
            People.Add(arya);
            People.Add(sansa);
            People.Add(rickon);
            People.Add(tyrion);
            People.Add(theon);
        }
    }
}
