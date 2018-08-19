using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIPP_PKrolikowski
{
    public partial class Form1 : Form
    {
        string nameToShow;
        int ticks;
        System.Timers.Timer timer;
        int dx;
        delegate void TimerStop();
        event TimerStop TimerStopHandler;
        public Form1()
        {
            InitializeComponent();
            //deklaruje timer by sie trigerowal co 0,5 s jesli zostanie wlaczony
            timer = new System.Timers.Timer(500);
            //dodaje do zdarzenia Elapsed metode StartAnimation
            timer.Elapsed += StartAnimation;
            timer.AutoReset = true;
            dx = 0;
            ticks = 0;
            //dodanie do naszego eventu wyrazenia lambda typu TimerStop
            TimerStopHandler += (() =>
            {
                ticks = 0;
                timer.Stop();
            });
        }

        void RefreshDataBase()
        {
            this.tableTableAdapter.Fill(this.peopleDbDataSet.Table);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataBase();
        }

        private void buttonEnterNewPerson_Click(object sender, EventArgs e)
        {
            //jesli ktores pole jest puste to zglos to i nic nie rob w bazie
            if (textBoxFirstNameEnter.Text == "" || textBoxLastNameEnter.Text == "")
            {
                MessageBox.Show("Imię lub nazwisko nie zostało wypełnione.");
                return;
            }
            PeopleEntities peopleEntities = new PeopleEntities();
            peopleEntities.Tables.Add(new People { Forename = textBoxFirstNameEnter.Text, Surname = textBoxLastNameEnter.Text });
            peopleEntities.SaveChanges();
            RefreshDataBase();
            //zaktualizuj nameToShow ktore jest wykorzystywane w animacji
            nameToShow = textBoxFirstNameEnter.Text + " " + textBoxLastNameEnter.Text;
            //uruchamiamy timer
            timer.Enabled = true;
        }

        private void dataGridViewDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //oblsuga zdarzenia gdy zostanie wcisnieta ktoras pozycja na datagridzie
            if (dataGridViewDb.SelectedRows.Count != 0)
            {
                string name = dataGridViewDb.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridViewDb.SelectedRows[0].Cells[2].Value.ToString();
                nameToShow = name;
                //drugi sposob na uruchomienie timera
                timer.Enabled = true;
            }
        }
        void ShowPersonAnimation()
        {
            //animacja napisu
            Bitmap bmp1 = new Bitmap(groupBoxPlaceForAnimation.Width, groupBoxPlaceForAnimation.Height);
            Graphics graphics = Graphics.FromImage(bmp1);
            graphics.TranslateTransform(dx, 0);
            dx += 100;
            //dzialanie modulo bo moglo wyjsc poza ekran i by nie bylo widac zmian, a tak to zacznie od poczatku jak wyjdzie poza kontrolke
            dx = (dx + 100) % groupBoxPlaceForAnimation.Width;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            graphics.DrawString(nameToShow, drawFont, drawBrush, 110, 110, drawFormat);
            groupBoxPlaceForAnimation.BackgroundImage = bmp1;
        }

        void StartAnimation(object sender, EventArgs e)
        {
            ShowPersonAnimation();
            ticks++;
            if (ticks > 10)
            {
                TimerStopHandler();
            }
        }

        private void dataGridViewDb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //metoda do oblsugi zdarzenia - jesli nacisniesz 2 razy na pole to zostanie skasowane
            PeopleEntities peopleEntities = new PeopleEntities();
            peopleEntities.Tables.Remove(peopleEntities.Tables.Find(dataGridViewDb.SelectedRows[0].Cells[0].Value));
            peopleEntities.SaveChanges();
            RefreshDataBase();
        }
    }
}
