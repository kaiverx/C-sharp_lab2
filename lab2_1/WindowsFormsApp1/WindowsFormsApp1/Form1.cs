using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            // Загружаем сохранённые значения из настроек
            firstNum.Text = Properties.Settings.Default.firstNum;
            secondNum.Text = Properties.Settings.Default.secondNum;
            thirdNum.Text = Properties.Settings.Default.thirdNum;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраняем введённые пользователем значения
            Properties.Settings.Default.firstNum = firstNum.Text;
            Properties.Settings.Default.secondNum = secondNum.Text;
            Properties.Settings.Default.thirdNum = thirdNum.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем числа из текстовых полей
                int first = int.Parse(firstNum.Text);
                int second = int.Parse(secondNum.Text);
                int third = int.Parse(thirdNum.Text);

                // Вызываем метод сортировки
                var (max, mid, min) = Logic.GetSorted(first, second, third);

                // Выводим результат
                MessageBox.Show($"Наибольшее: {max}, Среднее: {mid}, Наименьшее: {min}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные целые числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class Logic
    {
        public static (int max, int mid, int min) GetSorted(int first, int second, int third)
        {
            int[] numbers = { first, second, third };
            Array.Sort(numbers);
            return (numbers[2], numbers[1], numbers[0]);
        }
    }
}
