namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void btnshowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true; //�]�wvisible�ݩʬ���
            ptxfront.Visible = false;
        }
        //��ܼ��J�P����
        private void btnshowfront_Click(object sender, EventArgs e)
        {
            ptxfront.Visible = true;
            ptxback.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
