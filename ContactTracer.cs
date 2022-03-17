using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_ContactTracer
{
    public partial class FormContactTracer : Form
    {
        public FormContactTracer()
        {
            InitializeComponent();
        }

        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
