using System;
using System.Windows.Forms;

namespace TypedFactoryExample.Views
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();

            base.Closed += delegate { Closed(); };
        }

        public event Action ShowSubFormClicked = delegate { };

        public new event Action Closed = delegate { };

        public void Open()
        {
            // MainForm is special because it blocks until closed...
            Application.Run(this);
        }

        void LinkLabelShowSubFormLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowSubFormClicked();
        }
    }
}
