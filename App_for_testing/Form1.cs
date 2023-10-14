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
        List<Cafe> Cafes = new List<Cafe>(); //список дня неизвесткого заранее кол-ва кафе

        public Form1()
        {
            InitializeComponent();
        }

        //кнопка создания кафе
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

                //незаполненные поля (допустимо не вводить фио владельца)
                if ((stars*num_of_seats*curr_visitors* average_bill ==0)||(name=="")||(address==""))
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
                    MessageBox.Show("Количество посадочных мест, средний чек и число посетителей не могут быть меньше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    is_error = true;
                }

                if (num_of_seats - curr_visitors < 0)
                {
                    MessageBox.Show("Количество посадочных мест не может быть меньше, чем число посетителей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    is_error = true;
                }

                //уникальность названия
                for (int i = 0; i < Cafes.Count; i++)
                {
                    if (Cafes[i].Name == Convert.ToString(nameBox.Text))
                    {
                        is_error = true;
                        MessageBox.Show("Кафе с таким названием уже создано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //для метода изменения владельца
                if (owner == "")
                    owner = Convert.ToString(-1);

                //если все ок
                if (!is_error)
                {
                    Cafes.Add(new Cafe(name, address, owner, stars, num_of_seats, curr_visitors, average_bill));
                    MessageBox.Show("Объект типа Кафе создан", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //ошибка форматирования
            catch (FormatException)
            {
                MessageBox.Show("Неверно заполнена форма по созданию объекта. Проверте поля ввода.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //другие исключения
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка, попробуйте перезапустить программу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int index; //индекс конкретного кафе

        //кнопка измнения владельца
        private void ownButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false; //существование кафе
            bool is_error = false;

            //нахождение кафе в списке по имени
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            //кафе нет
            if (!do_exist)
            {
                MessageBox.Show("Кафе с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                is_error = true;
            }

            if (Convert.ToString(newownBox.Text) == "")
            { 
                MessageBox.Show("Поле с новым ФИО владельца не заполнено ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                is_error = true;
            }

            //если нет ошибки
            if (!is_error)
            {
                if (Cafes[index].create_owner(Convert.ToString(newownBox.Text)))
                    MessageBox.Show("ФИО владельца успешно изменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //если ФИО уже было
                else
                    MessageBox.Show("ФИО владельца этого кафе уже имеется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //кнопка изменения кол-ва звезд
        private void strButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false; //существование кафе
            bool is_error = false;

            //поиск кафе
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            //кафе нет
            if (!do_exist)
            {
                MessageBox.Show("Кафе с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                is_error = true;
            }

            //поле не заполнено или не int
            if ((Convert.ToString(newstarsBox.Text) == "")||(!int.TryParse(Convert.ToString(newstarsBox.Text),out int newstars)))
            {
                MessageBox.Show("Поле с новым количеством звезд не заполнено, либо введено не целое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                is_error = true;
            }

            if (!is_error)
            {
                if (Cafes[index].change_stars(Convert.ToInt32(newstarsBox.Text)))
                    MessageBox.Show("Количество звезд успешно изменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //если заданное число звезд некорректно
                else
                    MessageBox.Show("Изменить число звезд возможно только на +(-)1, причем число звезд должно быть больше или равно 0 и меньше или равно 5", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int index2; //индекс кафе для сравнения

        //кнопка сравнения кафе 
        private void vsButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false;
            bool do_exist2 = false;
            bool is_error = false;

            //поиск 2ух кафе в списке
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }

                if (Cafes[i].Name == Convert.ToString(vsBox.Text))
                {
                    index2 = i;
                    do_exist2 = true;
                }
            }

            if (!do_exist)
            {
                MessageBox.Show("Кафе с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                is_error = true;
            }

            if (!do_exist2)
            {
                MessageBox.Show("Кафе для сравнения с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                is_error = true;
            }

            if (Convert.ToString(vsBox.Text) == "")
            {
                MessageBox.Show("Название кафе для сравнения не введено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                is_error = true;
            }

            //если все ок
            if (!is_error)
            {
                string[] info = new string[3];
                info = Cafes[index].compare(Cafes[index2]); //получаем массив с результатами сравнения
                MessageBox.Show(info[0] + "\n"+ info[1] + "\n" + info[2], "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //кнопка получения информации о владельце
        private void infButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false;

            //поиск кафе
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            if (do_exist)
            {
                //владелец не задан
                if (Cafes[index].get_owner_info()== Convert.ToString(-1))
                    MessageBox.Show("Кафе никто не владеет", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("ФИО владельца: " + Cafes[index].get_owner_info(), "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Кафе с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //кнопка расчета выручки
        private void mnyButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false;

            //поиск кафе
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            if (do_exist)
                MessageBox.Show("Выручка на данный момент: " + Cafes[index].calc_revenue() + " руб.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Кафе с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //кнопка принятия заказа
        private void ordButton_Click(object sender, EventArgs e)
        {
            bool do_exist = false;

            //поиск кафе
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            if (do_exist)
            {
                if (Cafes[index].do_accept_order())
                    MessageBox.Show("Заказ успешно принят", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //свободных мест нет
                else
                    MessageBox.Show("К сожалению, сводобных мест в текущий моментнет нет и заказ не может быть принят", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Кафе с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //кнопка получения информации о кафе
        private void cafe_info_button_Click(object sender, EventArgs e)
        {
            bool do_exist = false;

            //поиск кафе
            for (int i = 0; i < Cafes.Count; i++)
            {
                if (Cafes[i].Name == Convert.ToString(pickedCafeBox.Text))
                {
                    index = i;
                    do_exist = true;
                }
            }

            if (do_exist)
            {
                string[] info = new string[8];
                info = Cafes[index].get_cafe_info(); //получение массива сведений о кафе
                MessageBox.Show(info[0] + "\n" + info[1] + "\n" + info[2] + "\n" + info[3] + "\n" + info[4] + "\n" + info[5] + "\n" + info[6] + "\n" + info[7], "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Кафе с таким названием не существует в программе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
