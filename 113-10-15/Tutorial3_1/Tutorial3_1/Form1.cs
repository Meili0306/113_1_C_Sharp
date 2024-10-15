using System.Xml;

namespace Tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string output;

            output = "民國" + txtyear.Text + "年" + txtmonth.Text + "月" + txtday.Text + "日" + "星期" + txtDayofweek.Text;

            lblshow.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDayofweek.Text = "";
            txtday.Text = "";
            txtmonth.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
