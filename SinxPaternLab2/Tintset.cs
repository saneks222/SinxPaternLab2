using System;
using System.Collections.Generic;
using System.Text;

namespace SinxPaternLab2
{
    class Tintset
    {
        //ссылочный тип данных приобращение не происходит копирования фактически является самим множеством и ссылкой на множество 
        private List<int> numbers = new List<int>();
        int MaxCount;
        

        //явный конструктор без параметров создается пустое множество
        public Tintset() 
        {
            MaxCount = numbers.Count;
        }

        //конструктор 
        public Tintset(int count) 
        {
            MaxCount = count;
            Random random = new Random();

            for (int i = 0; i < count; i++) 
            {
                numbers.Add(random.Next());
            }
        }

        //конструктор копирования
        public Tintset(Tintset T) 
        {
            this.numbers = T.numbers;
        }

        public void input()
        {
            Console.WriteLine("Введите "+MaxCount+" Чисел");

            for (int i = 0; i < MaxCount; i++) 
            {
                try { numbers[i] = int.Parse(Console.ReadLine()); }
                catch(Exception e) 
                { 
                    Console.WriteLine(e.Message + " введено не число попробуй снова"); 
                    i--; 
                }
            }
        }

        public void watch() 
        {
            foreach (var i in numbers) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Колличестов элементов = " + MaxCount);
        }

        public bool Equals(Tintset T) 
        {
            var numbers1 = this.numbers;
            var numbers2 = T.numbers;

            //если колличество элементов не совпадает 
            if (numbers1.Count != numbers2.Count) 
            {
                return false;
            }

            numbers1.Sort();
            numbers2.Sort();

            for (int i = 0; i < numbers1.Count; i++) 
            {
                if (numbers1[i] != numbers2[i]) { return false; }
            }

            return true;
        }

        public void SumOtherNumber(Tintset T) 
        {
            this.MaxCount += T.MaxCount;
            this.numbers.AddRange(T.numbers);
        }
    }
}
