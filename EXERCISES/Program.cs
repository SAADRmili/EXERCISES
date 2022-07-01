
class Program
{
    static void Main(string[] args)
    {
        var list1 = new List<int>() { 0,1,5,4,8,66,88,15,20,123,2,4,3,6,8};
        var query1 = list1.Where(x => x %2 == 0).ToList();

        Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
        foreach (int VrNum in query1)
        {
            Console.Write("{0} ", VrNum);
        }
        Console.Write("\n\n");


        var list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11,-12,0,12 };
        var query2 = list2.Where(x=> x>0 && x<12).ToList();

        Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
        foreach (var VrNum in query2)
        {
            Console.Write("{0}  ", VrNum);
        }

        Console.Write("\n\n");

      
        var query3 = list2.Where(x=> x*x >20).Select(x => new
        {
            Number = x,
            SqrNo = x * x
        });
        Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : \n" );

        foreach (var a in query3)
            Console.WriteLine(a);
        Console.Write("\n\n");



        var query4 = list1.GroupBy(x => x).Select(x => new
        {
            Key = x.Key,
            Count = x.Count()
        });

        Console.WriteLine("\nThe number and the Frequency are : \n");
        foreach (var arrNo in query4)
        {
            Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count + " times");
        }
        Console.WriteLine("\n");



        var str = "apple"; 

        var query5 = str.GroupBy(x=>x).Select(x => new
        {
            Key = x.Key,
            Count = x.Count()
        });

        Console.Write("The frequency of the characters are :\n");
        foreach (var ArrEle in query5)
        {
            Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count + " times");
        }

        Console.WriteLine("\n");


        var dayOfWeeks = new List<string>() { "Sunday", "Monday","Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        Console.Write("\nLINQ : Display the name of the days of a week : \n");

        foreach (var WeekDay in dayOfWeeks)
        {
            Console.WriteLine(WeekDay);
        }
        Console.WriteLine("\n");



        var list = new List<int>() { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

        var query7 = list.GroupBy(x => x).Select(x => new
        {
            Key =x.Key,
            Count = x.Count(),
            Multiple = x.Key *  x.Count()
        });
        Console.Write("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
        Console.Write("------------------------------------------------\n");

        foreach (var arrEle in query7)
        {
            Console.WriteLine(arrEle.Key + "\t" + arrEle.Multiple + "\t\t\t" + arrEle.Count);
        }
        Console.WriteLine("\n");


        //var cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        //char starChar, finChar;
        //Console.Write("\nInput starting character for the string : ");

        //char.TryParse(Console.ReadLine(), out starChar);

        //Console.Write("\nInput ending character for the string : ");
        //char.TryParse(Console.ReadLine(), out finChar);


        //var query8 = cities.Where(x => x.StartsWith(starChar.ToString().ToUpper()) && x.EndsWith(finChar.ToString().ToUpper()));

        //Console.Write("\nLINQ : Find the string which starts and ends with a specific character : \n");
        //foreach (var city in query8)
        //{
        //    Console.Write("The city starting with {0} and ending with {1} is : {2} \n", starChar, finChar, city);
        //}
        Console.WriteLine("\n");



        var list3 = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };

        var query9 = list3.Where(x => x >= 80).OrderByDescending(x => x);

        Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
        Console.Write("\n-------------------------------------------------------------------------\n");
        Console.WriteLine("\nThe members of the list are : ");
        foreach (var lstnum in query9)
        {
            Console.Write(lstnum + " \n");
        }


        Console.WriteLine("\n");
        //var numbers = new List<int>();
        //int n, added;

        //Console.Write("Input the number of members on the List : ");
        //n = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i< n; i++)
        //{
        //    Console.Write($"Member {i} :");
        //    added = Convert.ToInt32(Console.ReadLine());
        //    numbers.Add(added);
        //}


        //Console.Write("Input the value above you want to display the members of the List :");
        //int num = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"The numbers greater than {num} are :");

        //var query10 = numbers.Where(x => x > num).ToList();

        //foreach (var item in query10)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("\n");


        var list4 = new List<int>() { 5,7,13,24,6,9,8,7};

        Console.Write("How many records you want to display ? :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        var query11 = list4.OrderByDescending(x => x).Take(num1).ToList();

        Console.WriteLine($"The top {num1} records from the list are");

        foreach (var item in query11)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("\n");



        string s1 = "this IS a STRING are KOKO";

        var query12 = s1.Split(' ').Where(x=>string.Equals(x,x.ToUpper(),StringComparison.Ordinal));


        Console.Write("\nThe UPPER CASE words are :\n ");

        foreach (string strRet in query12)
        {
            Console.WriteLine(strRet);
        }


        Console.WriteLine("\n");   
        //var elements = new List<string>();

        //Console.Write("Input number of strings to store in the array : ");
        //int  k = Convert.ToInt32(Console.ReadLine());
        //string element ="";

        //for (int i = 0; i < k ; i++)
        //{
        //    Console.Write($"Element {i} :");
        //    element = Console.ReadLine();
        //    elements.Add(element);
        //}

        //Console.WriteLine("Here is the string below created with elements of the above array :");
        //foreach (var item in elements)
        //{
        //    Console.Write(item+", ");
        //}
        //Console.WriteLine("\n");

        var students = new List<Student>()
        {
            new Student() { Id = 1, Name ="SAAD",Achieved=200},
            new Student() { Id = 2, Name ="MEHDI",Achieved=200},
            new Student() { Id = 3, Name ="koko",Achieved=900},
            new Student() { Id = 4, Name ="kiki",Achieved=700},
            new Student() { Id = 5, Name ="DODO",Achieved=200},
            new Student() { Id = 7, Name ="David",Achieved=750},
            new Student() { Id = 8, Name ="leo",Achieved=750},
            new Student() { Id = 6, Name ="SAD",Achieved=500},
            new Student() { Id = 9, Name ="SD",Achieved=400},
        };


        Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : ");
        int k = Convert.ToInt32(Console.ReadLine());
        int r = 1;

        var query13 = students.GroupBy(x => x.Achieved).OrderByDescending(x=>x.Key).Select(x => new
        {
            Key = x.Key,
            Rank = r++,
            Stud = x.Select(x => x),
        }).Where(r=>r.Rank == k);

        foreach (var item in query13)
        {
            
            foreach (var i in item.Stud)
            {
                Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.Id, i.Name, i.Achieved);
            }
        }



        Console.WriteLine("\n");

        var Files = new List<string>()
        {
             "aaa.frx", "bbb.TXT", "xyz.dbf","abc.pdf","aaaa.PDF","xyz.frt", "abc.xml", "ccc.txt", "zzz.txt"
        };

        var query14 = Files.GroupBy(x => Path.GetExtension(x).ToLower()).OrderBy(x => x.Key).Select(x => new
        {
            Ext = x.Key,
            Count = x.Count()
        });
        Console.WriteLine("Here is the group of extension of the files :");

        foreach (var item in query14)
        {
            Console.WriteLine($"{item.Count} File(s) with {item.Ext} Extension");
        }

        Console.WriteLine("\n");

        //string[] dirfiles = Directory.GetFiles("/home/w3r/abcd/");

        //Console.Write("\nLINQ : Calculate the size of file : ");
        //Console.Write("\n------------------------------------\n");


        //var query15 = dirfiles.Select(x => new FileInfo(x).Length).Average();

        //Console.WriteLine("The Average file size is {0} MB", query15);

        //Console.WriteLine("\n");

        List<string> listOfString1 = new List<string>()
        {
            "m","n","o","p","q"
        };

        Console.Write("Here is the list of items : \n");
        foreach (var tchar in listOfString1)
        {
            Console.WriteLine("Char: {0} ", tchar);
        }

        Console.Write("\nHere is the list after removing the item 'o' from the list : \n");
      
        var query16  = listOfString1.FirstOrDefault(x=>x == "o");

        listOfString1.Remove(query16);
      
        foreach (var rChar in listOfString1)
        {
            Console.WriteLine("Char: {0} ", rChar);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");
        List<string> listOfString2 = new List<string>()
        {
            "m","n","o","p","q"
        };

        Console.Write("Here is the list of items : \n");
        foreach (var tchar in listOfString2)
        {
            Console.WriteLine("Char: {0} ", tchar);
        }

        Console.Write("\nHere is the list after removing the item 'p' from the list : \n");

        var query17 = listOfString2.Remove(listOfString2.FirstOrDefault(x => x == "p"));

        
        foreach (var rChar in listOfString2)
        {
            Console.WriteLine("Char: {0} ", rChar);
        }
        Console.WriteLine("\n");



        Console.WriteLine("---------------------------");

        List<string> listOfString3 = new List<string>()
        {
            "m","n","o","p","q"
        };

        Console.Write("Here is the list of items : \n");
        foreach (var tchar in listOfString3)
        {
            Console.WriteLine("Char: {0} ", tchar);
        }

        Console.Write("\nHere is the list after removing the item 'q' from the list : \n");

        var query18 = listOfString3.RemoveAll(x => x == "q");


        foreach (var rChar in listOfString3)
        {
            Console.WriteLine("Char: {0} ", rChar);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");

        List<string> listOfString4 = new List<string>()
        {
            "m","n","o","p","q"
        };

        Console.Write("Here is the list of items : \n");
        foreach (var tchar in listOfString4)
        {
            Console.WriteLine("Char: {0} ", tchar);
        }

        Console.Write("\nHere is the list after removing the item 3 from the list : \n");

        listOfString4.RemoveAt(3);


        foreach (var rChar in listOfString4)
        {
            Console.WriteLine("Char: {0} ", rChar);
        }
        Console.WriteLine("\n");


        Console.WriteLine("---------------------------");
        List<string> listOfString5 = new List<string>()
        {
            "m","n","o","p","q"
        };

        Console.Write("Here is the list of items : \n");
        foreach (var tchar in listOfString5)
        {
            Console.WriteLine("Char: {0} ", tchar);
        }

        Console.Write("\nHere is the list after removing the three items starting from the item index 1 from the list : \n");

        listOfString5.RemoveRange(1,3);


        foreach (var rChar in listOfString5)
        {
            Console.WriteLine("Char: {0} ", rChar);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");


        var letterLists1 = new List<string>() {"X" };
        var numberLists1 = new List<int>() { 1,2,3,4,5,6,7,8,9};
        Console.Write("\nLINQ : Generate a cartesian product of two sets : ");

        var query19 = letterLists1.SelectMany(x => numberLists1.Select(y => new
        {
            letterList = x,
            numberList = y
        }));
        Console.Write("The cartesian product are : \n");
        foreach (var productItem in query19)
        {
            Console.WriteLine(productItem);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");

        var letterLists2 = new List<string>() { "X" ,"Y"};
        var numberLists2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var Colours = new List<string>() { "Orange","Green"};
        Console.Write("\nLINQ : Generate a cartesian product of three sets : ");

        var query20 = letterLists2.SelectMany(x => numberLists2.SelectMany(y => Colours.Select(z => new
        {
            letter = x,
            number = y,
            colour = z 
        }))) ;

        Console.Write("The Cartesian Product are : \n");
        foreach (var ProductList in query20)
        {
            Console.WriteLine(ProductList);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");


        var prodcuts = new List<Product>()
        {
            new Product() { Id=1,Name="Biscuit",Price=1} ,
            
            new Product() { Id=2,Name="Chocolate",Price=2.0} ,  
            new Product() { Id=3,Name="Butter ",Price=15.0} ,  
            new Product() { Id=4,Name="Brade",Price=10.0} ,  
            new Product(){ Id=5,Name="Honey ",Price =0},
            new Product(){ Id=7,Name="Honey ",Price =0},
            new Product(){ Id=6 ,Name="Biscuit",Price =1},

        };

        var purchases = new List<Purchase>()
        {
            new Purchase(){ Id=1, IdProduct= 1,Quantity=458},
            new Purchase(){ Id=2, IdProduct= 2,Quantity=650},
            new Purchase(){ Id=3, IdProduct= 3,Quantity=800},
            new Purchase(){ Id=4, IdProduct= 3,Quantity=900},
            new Purchase(){ Id=5, IdProduct= 3,Quantity=900},
            new Purchase(){ Id=6, IdProduct= 4,Quantity=700},
            new Purchase(){ Id=7, IdProduct= 4,Quantity=650},
        };
        Console.Write("\nHere is the list after joining  : \n\n");


        var query21 = prodcuts.Join(purchases, p => p.Id, pu => pu.IdProduct, (p, pu) => new
        {
            ItemID = p.Id,
            ItemName = p.Name,
            PurchaseQuantity = pu.Quantity,
        }).ToList();

        Console.WriteLine("Item ID\t\tItem Name\t\tPurchase Quantity");
        Console.WriteLine("-------------------------------------------------------");
        foreach (var data in query21)
        {
            Console.WriteLine(data.ItemID + "\t\t" + data.ItemName + "\t\t\t" + data.PurchaseQuantity);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");

        Console.Write("\nHere is the list after joining  : \n\n");
        var query22 = prodcuts.GroupJoin(purchases , p=>p.Id , pu => pu.IdProduct , (p,pu)=> new
        {
           p,pu

        } ).SelectMany(x=> x.pu.DefaultIfEmpty(), (x,y)=> new
        {
            ItemID =x.p.Id,
            ItemName = x.p.Name,
            PurchaseQuantity = y  == null ? 0 : y.Quantity,
        });

        Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
        Console.WriteLine("-------------------------------------------------------");
        foreach (var data in query22)
        {
            Console.WriteLine(data.ItemID + "\t\t" + data.ItemName + "\t\t" + data.PurchaseQuantity);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");
        Console.Write("\nLINQ : Generate a Right Join between two data sets : ");
        Console.Write("\n--------------------------------------------------\n");
        var purchases2 = new List<Purchase>()
        {
            new Purchase { Id=100, IdProduct = 3,  Quantity = 800 },
           new Purchase { Id=101, IdProduct = 5,  Quantity = 650 },
           new Purchase {Id = 102, IdProduct = 3, Quantity = 900},
           new Purchase {Id = 103, IdProduct = 4, Quantity = 700},
           new Purchase {Id = 104, IdProduct = 3, Quantity = 900},
           new Purchase {Id = 105, IdProduct = 4, Quantity = 650},
           new Purchase {Id = 106, IdProduct = 1, Quantity = 458}
        };
        Console.Write("\nHere is the list after joining  : \n\n");
        var query23 = purchases2.GroupJoin(prodcuts, a => a.IdProduct, b => b.Id, (a,b) => new
        {
            a,b

        }).SelectMany(x => x.b.DefaultIfEmpty(), (x, y) => new
        {
            ItemID = y.Id,
            ItemName = y.Name,
            PurchaseQuantity = y == null ? 0 : x.a.Quantity,
        });
        Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
        Console.WriteLine("-------------------------------------------------------");
        foreach (var data in query23)
        {
            Console.WriteLine(data.ItemID + "\t\t" + data.ItemName + "\t\t" + data.PurchaseQuantity);
        }



        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");


        var  cities = new List<string>()
          {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };


        var query24 = cities.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 3)
            .Select(x => x.Select(v => v.Value).ToList());

        foreach (var item in query24)
        {
            Console.WriteLine(string.Join(";  ", item.ToArray()));
            Console.WriteLine("-- here is a group of cities --\n");
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------");

        Console.Write("\nLINQ : Arrange distinct elements in the list in ascending order : \n");

        var query25 = prodcuts.Select(x => x.Name).OrderBy(x=>x).Distinct().ToList();
        foreach (var item in query25)
        {
            Console.WriteLine(item);
        }
            
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Achieved { get; set; }
    }


    public class Product
    {
        public  int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
    }


    public class Purchase
    {
        public int Id { get; set; }

        public int IdProduct { get; set; }  

        public int Quantity { get; set; }
    }

}
    