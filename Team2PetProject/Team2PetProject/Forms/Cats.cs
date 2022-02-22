using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2PetProject
{
    public partial class Cats : Form
    {
        /// <summary>
        /// Класс описывает форму Cats 
        /// </summary>
        public Cats()
        {
            InitializeComponent();
        }

        //переменная для проверки индекса при поиске
        private int lastFoundIndex = -1;
        //на кнопке реализован поиск породы по названию в списке
        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            //перебор всех элементов в списке
            for (i = lastFoundIndex + 1; i < listBox1.Items.Count; i++)
            {
                //присвоение переменой значения с индексом
                var currVal = listBox1.Items[i].ToString();
                //IndexOf- возвращает индекс элемента с нуля первого вхождения указаного символа в пределах этого экзепляра
                //метод вернет -1 если ничего не найдено
                //StringComparison - правила сортировки для методов Compare u Equals
                //OrdinalIgnoreCase - правила обычной двоичной сортировки без учета регистра
                if (currVal.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) > -1)
                {
                    //выделяет найденый элемент
                    listBox1.SetSelected(i, true);
                    lastFoundIndex = i;
                    break;
                }
            }
            if (lastFoundIndex > -1 && i == listBox1.Items.Count)
            {
                for (i = 0; i <= lastFoundIndex; i++)
                {
                    var currVal = listBox1.Items[i].ToString();
                    if (currVal.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        listBox1.SetSelected(i, true);
                        lastFoundIndex = i;
                        break;
                    }
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text ==string.Empty)
            {
                textBox1.Text = "Поиск";
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font("Lucida Console", 10);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.Font = new Font("Lucida Console", 10);
            }
        }

        private void Cats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                button1_Click(button1, null);
            
        }
    }
}
