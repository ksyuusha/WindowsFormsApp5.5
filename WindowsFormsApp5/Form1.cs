using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private double result = 0; // Хранит результат
        private string operation = ""; // Хранит операцию
        private bool isOperationPerformed = false; // Флаг, указывающий, была ли выполнена операция

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик для чисел
        private void Number_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || isOperationPerformed)
                textBoxResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBoxResult.Text += button.Text;
        }

        // Обработчик для операций
        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEqual.PerformClick(); // Если операция уже выполнена, используем результат
                operation = button.Text; // Запоминаем операцию
            }
            else
            {
                operation = button.Text; // Устанавливаем операцию
            }

            result = Double.Parse(textBoxResult.Text); // Получаем текущее значение
            isOperationPerformed = true; // Устанавливаем флаг
        }

        // Обработчик для равенства
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (result + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (result - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (result * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (result / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBoxResult.Text); // Сохраняем результат
            operation = ""; // Сбрасываем операцию
        }

        // Обработчик для очистки
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0"; // Сброс текста
            result = 0; // Сброс результата
            operation = ""; // Сброс операции
        }
    }
}
