using System;
namespace task{
class task{
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
        public student( string name , int age , int year , float gpa){
            this.name = name;
            this.age = age;
            this.year = year;
            this.gpa = gpa;
        }
        public override void print(){
            Console.WriteLine("My name is " + name + "My age is " + age +"and my gpa is " + gpa);
        }

    }
    }
    public static void Main(){

    }
}
