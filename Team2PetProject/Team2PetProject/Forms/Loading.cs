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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            base.Text = "PetProject";
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = "Загрузка компонентов";  
        }
        int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 1;
            progressBar1.Value = startPos;
            label2.Text = startPos + "%";
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            else if (progressBar1.Value == 30)
            {
                label3.Text = "Загрузка баз данных";
                progressBar1.Value = progressBar1.Value + 1;
            }
            else if (progressBar1.Value == 70)
            {
                label3.Text = "Запуск приложения";
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
                progressBar1.Value = progressBar1.Value + 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
