using System;
public class Animation
{
    private int total; 
    private string[] title; 
    private string distributor; 
    private string date; 
    private int price; 
    public Animation(int total, string distributor, string date, int price)
    {
        this.total = total; this.title = new string[total];
        this.distributor = distributor;
        this.date = date; this.price = price;
    }
    public void setTitle(int number, string title) { this.title[number] = title; }
    public string getTitle(int number) { return title[number]; }
    public string getDistributor() { return distributor; }
    public int getPrice() { return price; }
    public int getTotal() { return total; }
}
class AniTest
{
    static void Main()
    {
        Animation ani = new Animation(5, "한국애니", "10-27-2004", 35000);
        ani.setTitle(0, "인어공주");
        ani.setTitle(1, "신데렐라");
        ani.setTitle(2, "백설공주");
        ani.setTitle(3, "바보온달");
        ani.setTitle(4, "라이온킹");
        Console.WriteLine("배급사: {0}", ani.getDistributor());
        Console.WriteLine("가격: {0}", ani.getPrice());
        Console.WriteLine("----------------------------");
        for (int i = 0; i < ani.getTotal(); i++)
        {
            Console.WriteLine("Volume{0} : {1}", i, ani.getTitle(i));
        }
    }
}