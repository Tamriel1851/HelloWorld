namespace Week06Worksheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberInputField_TextChanged(object sender, EventArgs e)
        {
            int[] numbers = new int[10]; 
            for (int i = 0; i < 10;  i++)
            {
                numbers[i] = ReadInt();
            }
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {


        }
    }
}