namespace aplikasigame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            freefire form = new freefire ();
            form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valo form = new valo();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cod form = new cod();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ml form = new ml();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Genshin form = new Genshin();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            honkai form = new honkai();
            form.ShowDialog();
        }
    }
}
