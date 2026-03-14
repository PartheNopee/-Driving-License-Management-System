using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDApp.People
{
    public partial class frmFindPerson : Form
    {
        public frmFindPerson()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, ctrlFindPerson1.PersonId);

        }

       
    }
}
