using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToggleTestElementsVisibility(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ошибка: Поле имени пользователя не должно быть пустым.");
                return;
            }
            if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Ошибка: Имя пользователя должно содержать минимум 5 символов.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ошибка: Поле пароля не должно быть пустым.");
                return;
            }
            if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("Ошибка: Пароль должен содержать минимум 8 символов.");
                return;
            }

            ToggleRegistrationElementsVisibility(false);
            ToggleTestElementsVisibility(true);

            label5.Text = "Какой год считается началом Второй мировой войны?";
            label4.Text = "Кто написал роман 'Преступление и наказание'?";
            label6.Text = "Как называется самая высокая гора в мире?";
            label7.Text = "Какой химический элемент обозначается символом 'O'?";
            label8.Text = "Сколько континентов на Земле?";
            label9.Text = "Кто нарисовал 'Мону Лизу'?";
            label10.Text = "Какая планета известна как Красная планета?";
            label11.Text = "Какой язык программирования используется для создания веб-страниц?";
            label12.Text = "Как называется столица Франции?";
            label13.Text = "Кто является автором теории относительности?";
            label14.Text = "Какой океан является самым большим?";
            label15.Text = "Сколько часов в сутках?";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<TextBox, string> questionAnswers = new Dictionary<TextBox, string>
            {
                { textBox3, "1939" },
                { textBox4, "Фёдор Достоевский" },
                { textBox5, "Эверест" },
                { textBox6, "Кислород" },
                { textBox7, "7" },
                { textBox8, "Леонардо да Винчи" },
                { textBox9, "Марс" },
                { textBox10, "HTML" },
                { textBox11, "Париж" },
                { textBox12, "Альберт Эйнштейн" },
                { textBox13, "Тихий" },
                { textBox14, "24" }
            };

            int score = 0;
            foreach (var entry in questionAnswers)
            {
                if (entry.Key.Text.Trim().Equals(entry.Value, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }

            MessageBox.Show($"Вы набрали {score} из {questionAnswers.Count} баллов.", "Результат теста");
        }

        private void ToggleRegistrationElementsVisibility(bool isVisible)
        {
            textBox1.Visible = isVisible;
            textBox2.Visible = isVisible;
            button1.Visible = isVisible;
            label1.Visible = isVisible;
            label2.Visible = isVisible;
            label3.Visible = isVisible;
        }

        private void ToggleTestElementsVisibility(bool isVisible)
        {
            button2.Visible = isVisible;
            label5.Visible = isVisible;
            label4.Visible = isVisible;
            label6.Visible = isVisible;
            label7.Visible = isVisible;
            label8.Visible = isVisible;
            label9.Visible = isVisible;
            label10.Visible = isVisible;
            label11.Visible = isVisible;
            label12.Visible = isVisible;
            label13.Visible = isVisible;
            label14.Visible = isVisible;
            label15.Visible = isVisible;
            textBox3.Visible = isVisible;
            textBox4.Visible = isVisible;
            textBox5.Visible = isVisible;
            textBox6.Visible = isVisible;
            textBox7.Visible = isVisible;
            textBox8.Visible = isVisible;
            textBox9.Visible = isVisible;
            textBox10.Visible = isVisible;
            textBox11.Visible = isVisible;
            textBox12.Visible = isVisible;
            textBox13.Visible = isVisible;
            textBox14.Visible = isVisible;
        }
    }
}
