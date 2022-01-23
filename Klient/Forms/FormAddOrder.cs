using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient.Forms
{
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
            MonthCalendarDataOddania.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
        }

       
    }
}
