using clsBusinessLayerDVLD;
using System;
 using System.Windows.Forms;
using Tita = System.Windows.Forms.MessageBox;
namespace DVLDApp
{
    public partial class UpdateTestTypes : Form
    {


        clstestTypesBLL.enTestType _TestID = clstestTypesBLL.enTestType.visionTest;
        clstestTypesBLL TestTypes;
        public UpdateTestTypes(clstestTypesBLL.enTestType TestID)
        {
            InitializeComponent();
            _TestID = TestID;
        }
        private void _LoadTest()
        {
            TestTypes = clstestTypesBLL.FindTest(_TestID);


            if (TestTypes != null)
            {
                LbID.Text = _TestID.ToString();
                txtTitle.Text = TestTypes.TestTitle;
                txtDescr.Text = TestTypes.TestDescription;
                txtFee.Text = TestTypes.FeesTest.ToString();
            }
            else
            {
                Tita.Show("Test Test You chose is inavailble. Please choose another one", "Error message !", MessageBoxButtons.OKCancel);
                this.Close();
            }


        }

        private void UpdateTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTest();
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TestTypes.TestTitle = txtTitle.Text;
            TestTypes.TestDescription = txtDescr.Text;
            TestTypes.FeesTest = Convert.ToDecimal(txtFee.Text);

            if (TestTypes.UpdateTest())
            {
                 Tita.Show(" test updated succesfully!");
                _LoadTest();


            }
            else
                Tita.Show("Invalid Operation please try again in a moment!");
                
        }
    }
}
