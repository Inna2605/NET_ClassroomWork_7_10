//Зробити класс MyArray2D, У класі 3 властивості
//Двовимірний масив
//Кількість рядочків у масиві
//Кількість стовбців у масиві
//Зробити індексатор
//Тобто реалізувати можливість звертатись через об'єкт до єелементів масиву arr[i][j]


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_ClassroomWork_7_10
{
    internal class Program
    {
class MyArray2D

        {

            public int[][] Arr2D { get; set; }
            public int SizeColumns { get; set; }
            public int SizeLines {  get; set; }
            public MyArray2D(int C, int L)
            {
                if (C <= 0 || L <= 0)
                    throw new ArgumentNullException();

                SizeColumns = C;
                SizeLines = L;

                Arr2D = new int[SizeLines][];

                Random r = new Random();

                for (int i = 0; i < SizeLines; i++)

                {
                    Arr2D[i] = new int[SizeColumns];

                    for (int j = 0; j < SizeColumns; j++) {

                        Arr2D[i][j] = r.Next(-10, 10);
                    }
                }
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                for(int i = 0;i < SizeLines; i++)
                {
                    for(int j = 0; j<SizeColumns;j++)
                    {
                        sb.Append(Arr2D[i][j]);
                        sb.Append(' ');
                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            public int this[int index1, int index2]
            {
                get
                {
                    if ((index1 < 0 || index1 >= Arr2D.Length)||(index1 < 0 || index1 >= Arr2D.Length))
                        throw new IndexOutOfRangeException();
                    return Arr2D[index1][index2];
                }

                set
                {
                    if ((index1 < 0 || index1 >= Arr2D.Length) || (index1 < 0 || index1 >= Arr2D.Length))
                        throw new IndexOutOfRangeException();
                    Arr2D[index1][index2] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            MyArray2D arr = new MyArray2D(8,5);

            Console.WriteLine(arr);

            arr[0,0] = 10000;

            Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
