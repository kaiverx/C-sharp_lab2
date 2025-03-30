using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                // Выводим результат в Label
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
