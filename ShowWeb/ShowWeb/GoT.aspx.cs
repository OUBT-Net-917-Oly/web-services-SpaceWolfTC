using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpsonsWeb.GoTServiceReference;

namespace SimpsonsWeb
{
    public partial class Thrones : System.Web.UI.Page
    {
        private GoTServiceSoapClient _service;

        public Thrones()
        {
            _service = new GoTServiceSoapClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGetAll_Click(object sender, EventArgs e)
        {
            List<Character> characters = _service.GetAllCharacters().ToList();

            string names = "";

            foreach (var character in characters)
            {
                names = names + $"{character.FirstName} {character.LastName} <br>";
            }

            lblgotCharacter.Text = names;
        }

        protected void btnFindByLast_Click(object sender, EventArgs e)
        {
            List<Character> characters = _service.SearchByLastName(txtLastName.Text).ToList();

            string names = "";

            foreach (var character in characters)
            {
                names = names + $"{character.FirstName} {character.LastName} <br>";
            }

            lblgotLastMatch.Text = names;
        }

        protected void btnFindByFirst_Click(object sender, EventArgs e)
        {
            List<Character> characters = _service.SearchByFirstName(txtFirstName.Text).ToList();

            string names = "";

            foreach (var character in characters)
            {
                names = names + $"{character.FirstName} {character.LastName} <br>";
            }

            lblgotFirstMatch.Text = names;
        }
    }
}