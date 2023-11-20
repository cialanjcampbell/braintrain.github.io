using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNea
{
    public partial class FmRenameTopic : Form
    {
        public string newTopicName { get; private set; }
        public FmRenameTopic()
        {
            InitializeComponent();
        }
        private void RbConfirm_Click(object sender, EventArgs e)
        {
            newTopicName = newNameTxtBox.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void RbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
