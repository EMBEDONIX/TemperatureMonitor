using System.Windows.Forms;
using MetroFramework.Forms;

namespace TempMonitor.Controls.Dialogs
{
    public partial class DialogForm : MetroForm
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        protected virtual void buttonApply_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        protected virtual void buttonCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
