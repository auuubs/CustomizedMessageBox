using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
            btnOkay.Focus();
        }

        static Warning MsgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string Caption)
        {
            MsgBox = new Warning();
            MsgBox.lblMessage.Text = Text;
            MsgBox.lblTitle.Text = Caption;
            //MsgBox.btnOkay.Text = btnOK;
            //MsgBox.btnCancel.Text = btnCancel;
            MsgBox.ShowDialog();
            return result;

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }
    }
}
