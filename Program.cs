using System;

public class Program
{
    static void Main(string[] args)
    {
        long capitalKFC = InputcapitalKFC();
        string branchname = Inputbranch_name();
        string adress = InputAdress();
        string Name = InputName();
        string surname = Inputsurname();
        long ID = InputID();
        string Name2 = InputName2();
        string surname2 = Inputsurname2();
        long ID2 = InputID2();      
        string Name3 = InputName2();
        string surname3 = Inputsurname2();
        long ID3 = InputID2();
        string position = Inputposition();
        string Name4 = InputName3();
        string surname4 = Inputsurname3();
        long age = Inputage();
        long Money = InputMoney();
        string position2 = Inputposition2();
        string Name5 = InputName4();
        string surname5 = Inputsurname4();
        long age2 = Inputage2();
        long Money2 = InputMoney2();
        string position3 = Inputposition3();
        string Name6 = InputName5();
        string surname6 = Inputsurname5();
        long age3 = Inputage();
        long Money3 = InputMoney();
        string position4 = Inputposition4();
        string Name7 = InputName6();
        string surname7 = Inputsurname6();
        long age4 = Inputage4();
        long Money4 = InputMoney4();
        string position5 = Inputposition5();
        string Name8 = InputName7();
        string surname8 = Inputsurname7();
        long age5 = Inputage5();
        long Money5 = InputMoney5();
        Data data = new Data();
        Data1 data1 = new Data1();
        Data2 data2 =  new Data2();
        Data3 data3 = new Data3();
        Data4 data4 = new Data4();
        Data5 data5 = new Data5();
        Data6 data6 = new Data6();
        Data7 data7 = new Data7();
        data.OutputData(capitalKFC,branchname,adress,Name, surname, ID);
        data1.OutputData(Name2, surname2, ID2);
        data2.OutputData(Name3, surname3, ID3);
        data3.OutputData(position,Name4, surname4, age,Money);
        data4.OutputData(position2,Name5, surname5, age2,Money2);
        data5.OutputData(position3,Name6, surname6, age3,Money3);
        data6.OutputData(position4,Name7, surname7, age4,Money4);
        data7.OutputData(position5,Name8, surname8, age5,Money5);
    }
    public static long InputcapitalKFC()
    {
        Console.Write("Please Input capital: ");
        return long.Parse(Console.ReadLine());
    }
    public static string Inputbranch_name()
    {
        Console.Write("Please Input Branch name: ");
        return Console.ReadLine();
    }
    public static string InputAdress()
    {
        Console.Write("Please Input adress: ");
        return Console.ReadLine();
    }
    public static string InputName()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static string Inputsurname()
    {
        Console.Write("Please Input Surname: ");
        return Console.ReadLine();
    }
    public static long InputID()
    {
        Console.Write("Please Input ID: ");
        return long.Parse(Console.ReadLine());
    }
    public static string InputName2()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static string Inputsurname2()
    {
        Console.Write("Please Input Surname: ");
        return Console.ReadLine();
    }
    public static long InputID2()
    {
        Console.Write("Please Input ID: ");
        return long.Parse(Console.ReadLine());
    }
    public static string Inputposition()
    {
        Console.Write("Please Input position: ");
        return Console.ReadLine();
    }
    public static string InputName3()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static string Inputsurname3()
    {
        Console.Write("Please Input Surname: ");
        return Console.ReadLine();
    }
    public static long Inputage()
    {
        Console.Write("Please Input age: ");
        return long.Parse(Console.ReadLine());
    }
    public static long InputMoney()
    {
        Console.Write("Please Input Money: ");
        return long.Parse(Console.ReadLine());
    }

