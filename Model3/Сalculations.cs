using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model3
{
    class Сalculations
    {
        double[] arrIntgrl, arrFrequency;
        int maxRnd = 100, minRnd = 0;
        double sequenceLngth, probabilityOne, selectLngth;

        public Сalculations(double sequenceLngth, double selectLngth)
        {
            this.sequenceLngth = sequenceLngth; //длина последовательности
            this.selectLngth = selectLngth; //объем выборки
            probabilityOne = (double)1 / sequenceLngth;//вер-ть одного события
            arrIntgrl = new double[maxRnd]; //массив для интегральной функции
            arrFrequency = new double[maxRnd]; //массив относительных частот
        }
       
        //встроенный метод
        public double[] InRndN()
        {
            Random rnd = new Random();
            int count = 0;
            while (count < sequenceLngth)
            {
                arrFrequency[rnd.Next(0, maxRnd)] += probabilityOne;
                count++;
            }
           
            return arrFrequency;
        }
        //метод Лемера
        public double[] LemerN()
        {
            RndLemer lemer = new RndLemer(1);
            for (int i = 0; i < sequenceLngth; ++i)
            {
                double x = lemer.Lemer();
                int number = (int)((maxRnd - minRnd) * x + minRnd);
                arrFrequency[number] +=probabilityOne;
            }
            return arrFrequency;
        }
        //вычисление значений для графика интегральной функции
        public double[] IntegralGraph()
        {
            arrIntgrl[0] = 0;
            for (int y = 1; y < arrIntgrl.Length; y++)
            {
                arrIntgrl[y] = arrFrequency[y - 1] + arrIntgrl[y - 1];
            }
            return arrIntgrl;
        }
        //расчет значений для статистики
        public double[] statistic(int method)
        { 
            double[] arrStatistic = new double[4]; //массив для статистич. значений 
            for (int y = 0; y < arrFrequency.Length; y++)
            {
                arrStatistic[0] += arrFrequency[y]*sequenceLngth/maxRnd * y; //математичеcкое ожидание 
                arrStatistic[1] += arrFrequency[y]*sequenceLngth/maxRnd * Math.Pow(y, 2); 
            }
            //дисперсия
            arrStatistic[2] = Math.Abs(arrStatistic[1] - Math.Pow(arrStatistic[0], 2));
            arrStatistic[3] = CalculPi(method); //Пи
            return arrStatistic;
        }
        //расчет числа Пи
        public double CalculPi(int method)
        {
            RndLemer lemer = new RndLemer(1);
            Random rnd = new Random();
            double hitSectr = 0,x,y;
            for (int i = 0; i < selectLngth; i++)
            {//если выбран встроенный генератор
                if (method == 1) {
                     x = rnd.NextDouble();
                     y = rnd.NextDouble(); }
                //если выбран генератор Лемера
                else { 
                x = lemer.Lemer();
                y = lemer.Lemer(); }
             //точка находится внутри сектора
            if (x*x+ y*y < 1) hitSectr++;
            }
            return (double)hitSectr / selectLngth * 4; // Пи = Р* 4
        }

    }
}