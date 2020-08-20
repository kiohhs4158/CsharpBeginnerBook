using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example403
{
    class Bingo
    {
        private int[,] card;
        private int size;
        public Bingo() : this(5)
        {
        }
        public Bingo(int size)
        {
            Init(size);
        }
        private void Clear()
        {
            for (int i = 0; i < card.GetLength(0); i++)
            {
                for (int j = 0; j < card.GetLength(1); j++)
                {
                    card[i, j] = 0;
                }
            }
        }
        private void Shuffle()
        {
            Random rnd = new Random();
            int num = 1;
            while (num <= size * size)
            {
                while (true)
                {
                    int m = rnd.Next(size);
                    int n = rnd.Next(size);
                    if (card[m, n] == 0)
                    {
                        card[m, n] = num;
                        num++;
                        break;
                    }
                }
            }
        }
        public void Init(int size)
        {   
            this.size = size;
            card = new int[size, size];
            Clear();
            Shuffle();
        }
        public void Show()
        {
            for (int i = 0; i < card.GetLength(0); i++)
            {
                for (int j = 0; j < card.GetLength(1); j++)
                {
                    Console.Write("{0, 2:d}|", card[i, j]);
                }
                Console.WriteLine();
                for (int j = 0; j < card.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
        }
       
    }
}
