/*
 * =================================
 * Polymorphism(多型)簡單範例
 * 2021.04.22 - Jason Wang
 * Ref:
 * (1) https://dotblogs.com.tw/lapland/2015/10/22/153650
 * (2) https://www.w3schools.com/cs/cs_polymorphism.asp
 * (3) https://stackoverflow.com/questions/31684696/why-do-we-assign-child-class-object-to-parent-class-reference-variable
 * =================================
 */

using System;

// ★錯誤的覆寫方法
/*
// 父類別-Car
class Car
{
    public void Show()
    {
        Console.WriteLine("This is a car.");
    }
}

// 子類別-CarWithAT(自排車)
class CarWithAT : Car
{
    new public void Show()
    {
        Console.WriteLine("This car with automatic transmission.");
    }
}

// 子類別-CarWithMT(手排車)
class CarWithMT : Car
{
    new public void Show()
    {
        Console.WriteLine("This car with manual transmission.");
    }
}

class Polymorphism
{
    static void Main(string[] args)
    {
        Car C = new Car();
        C.Show();

        Car CA = new CarWithAT();
        CA.Show();
        Car CM = new CarWithMT();
        CM.Show();
        
        // Note:
        // 此處的子類別皆使用"new"關鍵字，為的是「遮蔽」父類別的Show()方法。
        // 然而，這並非覆寫(override)，反而讓父、子類別的Show()方法同時存在。
        // 雖然都宣告為Car，但自排車與手排車卻無法正確呈現其規格。

        // Output:
        // This is a car.
        // This is a car.
        // This is a car.
    }
}
*/

// ★ 正確的覆寫方法
// 父類別-Car
class Car
{
    // 在父類別中，對需要在子類別覆寫的方法加上"virtual"關鍵字
    virtual public void Show()
    {
        Console.WriteLine("This is a car.");
    }
}

// 子類別-CarWithAT(自排車)
class CarWithAT : Car
{
    // 在子類別中，對需要覆寫的方法加上"override"關鍵字
    override public void Show()
    {
        Console.WriteLine("This car with automatic transmission.");
    }
}

// 子類別-CarWithMT(手排車)
class CarWithMT : Car
{
    // 在子類別中，對需要覆寫的方法加上"override"關鍵字
    override public void Show()
    {
        Console.WriteLine("This car with manual transmission.");
    }
}

class Polymorphism
{
    static void Main(string[] args)
    {
        Car C = new Car();
        C.Show();

        Car CA = new CarWithAT();
        CA.Show();
        Car CM = new CarWithMT();
        CM.Show();

        // Note:
        // 即使所有子類別宣告成父類別(Car)型別，
        // 子類別依然能正確顯示其覆寫(override)的Show()方法。

        // Output:
        // This is a car.
        // This car with automatic transmission.
        // This car with manual transmission.
    }
}