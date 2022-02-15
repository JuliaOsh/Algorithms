using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms
{
    public class Lesson3PerformanceRatio : ILesson
    {
        public string LessonID { get; private set; }
        public string LessonDescription { get; set; }
        public PointStructDouble[] StructArray100 { get; set; }
        public PointStructDouble[] StructArray200 { get; set; }
        public PointClassDouble[] ClassArray100 { get; set; }
        public PointClassDouble[] ClassArray200 { get; set; }

        public Lesson3PerformanceRatio()
        {
            LessonID = "3.1";
            LessonDescription = "Calculation of Performance ratio.";

            int n = 100000;
            double[] randomArray = CreateRandomNumber(n);
            StructArray100 = StructCoordinateArray(randomArray);

            n = 200000;
            randomArray = CreateRandomNumber(n);
            StructArray200 = StructCoordinateArray(randomArray);

            n = 100000;
            randomArray = CreateRandomNumber(n);
            ClassArray100 = ClassCoordinateArray(randomArray);

            n = 200000;
            randomArray = CreateRandomNumber(n);
            ClassArray200 = ClassCoordinateArray(randomArray);
        }

        public static double[] CreateRandomNumber(int n)
        {
            double[] randomArray = new double[n];

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                randomArray[i] = rand.NextDouble() * 10000;
            }
            return randomArray;
        }

        static PointStructDouble[] StructCoordinateArray(double[] randomArray)
        {
            PointStructDouble[] structCoordinateArray = new PointStructDouble[randomArray.Length / 2];
            for (int i = 0; i < randomArray.Length; i++)
            {
                structCoordinateArray[i / 2] = new PointStructDouble(randomArray[i], randomArray[++i]);
            }
            return structCoordinateArray;
        }

        static PointClassDouble[] ClassCoordinateArray(double[] randomArray)
        {
            PointClassDouble[] classCoordinateArray = new PointClassDouble[randomArray.Length / 2];
            for (int i = 0; i < randomArray.Length; i++)
            {
                classCoordinateArray[i / 2] = new PointClassDouble(randomArray[i], randomArray[++i]);
            }
            return classCoordinateArray;
        }

        double[] StructCalculateDistance(PointStructDouble[] structCoordinateArray)
        {
            double[] structDistance = new double[structCoordinateArray.Length - 1];

            for (int i = 0; i < structCoordinateArray.Length - 1; i++)
            {
                double x = structCoordinateArray[i].X - structCoordinateArray[i + 1].X;
                double y = structCoordinateArray[i].Y - structCoordinateArray[i + 1].Y;
                structDistance[i] = Math.Sqrt((x * x) + (y * y));
            }
            return structDistance;
        }

        double[] ClassCalculateDistance(PointClassDouble[] classCoordinateArray)
        {
            double[] classDistance = new double[classCoordinateArray.Length - 1];

            for (int i = 0; i < classCoordinateArray.Length - 1; i++)
            {
                double x = classCoordinateArray[i].X - classCoordinateArray[i + 1].X;
                double y = classCoordinateArray[i].Y - classCoordinateArray[i + 1].Y;
                classDistance[i] = Math.Sqrt((x * x) + (y * y));
            }
            return classDistance;
        }

        [Benchmark]
        public void Struct100000()
        {
            double[] structDistance = StructCalculateDistance(StructArray100);
        }

        [Benchmark]
        public void Struct200000()
        {
            double[] structDistance = StructCalculateDistance(StructArray100);
        }

        [Benchmark]
        public void Class100000()
        {
            double[] structDistance = StructCalculateDistance(StructArray100);
        }

        [Benchmark]
        public void Class200000()
        {
            double[] structDistance = StructCalculateDistance(StructArray100);
        }

        public static void Benchmark()
        {
            BenchmarkRunner.Run<Lesson3PerformanceRatio>();
        }



















    }
}
