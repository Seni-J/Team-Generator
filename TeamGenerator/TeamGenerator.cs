using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamGenerator
{
    public partial class TeamGenerator : Form
    {

        public TeamGenerator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstMembers.Items.Add(txtAddMember.Text);
            txtAddMember.Clear();
        }

        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            lstMembers.Items.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var members = lstMembers.Items.Cast<ListViewItem>().Select(item => item.Text).ToList();
            members.Melanger();
            int index = 0;
            foreach(var member in members)
            {
                if(index % 2 == 0)
                {
                    lstTeamOne.Items.Add(member);
                }
                else
                {
                    lstTeamTwo.Items.Add(member);
                }
                index++;
            }
        }

        private void txtAddMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstMembers.Items.Add(txtAddMember.Text);
                txtAddMember.Clear();
            }
        }

        private void btnTeamReset_Click(object sender, EventArgs e)
        {
            lstTeamOne.Clear();
            lstTeamTwo.Clear();
        }
    }
    public static class Shuffle
    {
        private static Random rng = new Random();

        public static void Melanger<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
