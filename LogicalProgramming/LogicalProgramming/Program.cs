using System;

namespace Day6LogicalPrograms
{
    internal class Coupon
    {
        private string Generator()
        {
            string Code = "";
            Code = Convert.ToString(new Random().Next(0,20));
            return Code;
        }
        public Coupon()
        {
           
            int N = Convert.ToInt32(Console.ReadLine());
            string[] Coupon_List = new string[N];
            string Coupon_Code = Generator();

            for (int i = 0; i < N; i++)
            {
                while (Array.Exists(Coupon_List, element => element == Coupon_Code))
                {
                    Coupon_Code = Generator();
                }
                Coupon_List[i] = Coupon_Code;
            }
            Console.WriteLine("Required Coupon Numbers are, ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(Coupon_List[i]);
            }
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Coupon Programs");
            Console.WriteLine("Enter the number of unique coupons required (N): ");
            Coupon coupon = new Coupon();

        }
    }
}