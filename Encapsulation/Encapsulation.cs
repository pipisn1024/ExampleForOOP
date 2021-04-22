/*
 * =================================
 * Encapsulation(封裝)簡單範例
 * 2021.04.20 - Jason Wang
 * =================================
 */

using System;
// 定義Car類別
class Car
{
    // 定義「待保養里程數」欄位(Field)
    private int remainingMileage;

    // 定義「計算待保養里程數」方法(Method)
    public int Calculate(int nowMileage)
    {
        remainingMileage = 10000 - (nowMileage % 10000);
        return remainingMileage;
    }
}

// 主程式
class Encapsulation
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("請輸入目前汽車里程數:");
            int Mileage;
            bool result = Int32.TryParse(Console.ReadLine(), out Mileage);
            if (result)
            {
                Car c = new Car();
                Console.WriteLine("剩餘 {0}km 須進行保養", c.Calculate(Mileage));
                Console.WriteLine();
                Console.WriteLine("按下<Q>鍵離開；按下<任意鍵>繼續...");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                    break;
            }
            else
            {
                Console.WriteLine("里程數必須為數字!!再試一次...");
                Console.WriteLine();
            }
        }
    }
}