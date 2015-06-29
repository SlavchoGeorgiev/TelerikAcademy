namespace P5BitArray64
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Test
    {
        static void Main()
        {
            BitArray64 firstBitArr = new BitArray64(255);
            BitArray64 secondBitArr = new BitArray64(510);
            Console.WriteLine(firstBitArr);
            foreach (var bit in firstBitArr)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            Console.WriteLine(" {0} =\n {1}\n => {2}", firstBitArr, secondBitArr, firstBitArr == secondBitArr);
            Console.WriteLine(" {0} =\n {1}\n => {2}", firstBitArr, firstBitArr, firstBitArr == firstBitArr);
            Console.WriteLine(" {0} !=\n {1}\n => {2}", new BitArray64(181671546), new BitArray64(181671546), new BitArray64(181671546) != new BitArray64(181671546));
            Console.WriteLine("Hash code of {0} = {1}", firstBitArr,firstBitArr.GetHashCode());

        }
    }
}