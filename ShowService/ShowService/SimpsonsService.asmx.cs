using ShowService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ShowService
{
    /// <summary>
    /// Summary description for SimpsonsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SimpsonsService : System.Web.Services.WebService
    {
        public List<Character> People { get; set; }

        public SimpsonsService()
        {
            People = new List<Character>();
            GetCharacters();
        }

        [WebMethod]
        public string Hello()
        {
            return "Hello Springfield";
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

        [WebMethod]
        public List<Character> SearchByJob(string job)
        {
            //implement this
            //case insensitive
            List<Character> matches;
            matches = new List<Character>();

            foreach (var person in People)
            {
                if (person.Job.ToLower().StartsWith(job.ToLower()))
                {
                    matches.Add(person);
                }
            }
            return matches;
        }

        [WebMethod]
        public string CountNumberOfCharacters()
        {
            //implement this
            var i = 0;
            foreach (var person in People)
            {
                i++;
            }
            string total= i.ToString();
            return total;
        }

        private void GetCharacters()
        {
            //add more characters
            var homer = new Character
            {
                FirstName = "Homer",
                LastName = "Simpson",
                Job = "Nuclear safety inspector"
            };

            var marge = new Character
            {
                FirstName = "Marge",
                LastName = "Simpson",
                Job = "Mom"
            };

            var mo = new Character
            {
                FirstName = "Moe",
                LastName = "Szyslak",
                Job = "Bartender"
            };

            var barney = new Character
            {
                FirstName = "Barney",
                LastName = "Gumble",
                Job = "Belcher"
            };

            var lisa = new Character
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Job = "Brainiac"

            };

            var maggie = new Character
            {
                FirstName = "Maggie",
                LastName = "Simpson",
                Job = "Baby"

            };

            var burns = new Character
            {
                FirstName = "Mr",
                LastName = "Burns",
                Job = "Evil Boss"

            };

            People.Add(homer);
            People.Add(marge);
            People.Add(mo);
            People.Add(barney);
            People.Add(lisa);
            People.Add(maggie);
            People.Add(burns);
        }

    }
}
