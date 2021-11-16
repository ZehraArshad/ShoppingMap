using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        int milk_500 = 60;
        int egg_1dozen = 120;
        int bread_1pack = 35;
        int sugar_500 = 110;
        int ghee_500 = 90;
        int oil_500 = 85;
        int flour_500 = 250;
        int chip_1pack = 50;
        int cookie_1pack = 50;
        int beans_500 = 70;
        //int washing_1bottle = 150;
        int dish_1bottle = 140;
        int fruits_500 = 40;
        int vegies_500 = 35;
        int wheat_500 = 250;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void cb_for_milk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_milk.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_milk.SelectedItem);
                listBox2.Items.Add(milk_500);
            }
            if (cb_for_milk.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_milk.SelectedItem);
                listBox2.Items.Add(milk_500 * 2);
            }

        }

        private void cb_for_egg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_egg.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_egg.SelectedItem);
                listBox2.Items.Add(egg_1dozen);
            }
            if (cb_for_egg.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_egg.SelectedItem);
                listBox2.Items.Add(egg_1dozen * 2);
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 0)
            {
                listBox1.Items.Add(comboBox7.SelectedItem);
                listBox2.Items.Add(bread_1pack);
                
            }
            if (comboBox7.SelectedIndex == 1)
            {
                listBox1.Items.Add(comboBox7.SelectedItem);
                listBox2.Items.Add(bread_1pack * 2);
            }



        }
        private void cb_for_sugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_sugar.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_sugar.SelectedItem);
                listBox2.Items.Add(sugar_500);
            }
            if (cb_for_sugar.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_sugar.SelectedItem);
                listBox2.Items.Add(sugar_500 * 2);
            }

        }

        private void cb_for_ghee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_ghee.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_ghee.SelectedItem);
                listBox2.Items.Add(ghee_500);
            }
            if (cb_for_ghee.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_ghee.SelectedItem);
                listBox2.Items.Add(ghee_500 * 5);
            }

        }

        private void cb_for_oil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_oil.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_oil.SelectedItem);
                listBox2.Items.Add(oil_500);
            }
            if (cb_for_oil.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_oil.SelectedItem);
                listBox2.Items.Add(oil_500 * 5);
            }

        }

        private void cb_for_wheat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_wheat.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_wheat.SelectedItem);
                listBox2.Items.Add(wheat_500);
            }
            if (cb_for_wheat.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_wheat.SelectedItem);
                listBox2.Items.Add(wheat_500 * 2);
            }

        }

        private void cb_for_beans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_beans.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_beans.SelectedItem);
                listBox2.Items.Add(beans_500);
            }
            if (cb_for_beans.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_beans.SelectedItem);
                listBox2.Items.Add(beans_500 * 2);
            }

        }

        private void cb_for_dishwasher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_dishwasher.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_dishwasher.SelectedItem);
                listBox2.Items.Add(dish_1bottle );


            }
            if (cb_for_dishwasher.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_dishwasher.SelectedItem);
                listBox2.Items.Add(dish_1bottle * 2);
            }
        }

        private void cb_for_chips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_chips.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_chips.SelectedItem);
                listBox2.Items.Add(chip_1pack);
            }
            if (cb_for_chips.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_chips.SelectedItem);
                listBox2.Items.Add(chip_1pack * 5);
            }

        }

        private void cb_for_cookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_cookies.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_cookies.SelectedItem);
                listBox2.Items.Add(cookie_1pack);
            }
            if (cb_for_cookies.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_cookies.SelectedItem);
                listBox2.Items.Add(cookie_1pack * 5);
            }

        }

        private void cb_for_vegetables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_vegetables.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_vegetables.SelectedItem);
                listBox2.Items.Add(vegies_500);
            }
            if (cb_for_vegetables.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_vegetables.SelectedItem);
                listBox2.Items.Add(vegies_500);
            }
            if (cb_for_vegetables.SelectedIndex == 2)
            {
                listBox1.Items.Add(cb_for_vegetables.SelectedItem);
                listBox2.Items.Add(vegies_500);
            }
            if (cb_for_vegetables.SelectedIndex == 3)
            {
                listBox1.Items.Add(cb_for_vegetables.SelectedItem);
                listBox2.Items.Add(vegies_500);
            }
            if (cb_for_vegetables.SelectedIndex == 4)
            {
                listBox1.Items.Add(cb_for_vegetables.SelectedItem);
                listBox2.Items.Add(vegies_500);
            }
            if (cb_for_vegetables.SelectedIndex == 5)
            {
                listBox1.Items.Add(cb_for_vegetables.SelectedItem);
                listBox2.Items.Add(vegies_500);
            }
            if (cb_for_vegetables.SelectedIndex == 6)
            {
                listBox1.Items.Add(cb_for_vegetables.SelectedItem);
                listBox2.Items.Add(vegies_500);
            }

        }

        private void cb_for_apple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_apple.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_apple.SelectedItem);
                listBox2.Items.Add(fruits_500);

            }
            if (cb_for_apple.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_apple.SelectedItem);
                listBox2.Items.Add(fruits_500);
            }
            if (cb_for_apple.SelectedIndex == 2)
            {
                listBox1.Items.Add(cb_for_apple.SelectedItem);
                listBox2.Items.Add(fruits_500);
            }
            if (cb_for_apple.SelectedIndex == 3)
            {
                listBox1.Items.Add(cb_for_apple.SelectedItem);
                listBox2.Items.Add(fruits_500);
            }
            if (cb_for_apple.SelectedIndex == 4)
            {
                listBox1.Items.Add(cb_for_apple.SelectedItem);
                listBox2.Items.Add(fruits_500);
            }
            if (cb_for_apple.SelectedIndex == 5)
            {
                listBox1.Items.Add(cb_for_apple.SelectedItem);
                listBox2.Items.Add(fruits_500);
            }
            if (cb_for_apple.SelectedIndex == 6)
            {
                listBox1.Items.Add(cb_for_apple.SelectedItem);
                listBox2.Items.Add(fruits_500);
            }

        }

        private void cb_for_flour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_for_flour.SelectedIndex == 0)
            {
                listBox1.Items.Add(cb_for_flour.SelectedItem);
                listBox2.Items.Add(flour_500);
            }
            if (cb_for_flour.SelectedIndex == 1)
            {
                listBox1.Items.Add(cb_for_flour.SelectedItem);
                listBox2.Items.Add(flour_500 * 2);
            }

        }
        decimal sum = 0;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("Items");
            dt.Columns.Add("Price");
            if (listBox1.Items.Count == listBox2.Items.Count)
            {
                for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    dt.Rows.Add(listBox1.Items[i], listBox2.Items[i] + "/-");
                }
                //Total price
                for(int i = 0; i < listBox2.Items.Count; i++)
                {
                    sum += Convert.ToDecimal(listBox2.Items[i]);
                }
                dt.Rows.Add("Total", sum + "/-");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 160;
                dataGridView1.Columns[1].Width = 160;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Payment = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Pay Amount: "));
            if (Payment < sum)
            {
                MessageBox.Show("Insufficient Amount");
            }
            else
            {
                dt.Rows.Add("Amount Paid", Payment + "/-");
                dt.Rows.Add("Change", Payment - sum + "/-");
            }
        }
    }
}
