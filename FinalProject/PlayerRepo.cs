using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PlayerRepo
    {
        public List<Players> Players = new List<Players>();
        private void buttonAddplayer_Click(object sender, EventArgs e)

        {
            Players.Add(firstNameBox.Text);
        }
             

    }
}
