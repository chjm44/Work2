using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            string str = dt.Year.ToString() + "년, " + dt.Month.ToString() + "월 " + dt.Day.ToString() + "일" ;
            MessageBox.Show(str, "선택날짜");
            form2 form2 = new form2();
            form2.Show();

        }

    }
}
