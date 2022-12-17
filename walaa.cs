using System;
namespace task;
    class  person{
       private string _name;
       public string Name
           {
             get
                {
                    return _name;
                }
             set
                {
                      if(value == null || value=="" || value.Length>=32)
                                   {
                                        throw new Exception("invalid name");
                                }
                      _name=value;
                       }
            }
        private int _Age;
        public Person(string name,int age)
                   {
                        if(name == null || name=="" || name.Length>=32)
                                  {
                                         throw new Exception("invalid name");
                                  }
                        if (age<=0 ||age>=128){
                                       Console.WriteLine("invalid age");
                                       return;
                                             }
                         Name=name;
                         _Age =age;
                                  }

         public int Getage() =>_Age;


       public virtual  void Print()
                          {
                                Console.WriteLine($"My name is {Name}, my age is {_Age}");
                          }

         }
    public class student : person{
         private int _Year;
         public int Year
                          {
                              get
                                   {
                                       return _Year;
                                   }
                              set
                                    {
                                        _Year=value;
                                    }
                         }
        private float _Gpa;
        public float Gpa
                   {
                         get
                              {
                                 return _Gpa;
                              }
                        set
                           {
                                 _Gpa=value;
                           }
                    }
        public Student(string name,int age,int year,float gpa ):base(name, age)
            {
                if (year<1 ||year>5)
                   {
                        throw new Exception("invalid year");
                   }
                if(gpa<0 ||gpa>4)
                    {
                        throw new Exception("invalid gpa");
                    }
                Year=year;
               Gpa=gpa;
            }
       public override void Print()
                 {
                     Console.WriteLine($"my name is{Name},my age is {Getage()},and my gpa is{Gpa}");
                 }
                }


    public class database{
        private int _currentIndex;
        public person[] people = new person[50];

        public void addstudent(student stud){
            people[_currentIndex++] = stud;
        }
        public void addstaff(staff staf){
            people[_currentIndex++] = staf;
        }
        public void PrintAll()
          {
            for(var i = 0 ; i <_current; i++)
                 {
                     Peple[i].Print();
                 }
  }


    }
    class staff : person{
        public double salary;
        public int joinyear;
        public staff(double salary , int joinyear) : base(name , age){
            this.salary = salary;
            this.joinyear = joinyear;
        }
        public override void print(){
            Console.WriteLine("My name is " + name + "My age is " + age +"and my salary is " + salary);
        }
    }
    public class task{
       public static void Main(){
        var data = new database();
        Console.WriteLine("Name: ");
        var _name = Console.ReadLine();
        Console.WriteLine("Age: ");
        var _age =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Year: ");
        var _year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Gpa: ");
        var _gpa = Convert.ToSingle(Console.ReadLine());
        var stud = new student(_name , _age , _year , _gpa);

    }
    }
