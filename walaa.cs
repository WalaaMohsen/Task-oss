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
        public student( string name , int age , int year , float gpa) : base(name , age){
            this.name = name;
            this.age = age;
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
    }

    }
    public static void Main(){

    }
}
