namespace LP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������
            using (ApplicationContext db = new ApplicationContext())
            {
                // �������� ������� �� �� � ������� �� �������
                var users = db.Users.ToList();
                label1.Text = "������ �������������:";

                foreach (User u in users)
                {
                    labelInfAboutUser.Text += ($"{u.Id}. {u.Name} - {u.Age}\n");
                }
            }
        }
    }
}
