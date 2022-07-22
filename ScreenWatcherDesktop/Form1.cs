using Newtonsoft.Json;
using ScreenWatcherDesktop.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenWatcherDesktop
{
    public partial class Form1 : Form
    {
        int XShift = 100;

        //Скриншоты
        Bitmap ScreenShot;
        Bitmap PrevScreenShot;

        //Координаты начала выделения
        int StartSelectionX;
        int StartSelectionY;

        //Заблокировать созранение параметров, пока они не загружены
        bool BlockSave = true;

        //Масштаб отображения скриншота
        //Так же используется для выделения рамки
        int scale = 1;

        //Признак того, что кнопка мыши зажата на пикчебоксе и идет выделение
        bool MouseDowned = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void MakeScreenshot()
        {
            //Освобождаю память от предыдущего скриншота
            PrevScreenShot?.Dispose();

            //Копирую скриншот в предыдущий
            PrevScreenShot = ScreenShot;

            //далее получаю новый скриншот

            // получаем размеры виртуального экрана, содержащего все мониторы
            Rectangle bounds = SystemInformation.VirtualScreen;

            // создаем пустое изображения размером с экран устройства
            ScreenShot = new Bitmap(bounds.Width, bounds.Height);
            // создаем объект на котором можно рисовать
            using (var g = Graphics.FromImage(ScreenShot))
            {
                // перерисовываем экран на наш графический объект
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }

            //Устанавливаю ограничение на Вертикальные и горизонтальные числа
            VerticalTo.Maximum = ScreenShot.Height;
            HorizontalTo.Maximum = ScreenShot.Width;
            VerticalFrom.Maximum = ScreenShot.Height;
            HorizontalFrom.Maximum = ScreenShot.Width;
        }

        public bool CompareScreenShots()
        {
            //Если скриншота нет, то он не меняется
            if (PrevScreenShot == null)
                return false;

            //Сравниваю все пиксели 
            for (int i = (int)HorizontalFrom.Value; i < (int)HorizontalTo.Value; i++)
                for (int j = (int)VerticalFrom.Value; j < (int)VerticalTo.Value; j++)
                {
                    //сравниваю два пикселя с разных скриншотов
                    if (ScreenShot.GetPixel(i, j) != PrevScreenShot.GetPixel(i, j))
                    {

                        return true;
                    }
                }
            return false;
        }

        //показать скриншот виртуального экрана
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (ScreenShot != null)
            {
                //Вычислить оптимальные размеры
                float horizontal = ScreenShot.Width / pictureBox1.Width;
                float vertical = ScreenShot.Height / pictureBox1.Height;
                scale = (int)Math.Max(horizontal, vertical) + 1;

                //Нарисовать уменьшенный скриншот и рамку выделения
                e.Graphics.DrawImage(ScreenShot, 0 + XShift, 0, ScreenShot.Width / scale, ScreenShot.Height / scale);
                e.Graphics.DrawRectangle(Pens.Black,
                    (int)HorizontalFrom.Value / scale + XShift, (int)VerticalFrom.Value / scale,
                    (int)(HorizontalTo.Value - HorizontalFrom.Value) / scale, (int)(VerticalTo.Value - VerticalFrom.Value) / scale);
                e.Graphics.DrawRectangle(Pens.White,
                    (int)HorizontalFrom.Value / scale + 1 + XShift, (int)VerticalFrom.Value / scale + 1,
                    (int)(HorizontalTo.Value - HorizontalFrom.Value) / scale - 2, (int)(VerticalTo.Value - VerticalFrom.Value) / scale - 2);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Изменено значение интервала
            //изменяем значение таймера
            timer1.Interval = (int)numericUpDown1.Value * 1000;

            SaveValues();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        { 
            //Удалить лишний слеш, если он есть
            if (ServerAdressTextBox2.Text[ServerAdressTextBox2.Text.Length - 1] == '/')
                ServerAdressTextBox2.Text = ServerAdressTextBox2.Text.Remove(ServerAdressTextBox2.Text.Length - 1);

            //Отправка данных
            string serverAdress = ServerAdressTextBox2.Text;
            var message = new ComputerWork();
            message.ComputerId = ComputerIdTextBox4.Text;
            message.ComputerName = ComputerNameTextBox3.Text;
            message.Timeout = (int)numericUpDown1.Value;
            //Сделать скриншот
            MakeScreenshot();

            //Сравнить скриншоты и показать результат
            if (CompareScreenShots())
            {
                textBox1.AppendText(DateTime.Now.TimeOfDay.ToString() + " Видео идет\r\n");
                label3.Text = "Видео идет";
                message.IsRunning = true;
            }
            else
            {
                textBox1.AppendText(DateTime.Now.TimeOfDay.ToString() + " Видео остановлено\r\n");
                label3.Text = "Видео остановлено";
                message.IsRunning = false;
            }
            bool bSuccess = true;
            try
            {
                //Собрать сообщение
                string jsonMessage = JsonConvert.SerializeObject(message);
                //Послать сообщение
                var stringContent = new StringContent(jsonMessage, Encoding.UTF8, "application/json");
                var response = await new HttpClient().PostAsync(serverAdress + @"/api/FromDesktop", stringContent);
                //textBox1.Text = response.ToString();
            }
            catch (Exception ex)
            {
                label11.Text = "Соединение с сервером отсутствует:"
                    +ex.Message;
                bSuccess = false;
            }
            if(bSuccess)
            {
                label11.Text = "Есть соединение с сервером";
            }
            //Перерисовать скриншот
            pictureBox1.Invalidate();
        }


        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                //Задаю начальные значения
                StartSelectionX = e.X - XShift;
                StartSelectionY = e.Y;
                VerticalFrom.Value = e.Y * scale;
                HorizontalFrom.Value = e.X * scale;
                VerticalTo.Value = e.Y * scale;
                HorizontalTo.Value = e.X * scale;
                //началось выделение
                MouseDowned = true;
            }
            catch (Exception )
            {

            }
        }

        private void pictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MouseDowned = false;
            SaveValues();
        }

        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Еси не идет выделение, но ничего не делаем
            if (!MouseDowned)
                return;

            try
            {
                if (e.Y > StartSelectionY)
                {
                    VerticalFrom.Value = StartSelectionY * scale;
                    VerticalTo.Value = e.Y * scale;
                }
                else
                {
                    VerticalFrom.Value = e.Y * scale;
                    VerticalTo.Value = StartSelectionY * scale;
                }
                if (e.X - XShift > StartSelectionX)
                {
                    HorizontalFrom.Value = StartSelectionX * scale;
                    HorizontalTo.Value = (e.X - XShift) * scale;
                }
                else
                {
                    HorizontalFrom.Value = (e.X - XShift) * scale;
                    HorizontalTo.Value = StartSelectionX * scale;
                }
            }
            catch (Exception ex)
            {

            }
            pictureBox1.Invalidate();
        }
        void SaveValues()
        {
            if (!BlockSave && !MouseDowned)
            {
                Properties.Settings.Default.Timeout = (int)numericUpDown1.Value;
                Properties.Settings.Default.HorizontalFrom = (int)HorizontalFrom.Value;
                Properties.Settings.Default.HorizontalTo = (int)HorizontalTo.Value;
                Properties.Settings.Default.VerticalFrom = (int)VerticalFrom.Value;
                Properties.Settings.Default.VerticalTo = (int)VerticalTo.Value;
                Properties.Settings.Default.ServiceAdress = ServerAdressTextBox2.Text;
                Properties.Settings.Default.ThisComputerName = ComputerNameTextBox3.Text;
                Properties.Settings.Default.Save();
            }
        }
        void LoadValues()
        {
            try
            {
                numericUpDown1.Value = Properties.Settings.Default.Timeout;
                HorizontalFrom.Maximum = Properties.Settings.Default.HorizontalFrom;
                HorizontalFrom.Value = Properties.Settings.Default.HorizontalFrom;

                HorizontalTo.Maximum = Properties.Settings.Default.HorizontalTo;
                HorizontalTo.Value = Properties.Settings.Default.HorizontalTo;

                VerticalFrom.Maximum = Properties.Settings.Default.VerticalFrom;
                VerticalFrom.Value = Properties.Settings.Default.VerticalFrom;

                VerticalTo.Maximum = Properties.Settings.Default.VerticalTo;
                VerticalTo.Value = Properties.Settings.Default.VerticalTo;

                ServerAdressTextBox2.Text = Properties.Settings.Default.ServiceAdress;
                ComputerNameTextBox3.Text = Properties.Settings.Default.ThisComputerName;
            }
            catch (Exception)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Запрет на сохранение
            BlockSave = true;

            //Подгрузить все настройки
            LoadValues();
            //Пусть таймер сразу тикнет
            timer1_Tick(sender, e);

            //Пусть теперь можно сохранять
            BlockSave = false;

            //Получить ID оборудования
            //Процессор
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorID"].ToString();
            }
            //Жесткий диск
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            id += dsk["VolumeSerialNumber"].ToString();
            ComputerIdTextBox4.Text = id;


            timer1.Enabled = true;
        }

        private void HorizontalTo_ValueChanged(object sender, EventArgs e)
        {
            SaveValues();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void ServerAdressTextBox2_Leave(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
        }

        private void ComputerNameTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (ComputerNameTextBox3.Text.Length > 16)
            {
                ComputerNameTextBox3.Text = ComputerNameTextBox3.Text.Remove(16);
                ComputerNameTextBox3.Select(ComputerNameTextBox3.Text.Length, 0);
            }
        }

        private void ServerAdressTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            label11.Text = "Проверка соединения с сервером";
            timer1_Tick(sender, e);

        }
    }
}
