using System;
namespace task{

    class  abstract person{
       public string name;
       public int age;
      public person ( string name , int age){
        this.name = name;
        this.age = age;
       }
       public abstract void print(){

        }
    }
    class student : person{
        public int year;
        public float gpa;
        public student( string name , int age , int year , float gpa) : base(name , age){
            this.year = year;
            this.gpa = gpa;
        }
        public override void print(){
            Console.WriteLine("My name is " + name + "My age is " + age +"and my gpa is " + gpa);
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

    }
    public class task{
    public static void Main(){
        

    }
    }
