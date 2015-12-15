using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LpDumper
{
    public partial class Viewer : Form
    {
        public string VisualizerValue { get; set; }

        public Viewer()
        {
            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            DisplayVisuzlierBody();
        }

        private void DisplayVisuzlierBody()
        {
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.Location = new Point(0, 0);
            browser.MinimumSize = new Size(20, 20);
            browser.Name = "webBrowser1";
            browser.Size = new Size(656, 502);
            browser.TabIndex = 0;

            browser.DocumentText = VisualizerValue;

            this.Controls.Add(browser);
        }
    }
}