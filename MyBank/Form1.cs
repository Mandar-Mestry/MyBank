using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.InitData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            string search = txtSearch.Text;

            //Perform LINQ Query
            var results = from person in Database.people
                          join owner in Database.owners on person.PersonId equals owner.PersonID
                          join account in Database.accounts on owner.AccountNumber equals account.AccountNumber
                          where person.Name.Contains(search)
                          select new { person.Name, account.AccountNumber, account.Balance };

            // fill the list box
            foreach (var result in results)
            {
                lstResult.Items.Add(result.ToString());
            }
        }
    }
}
