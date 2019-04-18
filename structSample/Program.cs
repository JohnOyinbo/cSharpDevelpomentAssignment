using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dimension phone = new Dimension(20, 20, 20);
            Dimension book = new Dimension(10,10,10);
            Dimension hardDisk = new Dimension(8,5,2);
            var resultantDimension = phone.Add(book).Add(hardDisk);
            Console.WriteLine(resultantDimension);
            Console.WriteLine(phone.Distance(book));
            Console.ReadLine();
        }
    
    }
    public struct Dimension
    {
        int L { get; set; }
        int B { get; set; }
        int H { get; set; }
        public Dimension (int l, int b, int h)
        {
            L = l;
            B = b;
            H = h;
        }
        public Dimension Add (Dimension cube)
        {
            return new Dimension(L + cube.L, B +cube.B, H + cube.H);
        }
        public Dimension Minus(Dimension cube)
        {
            return new Dimension(L - cube.L, B - cube.B, H - cube.H);
        }
        public Dimension Multiply(Dimension cube)
        {
            return new Dimension(L * cube.L, B * cube.B, H * cube.H);
        }
        public override string ToString()
        {
            return $"[L:{L},B:{B},H:{H}]";
        }
        public double Distance(Dimension l)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow((L - l.L), 2) + Math.Pow((B - l.B), 2) + Math.Pow((H - l.H), 2));
            return distance;
        }
    }
}