     public static string Inputposition2()
    {
        Console.Write("Please Input position: ");
        return Console.ReadLine();
    }
    public static string InputName4()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static string Inputsurname4()
    {
        Console.Write("Please Input Surname: ");
        return Console.ReadLine();
    }
    public static long Inputage2()
    {
        Console.Write("Please Input age: ");
        return long.Parse(Console.ReadLine());
    }
    public static long InputMoney2()
    {
        Console.Write("Please Input Money: ");
        return long.Parse(Console.ReadLine());
    }
 public static string Inputposition3()
    {
        Console.Write("Please Input position: ");
        return Console.ReadLine();
    }
    public static string InputName5()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static string Inputsurname5()
    {
        Console.Write("Please Input Surname: ");
        return Console.ReadLine();
    }
    public static long Inputage3()
    {
        Console.Write("Please Input age: ");
        return long.Parse(Console.ReadLine());
    }
    public static long InputMoney3()
    {
        Console.Write("Please Input Money: ");
        return long.Parse(Console.ReadLine());
    }

public static string Inputposition4()
    {
        Console.Write("Please Input position: ");
        return Console.ReadLine();
    }
    public static string InputName6()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static string Inputsurname6()
    {
        Console.Write("Please Input Surname: ");
        return Console.ReadLine();
    }
    public static long Inputage4()
    {
        Console.Write("Please Input age: ");
        return long.Parse(Console.ReadLine());
    }
    public static long InputMoney4()
    {
        Console.Write("Please Input Money: ");
        return long.Parse(Console.ReadLine());
    }
public static string Inputposition5()
    {
        Console.Write("Please Input position: ");
        return Console.ReadLine();
    }
    public static string InputName7()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static string Inputsurname7()
    {
        Console.Write("Please Input Surname: ");
        return Console.ReadLine();
    }
    public static long Inputage5()
    {
        Console.Write("Please Input age: ");
        return long.Parse(Console.ReadLine());
    }
    public static long InputMoney5()
    {
        Console.Write("Please Input Money: ");
        return long.Parse(Console.ReadLine());
    }
    public static double ConvertStringToDouble(string ID)
    {
        if (double.TryParse(ID, out double capitalKFC))
        {
            return capitalKFC;
        }
        throw new Exception("Please Input your Registered_Value again!");
    }
    public static double ConvertStringToDouble2(string capitalKFC)
    {
        if (double.TryParse(capitalKFC, out double ID))
        {
            return ID;
        }
        throw new Exception("Please Input your Registered_Value again!");
    }
     public static double ConvertStringToDouble3(string age)
    {
        if (double.TryParse(age, out double ID))
        {
            return ID;
        }
        throw new Exception("Please Input your Registered_Value again!");
    }
     public static double ConvertStringToDouble4(string Money)
    {
        if (double.TryParse(Money, out double ID))
        {
            return ID;
        }
        throw new Exception("Please Input your Registered_Value again!");
    }
   public class storesales
{
    static double storefront(double x)
    {
        return x = x * 127;
    }
}
    public class Data
    {
        public void OutputData(long capitalKFC,string branchname,string adress,string Name,string surname,long ID)
        {
            Console.WriteLine("—--------- Information —---------");
            Console.WriteLine("CapitalKFC: {0}",capitalKFC);
            Console.WriteLine("Branch name: {0}",branchname);
            Console.WriteLine("Adress: {0}",adress);
            Console.WriteLine("----------Shop registration applicant------------");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("—-----------------------------------------------------");
        }
    }
    public class Data1
    {
        public void OutputData(string Name2,string surname2,long ID2)
        {
            Console.WriteLine("Name: {0}", Name2);
            Console.WriteLine("Surname: {0}", surname2);
            Console.WriteLine("ID: {0}", ID2);
            Console.WriteLine("—-----------------------------------------------------");
        }
    }
    public class Data2
    {
        public void OutputData(string Name3,string surname3,long ID3)
        {
            Console.WriteLine("Name: {0}", Name3);
            Console.WriteLine("Surname: {0}", surname3);
            Console.WriteLine("ID: {0}", ID3);
            Console.WriteLine("—-----------------------------------------------------");
        }
}
public class Data3
    {
        public void OutputData(string position,string Name4,string surname4,long age,long Money)
        {
            Console.WriteLine("-----------personnel-----------");
            Console.WriteLine("Position: {0}",position);
            Console.WriteLine("Name: {0}", Name4);
            Console.WriteLine("Surname: {0}", surname4);
            Console.WriteLine("age: {0}", age);
            Console.WriteLine("salary: {0}",Money) ;
            Console.WriteLine("—-----------------------------------------------------");
        }
}
public class Data4
    {
        public void OutputData(string position2,string Name5,string surname5,long age2,long Money2)
        {
            Console.WriteLine("Position: {0}",position2);
            Console.WriteLine("Name: {0}", Name5);
            Console.WriteLine("Surname: {0}", surname5);
            Console.WriteLine("age: {0}", age2);
            Console.WriteLine("salary: {0}",Money2) ;
            Console.WriteLine("—-----------------------------------------------------");
        }
}
public class Data5
    {
        public void OutputData(string position3,string Name6,string surname6,long age3,long Money3)
        {
            Console.WriteLine("Position: {0}",position3);
            Console.WriteLine("Name: {0}", Name6);
            Console.WriteLine("Surname: {0}", surname6);
            Console.WriteLine("age: {0}", age3);
            Console.WriteLine("salary: {0}",Money3) ;
            Console.WriteLine("—-----------------------------------------------------");
        }
}
public class Data6
    {
        public void OutputData(string position4,string Name7,string surname7,long age4,long Money4)
        {
            Console.WriteLine("Position: {0}",position4);
            Console.WriteLine("Name: {0}", Name7);
            Console.WriteLine("Surname: {0}", surname7);
            Console.WriteLine("age: {0}", age4);
            Console.WriteLine("salary: {0}",Money4) ;
            Console.WriteLine("—-----------------------------------------------------");
        }
}
public class Data7
    {
        public void OutputData(string position5,string Name8,string surname8,long age5,long Money5)
        {
            Console.WriteLine("Position: {0}",position5);
            Console.WriteLine("Name: {0}", Name8);
            Console.WriteLine("Surname: {0}", surname8);
            Console.WriteLine("age: {0}", age5);
            Console.WriteLine("salary: {0}",Money5) ;
            Console.WriteLine("—-----------------------------------------------------");
        }
}
}