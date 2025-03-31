namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            // Загружаем сохранённые значения из настроек
            sstring.Text = Properties.Settings.Default.sstring;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраняем введённые пользователем значения
            Properties.Settings.Default.sstring = sstring.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = sstring.Text;
            double percent = Logic.Percent(sentence);
            MessageBox.Show($"Доля букв в предложении: {percent:F2}%");
        }

        private void sstring_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static double Percent(string sentence)
        {
            // Проверяем, если строка пуста
            if (string.IsNullOrEmpty(sentence))
            {
                return 0.0;
            }

            int letterCount = 0;

            foreach (char c in sentence)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                {
                    letterCount++;
                }
            }
            int totalCount = sentence.Length; 

            double percent = (double)letterCount / totalCount * 100;
            return percent;
        }
    }
}
