using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Model3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //интервалы
            differentFunct.ChartAreas[0].AxisX.Interval = 10;
            integralFunct.ChartAreas[0].AxisX.Interval = 10;
            //названия осей графиков
            differentFunct.ChartAreas[0].AxisX.Title = "x";
            differentFunct.ChartAreas[0].AxisY.Title = "f(x)";
            integralFunct.ChartAreas[0].AxisX.Title = "x";
            integralFunct.ChartAreas[0].AxisY.Title = "F(x)";
            //прорисовка стрелок осей
            differentFunct.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Lines;
            differentFunct.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Lines;
            integralFunct.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Lines;
            integralFunct.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Lines;
        }

        //диапазон случ. чисел
        const int maxRnd = 100, minRnd = 0;
        //массив цветов
        Color[] colrs = { Color.Navy, Color.Orange, Color.Green, Color.Magenta, Color.Red, Color.RoyalBlue };
        int countGraph = 0; //счетчик графиков

        //кнопка "Запуск"
        private void startButton_Click(object sender, EventArgs e)
        {
            double sequenseText, selectText;
            //проверка на число и непустое поле
                if (double.TryParse(sequenceBox.Text, out sequenseText) & double.TryParse(selectBox.Text, out selectText))
                {//проверка на соответствие диапазону
                if (sequenseText >= 100 & sequenseText <= 10000 & selectText >= 100)
                {
                    //при соблюдении всех условий вызывается метод построения графиков
                    DrawGraphs();
                }
                else MessageBox.Show("100 <= Длина последовательности <= 10000\nОбъем выборки >=100", "Внимание", MessageBoxButtons.OK);   
            }
            else MessageBox.Show("Введите числа: длину последовательности и объем выборки", "Внимание", MessageBoxButtons.OK);
            //если графиков 6, то кнопка "Запуск" недоступна
            if (countGraph >= 6) startButton.Enabled = false;
        }
        //кнопка "Очистить"
        private void delButton_Click(object sender, EventArgs e)
        {
            differentFunct.Series.Clear();
            integralFunct.Series.Clear();
            statisticBox.Clear();
            countGraph = 0;
            startButton.Enabled = true;
        }

        //построение графиков и вывод статистики
        public void DrawGraphs()
        {
            differentFunct.Series.Add(countGraph.ToString());
            integralFunct.Series.Add(countGraph.ToString());
            differentFunct.Series[countGraph].Color = colrs[countGraph];
            integralFunct.Series[countGraph].Color = colrs[countGraph];
            //длина послед-ти и объем выборки вводятся пользователем
            double sequenceLngth = Convert.ToDouble(sequenceBox.Text);
            double selectLngth = Convert.ToDouble(selectBox.Text);
            int method = 1; //генераторы: встроенный-1, Лемера-2

            Сalculations calcut = new Сalculations(sequenceLngth, selectLngth);
            //в зависимости от выбранного генератора вызывается соответствущий метод,
            //строится график дифференциальной функции
            if (genInn.Checked)
            {
                differentFunct.Series[countGraph].Points.DataBindY(calcut.InRndN());
                method = 1;
            }
            else
            {
                differentFunct.Series[countGraph].Points.DataBindY(calcut.LemerN());
                method = 2;
            }
            //построение графика интегральной функции
            integralFunct.Series[countGraph].Points.DataBindY(calcut.IntegralGraph());
            //цвет текста в окне статистики устанавливается соответственно цвету графика
            statisticBox.Select(statisticBox.TextLength, 0);
            statisticBox.SelectionColor = colrs[countGraph];
            double[] arrStatistic = calcut.statistic(method);
            //вывод данных в окно статистики
            statisticBox.AppendText("Длина последовательности= " + sequenceLngth + ";\nМатематическое ожидание= " +
                arrStatistic[0] + ";\nДисперсия= " + arrStatistic[2] +
                ";\nОбъем выборки= " + selectLngth + ";\nЧисло Пи= " + arrStatistic[3] + "\n\n");
            countGraph++; //счетчик графиков
        }
    }
} 
