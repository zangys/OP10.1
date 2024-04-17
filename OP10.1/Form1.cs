using System;
using System.Windows.Forms;

namespace TrapezoidAreaCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateArea(double a, double b, double x)
        {
            // Преобразование угла из градусов в радианы
            double angleRadians = Math.PI * x / 180.0;

            // Нахождение высоты трапеции
            double height = Math.Sin(angleRadians) * (b - a);

            // Нахождение площадьи трапеции
            double area = (a + b) * height / 2;

            MessageBox.Show($"Площадь трапеции: {area}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(baseATextBox.Text);
                double b = double.Parse(baseBTextBox.Text);
                double x = double.Parse(angleTextBox.Text);

                if (a <= 0 || b <= 0 || x <= 0)
                {
                    MessageBox.Show("Пожалуйста, введите положительные значения для всех параметров.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CalculateArea(a, b, x);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
