// ?taski 1
// int n = Convert.ToInt32(Console.ReadLine());

// int[] a = new int[n];

// for (int i = 0; i < n; i++)
// {
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }

// int k = Convert.ToInt32(Console.ReadLine());

// for (int i = k; i < n - 1; i++)
// {
//     a[i] = a[i + 1];
// }

// for (int i = 0; i < n - 1; i++)
// {
//     Console.Write(a[i] + " ");
// }


// taski2
// int EvenCount(int n)
// {
//     int cnt = 0;
//     while (n > 0)
//     {
//         if (n % 2 == 0)
//         {
//             cnt++;
//         }
//         n /= 10;
//     }
//     return cnt;
// }
// int OddCount(int n)
// {
//     int cnt = 0;
//     while (n > 0)
//     {
//         if (n % 2 != 0)
//         {
//             cnt++;
//         }
//         n /= 10;
//     }
//     return cnt;
// }
// int DigitCount(int n)
// {
//     int cnt = 0;
//     while (n > 0)
//     {
//         cnt++;
//         n /= 10;
//     }
//     return cnt;
// }
// int SumDigit(int n)

// {
//     int sum = 0;
//     while (n > 0)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     return sum;
// }
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Even: " + EvenCount(n));
// System.Console.WriteLine("Odd: " + OddCount(n));
// System.Console.WriteLine("Total: " + DigitCount(n));
// System.Console.WriteLine("Sum of: " + SumDigit(n));


// taski3
// bool IsPalindrome(int n)
// {
//     int cnt = 0;
//     int cum = n;
//     while (cum > 0)
//     {
//         cnt = cnt * 10 + cum % 10;
//         cum /= 10;
//         if (cnt == n)
//         {
//           System.Console.WriteLine("Yes");
//         }
//         else
//         {
//           System.Console.WriteLine("No");
//         }
//     }
//     return cnt == n;
// }
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(IsPalindrome(n));


// taski 4
// int SumOfDigits(int n)
// {
//     int sum = 0;
//     for (int i = n; i > 0; i--)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     return sum;
// }
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("The sum of the digits of the number 1234 is : " + SumOfDigits(n));

// taski 5



// void IncrementArrayElements(ref int[] arr, ref int n)
// {
//     for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
//     for (int i = 0; i < n; i++)
//     {
//         arr[i] += n;
//         Console.Write(arr[i] + " ");
//     }
// }
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// IncrementArrayElements(ref arr, ref n);

// taski 6

// void Swap(ref int a, ref int b)
// {
//     int cnt = a;
//     a = b;
//     b = cnt;
// }

// int x =Convert.ToInt32(Console.ReadLine());
// int y =Convert.ToInt32(Console.ReadLine());

// Swap(ref x, ref y);
// Console.WriteLine("x=" + x);
// Console.WriteLine("y=" + y);

// taski 7


// int sumDigit(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     return n % 10 + sumDigit(n / 10);
// }

// Console.WriteLine(sumDigit(111));
// Console.WriteLine(sumDigit(222));
// Console.WriteLine(sumDigit(333));


// taski 8
 
// string RRR(string n1, int a)
// {
//     string result = "";

//     for (int i = 0; i < a; i++)
//     {
//         result += n1;
//     }

//     return result;
// }
// Console.WriteLine(RRR("ab", 3));
// Console.WriteLine(RRR("cherry", 2));
// Console.WriteLine(RRR("kiwi", 1));




