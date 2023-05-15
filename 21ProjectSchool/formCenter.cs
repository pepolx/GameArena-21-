namespace _21ProjectSchool
{
    public partial class formCenter : Form
    {
        public formCenter()
        {
            InitializeComponent();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            form21 form2 = new();
            form2.Show();
            this.Hide();
            
        }

        private void btn21Hover(object sender, EventArgs e)
        {
            lbl21Description.Visible = true;
        }

        private void btn21Leave(object sender, EventArgs e)
        {
            lbl21Description.Visible = false;
        }

        private void formsCenterLoad(object sender, EventArgs e)
        {
            
        }
    }
}