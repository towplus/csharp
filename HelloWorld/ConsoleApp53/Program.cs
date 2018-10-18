using System;
namespace ConsoleApplication1
{
    //이벤트 게시자 클래스, 이벤트를 발생시키는 객체
    class EventPublisher
    {
        public event EventHandler MyEvent; //이벤트 정의
        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            //if (MyEvent != null) { MyEvent(); //이벤트 발생 }
            MyEvent?.Invoke(null,null);
        }
    }
    //구독자 클래스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();            p.MyEvent += new EventHandler(doAction);

            p.MyEvent += doAction;

            p.MyEvent += (sender, e) =>
             {
                 Console.WriteLine("MyEvent2 라는 이벤트 발생...");
             };

            p.Do();
        }
        static void doAction(object sender,EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}