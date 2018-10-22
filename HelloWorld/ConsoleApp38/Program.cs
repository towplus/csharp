using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get { return count * goods.danga; } set { } }

        public Cart(Goods goods, int count)

        {

            this.goods = goods;

            this.count = count;

            sum = count * goods.danga;

        }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Goods g1 = new Goods(1001, "볼펜", 2000);

            Goods g2 = new Goods(1002, "연필", 500);

            Goods g3 = new Goods(1003, "딸기", 6000);

            //Hashtable 의 제너릭 형태

            Dictionary<int, Cart> carts = new Dictionary<int, Cart>();

            carts.Add(1, new Cart(g1, 2));

            carts.Add(2, new Cart(g2, 3));

            carts.Add(3, new Cart(g3, 2));

            int i = 0;

            foreach (KeyValuePair<int, Cart> d in carts)

            {

                Console.WriteLine(++i + " : " + d.Value.goods.goodsno + " : " +

                d.Value.goods.gname + ":" + d.Value.goods.danga + " : " +

                d.Value.count + " : " + d.Value.sum

                );
            }
        }
    }
}