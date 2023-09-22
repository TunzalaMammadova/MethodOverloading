


//public static class Class1
//{
//   public static void Test()
//    {
//        Console.WriteLine("test1");

//    }

//    public static void Test(int a)
//    {
//        Console.WriteLine("test2");

//    }


//    public static void Test(string a)
//    {
//        Console.WriteLine("test3");

//    }


//}



public static class Class1
{
    public static int Sum()
    {
        return -1;
    }

    public static int Sum(int a)
    {
        return a;
    }

    public static int Sum(int a,int b)
    {
        return a + b;
    }

    public static int Sum(int a, int b, int c)
    {
        return a + b + c;

    }

    public static int Sum(int[]nums)
    {
        int sum = 0;

        foreach (var item in nums)
        {
            sum += item;

        }
        return sum;
    }



}