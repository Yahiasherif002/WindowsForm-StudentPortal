namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lacity_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string age = txtage.Text;
            string course = checkedListCourses.SelectedItem.ToString();
            if (checkedListCourses.CheckedItems.Count > 1)
            {
                string t = "";
                foreach (var item in checkedListCourses.CheckedItems)
                {
                    t += item.ToString() + " ";
                }
                MessageBox.Show("Hello " + name +"\n" +"your age is:" + age +"\n" +"you selected this courses :" + t);
           
            } else
                {
                    MessageBox.Show($"Hello {name} your age is: {age} you selected this course : {course}");
                }


        }
    } }
