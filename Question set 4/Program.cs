using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_set_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Qset4_q19();
        }
        static void Qset4_q1()
        {
             Console.WriteLine("To count the no.of digits in a given integer number:");

            Console.WriteLine("");

            Console.WriteLine("Enter the intger number:");
            int i = int.Parse(Console.ReadLine());//2112    3428
            int count = 0;
         
            {
                while (i != 0)
                {
                    i = i / 10;
             
                    count++;
          
                }
                Console.WriteLine("The no of digit is :" + count);
            }



        }
        
        static void Qset4_q2()
        {
                                                                                           // TT T H T 1
            Console.WriteLine("Check if the given no is of even length or odd length:");  //1  2 3 4 5

            Console.WriteLine("");
            Console.WriteLine(" Given the integer number:");
            int i = int.Parse(Console.ReadLine());


            while (i != 0)
            {
                //i = i / 10;
                Console.WriteLine(i);


                if (i % 2 == 0)
               
                {
                    Console.WriteLine("even length:" + i);
                }
                  else if(i%2!=0)
                {
                    Console.WriteLine("odd length:" + i);
                }
                i = i / 10;


            }
        
        }

        static void Qset4_q3()
        {
            
            Console.WriteLine("SUM OF DIGITS:");
            Console.WriteLine("");

            Console.WriteLine("Given the integer value:" );
            Console.WriteLine(" ");
            int i = int.Parse(Console.ReadLine());

           int rem = 0 ,j;
    
            while (i!=0 )
            {
                j = i % 10;
                rem = rem + j;
                i= i /10;
                Console.WriteLine(rem);

                
          
            }
        
        }

        static void Qset4_q4()
        {
             Console.WriteLine("Sum of digits located in the odd or even positions:");
            Console.WriteLine("");
        
            Console.WriteLine("Given integer:");
            int i = int.Parse(Console.ReadLine());
            int rem,sum1=0,sum2=0;

            while (i != 0)
            {
                //Console.WriteLine(i);
               // i = i / 10; 
               // Console.WriteLine(i);
                rem = i % 10;
                Console.WriteLine(rem);
                i = i / 10;
                Console.WriteLine(i);
                              
                            if (rem % 2 == 0)
                                {
                                   // Console.WriteLine("even" +rem);
                                    sum1 = sum1 + rem;
                                    Console.WriteLine("The sum of digits located in the even"+ sum1);
                                }
                                else if (rem%2==1)
                                {
                                   // Console.WriteLine("odd" +rem);
                                    sum2 = sum2 + rem;
                                    Console.WriteLine("The sum of digits located in the  odd" + sum2);
                                }
                 
            }

        }

        static void Qset4_q5()
        {
            {
                Console.WriteLine("count the number of odd/even digits in an integer:");
                Console.WriteLine("");
                Console.WriteLine("Given the number of integer:");
                int i = int.Parse(Console.ReadLine());

                int count = 0, attempt = 0;
                int rem = 0;
                while (i != 0)
                {
                    rem = i % 10;
                    Console.WriteLine(rem);
                    //i = i / 10;


                    if (rem % 2 == 0)
                    {
                        // Console.WriteLine("Even " + rem);
                        count++;
                    }
                    //Console.WriteLine("The number of even count digit is:" + count);


                    if (rem % 2 == 1)
                    {
                        // Console.WriteLine("Odd" + rem);
                        attempt++;
                    }
                    //Console.WriteLine("The number of odd count digit is:" + attempt);


                    i = i / 10;
                    Console.WriteLine("The number of even count digit is:" + count);
                    Console.WriteLine("The number of odd count digit is:" + attempt);
                }
            }
        }

        static void Qset4_q6()
        {
             Console.WriteLine("Sum of the odd/even digits of a given integer");
                Console.WriteLine("");

                Console.WriteLine("Given the integer number:");
                int i = int.Parse(Console.ReadLine());
                int count = 0,rem1=0,rem2=0,sum1=0,sum2=0;

            while (i != 0)
            {
                

                

                //Console.WriteLine("rem" + rem);
                Console.WriteLine(i);
                count++;

                Console.WriteLine(count);

                if (count % 2 == 1)
                {
                  
                  
                    rem1 = i % 10;
                    Console.WriteLine("rem1 " + rem1);
                    Console.WriteLine("odd:" + count);
                    sum1 = (sum1 + rem1);
                    Console.WriteLine("Sumodd:" + sum1);
                }
                else if (count % 2 == 0)
                {
                    rem2 = i % 10;
                    Console.WriteLine("rem2 " + rem2);
                    Console.WriteLine("even:" + count);
                    sum2 = (sum2 + rem2);
                   Console.WriteLine("sumeven:" + sum2);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                //Console.WriteLine("sum of odd is:" + sum1);
               // Console.WriteLine("sum of even is:" + sum2);
                i = i / 10;
            }
        
        }

        static void Qset4_q7()
        {
            {
                Console.WriteLine("Get the last digit of a given integer:");
                Console.WriteLine("");

                Console.WriteLine("Enter the integer number:");
                int i = int.Parse(Console.ReadLine());
                int rem = 0;
                while (i >= 10)
                {


                    i = i % 10;
                    Console.WriteLine("The last digit of the number is:" + i);



                }
            }
        }

        static void Qset4_q8()
        {
             Console.WriteLine("Get the first digit of the integer:");
            Console.WriteLine("");

            Console.WriteLine("Enter the integer nunmber:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int rem = 0;
            while (i != 0)
            {
                rem = i % 10;

                i = i / 10;
                // Console.WriteLine(i);

            }
            Console.WriteLine("First digit of the integer number is :" + rem);
        
        }

        static void Qset4_q9()
        {
                        Console.WriteLine("Find the digit with the maximum value:");
            Console.WriteLine("");
            int rem = 0;
            int i = 1890;
            int maxdigit = 0;
        
            while (i>0)
            {
                rem = i % 10;
               //Console.WriteLine(rem);
               maxdigit = Math.Max(maxdigit,rem);    //0,0 =0; 0,9=0; 9,8=9; 9,1=9

              
                i = i/10;
                
            }
            Console.WriteLine("maxdigit:" + maxdigit);
        
        }

        static void Qset4_q13()
        {
              Console.WriteLine(" Reverse a given integer number:" );
            Console.WriteLine(""); 
            Console.WriteLine("Given integer is: 1243");


            int N = 1243;
             int reversednumber = 0;
             int rem;
             while (N>0)
             {

                 rem = N % 10;
                Console.WriteLine(rem);
                 reversednumber = (reversednumber * 10 +rem);

                 N = N / 10;

                // Console.WriteLine(N);
             }             
        }
        

        static void Qset4_q14()
        {
              Console.WriteLine("Digital root:");
            Console.WriteLine("");

            int N = 8654;

            Console.WriteLine(N);
            while (N > 9)
            {
                int sum = 0;


                /* while (N != 0)
                 {
                     sum = (sum + N % 10);
                     Console.WriteLine(sum);
                     N = N / 10;
                     //Console.WriteLine(N);
                 }*/




                while (N != 0)
                {
                    sum = (sum + N % 10);
              
                    N = N / 10;
                    
                }
                N = sum;
                Console.WriteLine(sum);
            }
        
        }
        static void Qset4_q15()
        {
            Console.WriteLine("N divides N:");

            Console.WriteLine("");
            Console.WriteLine("Given the integer value:");
            int n1 = int.Parse(Console.ReadLine());
            bool result = true;
            int originalnumber = n1;
            
            while (n1 > 0)
            {
                int rem = n1 % 10;
                //Console.WriteLine(rem);
                if (originalnumber % rem != 0)
                {
                    result = false;
                    break;
                }


                n1 /= 10;
            }

                Console.WriteLine( "all digits of"+ originalnumber +"divided by" +originalnumber +" :" + result );
            
        }
        
        static void Qset4_q17()
        {
            Console.WriteLine("Palindrome or not:");
            Console.WriteLine("");
            Console.WriteLine("Given integer:");
            Console.WriteLine("");
            int digit = int.Parse(Console.ReadLine());
            int originaldigit, sum = 0;
            int rem = 0;
            originaldigit = digit;
            while (digit > 0)
            {

                rem = digit % 10;
                Console.WriteLine(rem);
                sum = ((sum * 10) + rem);

                digit = digit / 10;
            }
            if (originaldigit == sum)
            {
                Console.WriteLine(" It is a palindrome");

            }
            else
            {
                Console.WriteLine("It is  not a palindrome:");
            }
        }
        static void Qset4_q18()
        {
             Console.WriteLine("Using Long type palindrome or not:");
            Console.WriteLine("");
            Console.WriteLine("Given integer:");
            long number = int.Parse (Console.ReadLine());
            long originalnumber = number;
            
             long rem=0,sum=0;

            while (number > 0)
            {
                rem = number % 10;
                Console.WriteLine(rem);
                sum = ((sum * 10) + rem);
                Console.WriteLine(sum);
                number /= 10;

            }
            if (originalnumber == sum)
            {
                Console.WriteLine("It is a palindrom:");
            }
            else
            {
                Console.WriteLine("It is not a palindrome:");
            }
               
        }
        static void Qset4_q19()
        {
            Console.WriteLine("Maximum number that can be formed using the digits:");
            Console.WriteLine("");
            Console.WriteLine("Given the integer value:");
            int number = int.Parse(Console.ReadLine());

            int rem;

            int maximum = 0;
            int originalnumber = number;



            while (number > 0)
            {

                rem = number % 10;
                maximum = (Math.Max(maximum, rem));
                number = number / 10;
            }




            for (int i = maximum; i >= 0; i--)
            {

                number = originalnumber;
                while (number > 0)
                {
                    rem = number % 10;

                    // Console.WriteLine(rem);

                    number = number / 10;
                    if (i == rem)
                    {
                        Console.Write(i);
                    }
                }
            }
        }
        static void Qset4_q20()
        {
            {
                Console.WriteLine("Minimum number that can be formed using the digits:");
                Console.WriteLine("");
                Console.WriteLine("Given the integer value:");
                int number = int.Parse(Console.ReadLine());

                int rem;

                int minimum = 0;
                int originalnumber = number;



                while (number > 1000)
                {

                    rem = number % 10;
                    minimum = (Math.Min(minimum, rem));
                    number = number / 1000;
                }
                //Console.WriteLine(minimum);



                for (int i = minimum; i <= 1000; i++)
                {

                    number = originalnumber;
                    while (number < 0)
                    {
                        rem = number % 10;

                        // Console.WriteLine(rem);

                        number = number / 10;
                        if (i == rem)
                        {
                            Console.Write(i);
                        }

                    }

                }
            }
    
        }

       
    }
}
