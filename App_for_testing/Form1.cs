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
                //соответствие типам ? продолжим : catch
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
                    MessageBox.Show("Количество посадочных мест, средний чек и число посетителей не могут быть меньше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    is_error = true;
                }

                for (int i = 0; i < Cafes.Count; i++)
                {
                    if (Cafes[i].Name == Convert.ToString(nameBox.Text))
                    {
                        is_error = true;
                        MessageBox.Show("Кафе с таким названием уже создано.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (owner == "")
                    owner = Convert.ToString(-1);

                if (!is_error) //если все ок
                {
                    Cafes.Add(new Cafe(name, address, owner, stars, num_of_seats, curr_visitors, average_bill));
                    MessageBox.Show("Объект типа Кафе создан", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(FormatException) //ошибка форматирования
            {
                MessageBox.Show("Неверно заполнена форма по созданию объекта. Проверте поля ввода.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception) //другие исключения
            {
                MessageBox.Show("Возникла ошибка, попробуйте перезапустить программу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        int index;
        private void ownButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false;
            
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name==Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            if (!do_exist)
                MessageBox.Show("Кафе с названием "+ Convert.ToString(pickedCafeBox.Text) + " не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Convert.ToString(newownBox.Text)=="")
                MessageBox.Show("Поле с новым ФИО владельца не заполнено ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


            if ((do_exist) && (Convert.ToString(newownBox.Text) != ""))
            {
                if (Cafes[index].get_owner_info() != Convert.ToString(-1))
                    MessageBox.Show("ФИО владельца этого кафе уже имеется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                Cafes[index].create_owner(Convert.ToString(newownBox.Text));
                MessageBox.Show("ФИО владельца успешно изменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void strButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false;
            bool is_error = false;

            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            if (!do_exist)
            {
                MessageBox.Show("Кафе с названием " + Convert.ToString(pickedCafeBox.Text) + " не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                is_error = true;
            }
            if ((Convert.ToString(newstarsBox.Text) == "")||(!int.TryParse(Convert.ToString(newstarsBox.Text),out int newstars)))
            {
                MessageBox.Show("Поле с новым количеством звезд не заполнено, либо введено не целое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                is_error = true;
            }

            if (!is_error)
            {
                if (Cafes[index].change_stars(Convert.ToInt32(newstarsBox.Text)))
                    MessageBox.Show("Количество звезд успешно изменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Изменить число звезд возможно только на +(-)1, причем число звезд должно быть больше или равно 0 и меньше или равно 5", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
