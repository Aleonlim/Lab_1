using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe_Lib;

namespace App_for_testing
{
    public partial class Form1 : Form
    {

        List<Cafe> Cafes = new List<Cafe>();





        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            bool is_error =false;
            try
            {
                string name = Convert.ToString(nameBox.Text);
                string address = Convert.ToString(addressBox.Text);
                string owner = Convert.ToString(ownerBox.Text);
                int stars = Convert.ToInt32(starsBox.Text);
                int num_of_seats = Convert.ToInt32(seatsBox.Text);
                int curr_visitors = Convert.ToInt32(visitorsBox.Text);
                float average_bill = Convert.ToSingle(billBox.Text);

                if ((stars*num_of_seats*curr_visitors* average_bill ==0)||(name=="")||(address=="")) // исключая фио владельца
                {
                    MessageBox.Show("Не все поля ввода заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    is_error = true;
                }

                if ((stars>5)||(stars<0))
                {
                    MessageBox.Show("Невозможное количество звезд", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    is_error = true;
                }

                if ((num_of_seats <0) || (curr_visitors < 0)||(average_bill < 0))
                {
                    MessageBox.Show("Количество звезд или посадочных мест и Число посетителей не могут быть меньше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    is_error = true;
                }

                if (owner == "")
                    owner = Convert.ToString(-1);

                if (!is_error)
                {
                    Cafes.Add(new Cafe(name, address, owner, stars, num_of_seats, curr_visitors, average_bill));
                    MessageBox.Show("Объект типа Кафе создан", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("Неверно заполнена форма по созданию объекта. Проверте поля ввода.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка, попробуйте перезапустить программу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


    }
}
