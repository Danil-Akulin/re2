using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    class Bilerid : Form
    {
            public Bilerid()
            {
            this.ClientSize = new System.Drawing.Size(400, 200);
            BackColor = Color.LightGray;
            Label message = new Label();
            Button[] btn = new Button[4];
            string[] texts = new string[4];
            TableLayoutPanel tlp = new TableLayoutPanel();
            Button btn_tabel;
            int btn_w, btn_h;
            

            Button Start_btn_2 = new Button                                  // Создание кнопки и её настройка
            {
                Text = "Подтвердить",
                Location = new System.Drawing.Point(160, 30)
            };
            //this.Font = new Font("Times New Roman", 15.0f);
            this.Controls.Add(Start_btn_2);
            Start_btn_2.Click += Start_btn_2_Click;

            //////////////////////////////////////////////////////////////////////////////////////////      Отвечает за текст и его настройку
            
            TextBox box = new TextBox();
            box.Location = new Point(2, 100);

            box.Text = "Здравствуйте, по техническим причинам доступен только 1 зал 12 на 12. Приносим свои извинения";
            Font myfont = new Font("Times New Roman", 10.0f);        //изменения размера шрифта
            box.Font = myfont;                                    // хз

            box.ReadOnly = true;                                //только для чтения
            box.Height = 350;
            box.Width = 450;
            box.BackColor = Color.LightGray;                //изменяет забний цвет на цвет страницы
            box.BorderStyle = 0;                             // уберает чёрные рамки

            //box.AutoSize = false;

            this.Controls.Add(box);
            ///////////////////////////////////////////////////////////////////////////////////////////

        }
        private void Start_btn_2_Click(object sender, EventArgs e)                      //кол-во кнопок
        {
            MyForm uus_aken = new MyForm(12, 12);
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
        }
}
