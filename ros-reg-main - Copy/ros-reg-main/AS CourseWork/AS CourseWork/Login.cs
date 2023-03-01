using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_CourseWork
{
    public partial class Login : Form
    {
        int PlayerCount = 0;
        public Login()
        {
            InitializeComponent();
            fillCombobox();
        }
        private void fillCombobox()
        {
            foreach(Player p in SaveAccounts.FetchPlayer())
            {
                comboLoginUsername.Items.Add(p.Username);
            }            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = SaveAccounts.FetchPlayer()[comboLoginUsername.SelectedIndex].Username;
            string password = txtLoginPassword.Text;

            int Index = 0;
            List<Player> everyPlayer = new List<Player>();
            everyPlayer = SaveAccounts.FetchPlayer();

            

            for (int i = 0; i < everyPlayer.Count(); i++)
            {
                if (everyPlayer[i].Username == username && everyPlayer[i].Password == password)
                {
                    MessageBox.Show("Welcome " + everyPlayer[i].Forename);
                    PlayerCount += 1;
                    Index = i;
                    AddPlayerLogin(everyPlayer, Index);
                    
                    break;
                    
                }
            }



        }

        private void AddPlayerLogin(List<Player> everyPlayer, int index)
        {
            
            
            lblPlayerOneLogin.Text = everyPlayer[index].Username;
            picPlayerOneLogin.Image = everyPlayer[index].Avatar;
            
            
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void comboNoOfPlayersSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
