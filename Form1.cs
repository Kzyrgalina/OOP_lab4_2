using System;
using System.Windows.Forms;
using static OOP_lab4_2.Form1;


namespace OOP_lab4_2
{
    public partial class Form1 : Form
    {
        private Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observer += new System.EventHandler(this.getUpdateaFromModel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Записываем содержимое в созданные в settings переменные
            Properties.Settings.Default.a = model.getA();
            Properties.Settings.Default.b = model.getB();
            Properties.Settings.Default.c = model.getC();

            // Сохраняем значения
            Properties.Settings.Default.Save();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Получаем переменные из settings и зыписываем их в модель
            model.setA(Properties.Settings.Default.a);
            model.setC(Properties.Settings.Default.c);
            model.setB(Properties.Settings.Default.b);
        }

        // Функция, обрабатывающая обновление модели
        private void getUpdateaFromModel(object sender, EventArgs e)
        {
            // set textBox
            textBoxA.Text = model.getA().ToString();
            textBoxB.Text = model.getB().ToString();
            textBoxC.Text = model.getC().ToString();

            // set numericUpDown
            numericUpDownA.Value = model.getA();
            numericUpDownB.Value = model.getB();
            numericUpDownC.Value = model.getC();

            // set trackBar
            trackBarA.Value = model.getA();
            trackBarB.Value = model.getB();
            trackBarC.Value = model.getC();
        }


        //textBox-------------------------------------------------------------
        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setA(Int32.Parse(textBoxA.Text));
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setB(Int32.Parse(textBoxB.Text));
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setC(Int32.Parse(textBoxC.Text));
        }

        //numericUpDown -----------------------------------------------------
        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(numericUpDownC.Value));
        }

        //trackBar----------------------------------------------------------
        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(trackBarA.Value));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(trackBarB.Value));
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(trackBarC.Value));
        }



        public class Model
        {
            private int a = 0, b = 0, c = 0;
            private int min = 0, max = 100;
            public System.EventHandler observer;

            private int getChekedInterval(int newNum)
            {
                return ((newNum > 100) ? 100 : ((newNum < 0) ? 0 : newNum));
            }
            public int getA() { return a; }
            public int getB() { return b; }
            public int getC() { return c; }

            public void setA(int newA)
            {
                newA = getChekedInterval(newA);
                if (newA > b) b = newA;
                if (newA > c) c = newA;

                a = newA;
                observer.Invoke(this, null);

            }
            public void setB(int newB)
            {
                newB = getChekedInterval(newB);
                if (newB < a) b = a;
                else if (newB > c) b = c;
                else b = newB;

                observer.Invoke(this, null);
            }
            public void setC(int newC)
            {
                newC = getChekedInterval(newC);
                if (newC < b) b = newC;
                if (newC < a) a = newC;

                c = newC;
                observer.Invoke(this, null);
            }
        }
        
    }
}