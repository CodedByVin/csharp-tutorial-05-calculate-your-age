using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Return current date.
            DateTime todayDate = DateTime.Now;

            // Allow user input(birthdate).
            DateTime birthDate = datBirthDate.Value;

            // Subtracting one DateTime from another results in a TimeSpan data type.
            // You can access the time span as Days, Seconds, Hours, Minutes, etc.
            TimeSpan timeSpan = todayDate - birthDate;

            // (timeSpan.Days) -> returns the date difference in Days.
            // We divide the Days by 365 to convert them to age.
            int age = timeSpan.Days / 365;

            // Display output via textbox.
            txtAge.Text = "Your age is: " + age.ToString();
        }
    }
}
