
//static void Test(int number)
//{
//    Console.WriteLine("Hello World");
//}

//Test(50);



//static void Test1(int number=100)
//{
//    Console.WriteLine("Hello World----" + 100);
//}

//Test1();




//static void Test3(int number = 100)
//{
//    Console.WriteLine("Hello World----" + number);
//}

//Test3(5);




//static void Test(params int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}



//Test(1,4,5,6,7);





//static void Test(int a , params int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}



//Test(1, 4, 5, 6, 7);



//static void Test(int a, params int[] arr)
//{
//    int sum = 0;

//    foreach (var item in arr)
//    {
//        sum += item;
//    }

//    int result = sum * a;

//    Console.WriteLine(result);
//}



//Test(2, 4, 5, 6, 7);



//Class1.Test(5);

//Class1.Test();

//Console.WriteLine(Class1.Sum());


//Console.WriteLine(Class1.Sum(5));


//Console.WriteLine(Class1.Sum(8,9,6));



//int a = 100;
//int b = a;
//b = 200;

//Console.WriteLine(a);
//Console.WriteLine(b);



//string name = "test";
//string surname = name;
//surname = "salamlar";

//Console.WriteLine(name);
//Console.WriteLine(surname);


//int[] arr = { 1, 2, 3 };
//int[] arr2 = arr;

//arr2[0] = 300;

//Console.WriteLine(arr[0]);

//Console.WriteLine(arr2[0]);


//int[] nums = { 2, 3, 4, 5 };

//Console.WriteLine(nums[0]);

//Test(nums);

//Console.WriteLine(nums[0]);

//static void Test(int[] arr)
//{
//    arr[0] = 5;
//    Console.WriteLine(arr[0]+10);
//}


//int b=2;

//Console.WriteLine(b);

//Test(ref b);

//Console.WriteLine(b);


//static void Test(ref int a)
//{
//    Console.WriteLine(a);

//}




//int b = 2;

//Console.WriteLine(b);

//Test(out b);

//Console.WriteLine(b);


//static void Test(out int a)
//{
//    a = 300;

//    Console.WriteLine(a);

//}


//int a = 5;
//int b = a++;

//Console.WriteLine(a);

//Console.WriteLine(b);


//int a = 5;

//a++;

//int b = a;

//Console.WriteLine(a);

//Console.WriteLine(b);



//int a = 5;

//int b = ++a;

//Console.WriteLine(a);

//Console.WriteLine(b);


//int a = 5;
//int c = 10;

//int b = ++a;

//a++;

//c = --a;

//Console.WriteLine(a);

//Console.WriteLine(b);

//Console.WriteLine(c);


//int[] nums1 = { 1, 2, 3, 4, 5 };

//int a = nums1[0];

//int b = a++;

//int[] nums2 = nums1;

//nums2[0] = a;

//Test(nums2);

//Console.WriteLine(nums1[0]);

//static void Test(int[] arr)
//{
//    arr[0] = 50;

//}

//string name1 = "Test";
//string name2 = "test";


//Console.WriteLine(name1.ToLower().Trim() == name2.ToLower().Trim());

//Console.WriteLine(name2.Length);

//Console.WriteLine(name1.Replace("T","t"));



//string str = "Azerbaycan";

//var data = str.ToCharArray();

//Console.WriteLine(data[0]);

//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str[i]);
//}

//Console.WriteLine(str.Contains("a"));

//string str1 = "baku";
//string str2 = "azerbaycan";

//string result = string.Concat(str1, " ", str2);

//Console.WriteLine(result);


//static int GetCountWichCondition(string str, string[] words)
//{
//    int count = 0;
//    foreach (var item in words)
//    {
//        if (words.StartsWith(str))
//        {
//            count++;

//        }

//        return count;

//    }
    
//}

//Console.WriteLine("add string:");

//string str = Console.ReadLine();

//string[] words = { "T1", "Test", "Baku" };

//int count = GetCountWichCondition(str, words);

//Console.WriteLine(count);