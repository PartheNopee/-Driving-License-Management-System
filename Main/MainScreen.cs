using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBusinessLayerDVLD;
using DVLDApp.Applications.DetainLicense;
using DVLDApp.Applications.IntertnationalLicenseApplication;
using DVLDApp.Applications.ReleaseDetainedLicense;
using DVLDApp.Applications.RenewLicense;
using DVLDApp.Applications.ReplaceForLostOrDamaged;
using DVLDApp.Drivers;

namespace DVLDApp
{
    public partial class MainScreen : Form
    {
        private int childFormNumber = 0;

        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

      

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Frm = new ManagePeople();
            Frm.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ManageUsers();
            frm.ShowDialog();

        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new FrmUserInfoScreen(GlobalClass.CurrentUser.UserID);   
           frm2.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Frm3 = new ChangePasswordScreen(GlobalClass.CurrentUser.UserID);
            Frm3.ShowDialog();

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            GlobalClass.CurrentUser = null;
            Form frm = new LoginScreen();

            frm.ShowDialog();
            

        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageAppTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Form frm = new ManageAppTypes();
              frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm7 = new ManageTestTypes();
            frm7.ShowDialog();

        }

        private void localDriverLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageLocalDriverApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm5 = new ManageLocalApplications();
            frm5.ShowDialog();

        }

        private void localDriverLicenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm8 = new NewLocalLicenseDriverApp();
            frm8.ShowDialog();

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form DriverFrm = new ManageDriversFrm();
            DriverFrm.ShowDialog();
        }

        private void manageInternationalDriverApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InternationalApplications = new ManageInternationalDriverLicensesfrm();
            InternationalApplications.ShowDialog();


        }

        private void internationalDriverLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form InternationalLicense = new NewInternationalLicenseApplication();
            InternationalLicense.ShowDialog();
        }

        private void renewDriverLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmrRenewLicense frm = new frmrRenewLicense();  
            frm.ShowDialog();
        }

        private void replacementForLostOrDamagedDriverLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceForDamageOrLostFrm Frm = new ReplaceForDamageOrLostFrm();
            Frm.ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void releaseDetainedDriverLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFrm frm = new ReleaseDetainedLicenseFrm();
            frm.ShowDialog();
        }

        private void listDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDetainedLicenses frm3 = new ListDetainedLicenses();  
            frm3.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicensseFrm DetainFrm = new DetainLicensseFrm();
            DetainFrm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFrm ReleaseFrm = new ReleaseDetainedLicenseFrm();
            ReleaseFrm.ShowDialog();
        }
    }
}
