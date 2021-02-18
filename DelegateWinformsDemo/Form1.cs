using DelegateWinformsDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateWinformsDemo
{
    //public delegate string PersonFormat(Person input);
    public partial class Form1 : Form
    {
        Func<Person, string> proc;
        public Form1()
        {
            InitializeComponent();
        }

        private void AssignToDelegate()
        {
            if (rbOption1.Checked)
                proc = Default;
            else if (rbOption2.Checked)
                proc = LastNameToUpper;
            else if (rbOption3.Checked)
                proc = FirstNameToLower;
            else if (rbOption4.Checked)
                proc = FullName;
        }
        public static string Default(Person input)
        {
            return input.ToString();
        }

        public static string LastNameToUpper(Person input)
        {
            return input.LastName.ToUpper();
        }

        public static string FirstNameToLower(Person input)
        {
            return input.FirstName.ToLower();
        }

        public static string FullName(Person input)
        {
            return input.FirstName + " " + input.LastName.ToUpper() + " age is: " + input.Age;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //lstPerson.DataSource = null;
            lstPerson.Items.Clear();

            foreach (Person person in People.GetPeople())
            {
                AssignToDelegate();
                lstPerson.Items.Add(person.ToString(proc));
            }
        }
    }
}
