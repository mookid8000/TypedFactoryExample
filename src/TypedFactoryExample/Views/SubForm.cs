using System;
using System.Windows.Forms;

namespace TypedFactoryExample.Views
{
    public partial class SubForm : Form, ISubView
    {
        public SubForm()
        {
            InitializeComponent();

            base.Closed += delegate { Closed(); };

            Disposed += OnDisposed;
        }

        public new event Action Closed = delegate { };

        public event Action ClickHereButtonClicked = delegate { };

        public void Open()
        {
            ShowDialog();
        }

        public void SetText(string text)
        {
            label2.Text = text;
        }

        void OnDisposed(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(@"Yay, Disposed!

{0}", Environment.StackTrace), "Calm down - this is intentional :)");
        }

        void Button1Click(object sender, EventArgs e)
        {
            Close();
        }

        void Button2Click(object sender, EventArgs e)
        {
            ClickHereButtonClicked();
        }
    }
}
