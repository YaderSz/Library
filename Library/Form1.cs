namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            frmAutor fre = new frmAutor();  
            fre.ShowDialog();
        }
    }
}