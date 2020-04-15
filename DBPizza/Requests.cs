using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPizza
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Requests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.ЗарплатыСотрудников". При необходимости она может быть перемещена или удалена.
            this.зарплатыСотрудниковTableAdapter.Fill(this.pizzaDataSet.ЗарплатыСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzaDataSet.СтоимостьПродуктов". При необходимости она может быть перемещена или удалена.
            this.стоимостьПродуктовTableAdapter.Fill(this.pizzaDataSet.СтоимостьПродуктов);

        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Requests_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
