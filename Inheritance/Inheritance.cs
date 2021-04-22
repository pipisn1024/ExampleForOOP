/*
 * =================================
 * Inheritance(繼承)簡單範例
 * 2021.04.22 - Jason Wang
 * =================================
 */

using System;

// 父類別-車
class Car
{
    protected int wheels;                   // 輪胎數
    protected int doors;                    // 車門數
    protected string brand;                 // 品牌
    protected string model;                 // 型號
    protected string transmissionType;      // 變速系統
    protected string engineDisplacement;    // 引擎排氣量

    // 顯示規格
    protected void ShowSpec()
    {
        Console.WriteLine("品牌: {0}\t型號: {1}\t變速系統: {2}\t引擎排氣量: {3}\t輪胎數: {4}\t車門數: {5}",
                            this.brand, this.model, this.transmissionType, this.engineDisplacement,
                            this.wheels, this.doors);
    }
}

// 子類別-Sedan(4門轎車)
class Sedan : Car
{
    // 設定並顯示4門轎車規格
    public void SetSpec(string myBrand, string myModel,
                        string myTransmissionType, string myEngineDisplacement)
    {
        this.wheels = 4;
        this.doors = 4;
        this.brand = myBrand;
        this.model = myModel;
        this.transmissionType = myTransmissionType;
        this.engineDisplacement = myEngineDisplacement;
        this.ShowSpec();
    }
}

// 子類別-HatchBack(5門掀背車)
class HatchBack : Car
{
    // 設定並顯示5門掀背車規格
    public void SetSpec(string myBrand, string myModel,
                        string myTransmissionType, string myEngineDisplacement)
    {
        this.wheels = 4;
        this.doors = 5;
        this.brand = myBrand;
        this.model = myModel;
        this.transmissionType = myTransmissionType;
        this.engineDisplacement = myEngineDisplacement;
        this.ShowSpec();
    }
}

// 子類別-SportCar(雙門跑車)
class SportCar : Car
{
    // 設定並顯示雙門跑車規格
    public void SetSpec(string myBrand, string myModel,
                        string myTransmissionType, string myEngineDisplacement)
    {
        this.wheels = 4;
        this.doors = 2;
        this.brand = myBrand;
        this.model = myModel;
        this.transmissionType = myTransmissionType;
        this.engineDisplacement = myEngineDisplacement;
        this.ShowSpec();
    }
}

class Inheritance
{
    static void Main(string[] args)
    {
        // 建立父類實例，並呼叫ShowSpec方法
        Car C = new Car();
        // C.ShowSpec();
        // --> 由於父類別"Car"將ShowSpec()方法設為protected，
        //     因此此方法可被繼承的子類別呼叫，但父類別實例化後無法被呼叫。
        //     (子類別看起來是public，但外面看起來卻是private。)

        // 建立子類實例，並呼叫SetSpec方法
        Sedan S1 = new Sedan();
        S1.SetSpec("Toyota", "Altis", "CVT", "1800cc");
        Sedan S2 = new Sedan();
        S2.SetSpec("Honda", "Civic", "AT", "1800cc");
        Sedan S3 = new Sedan();
        S3.SetSpec("Nissan", "Sentra", "CVT", "1600cc");

        HatchBack HB1 = new HatchBack();
        HB1.SetSpec("Ford", "Focus ST", "AT", "2300cc");
        HatchBack HB2 = new HatchBack();
        HB2.SetSpec("Subaru", "Impreza 5D", "CVT", "1600cc");

        SportCar SC1 = new SportCar();
        SC1.SetSpec("Toyota", "86 ", "MT", "2000cc");
        SportCar SC2 = new SportCar();
        SC2.SetSpec("Nissan", "GT-R", "AM", "3800cc");
    }
}