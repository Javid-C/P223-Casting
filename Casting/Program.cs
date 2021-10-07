using System;

namespace Casting
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Classwork and Homework
			//Console.WriteLine(Calculator.Calc(10, 5, '+'));

			//string str = "Brat ordan xalodni getir";

			//Console.WriteLine(str.CustomContain("or"));
			#endregion

			int num = 5;
			int? num2 = null;
			string okay = null;

			Human human = new Human();
			human.Name = "Vusal";
			Teacher teacher = new Teacher();
			teacher.School = "999";

			//human.ShowInfo();
			//teacher.ShowInfo();

			//human = teacher;

			//human.ShowInfo();



			//upcasting, implicit, boxing
			Samoyed samoyed = new Samoyed();
			//Dog dog = new Samoyed();

			Dog dog = samoyed;

			//Console.WriteLine(dog.GetType());

			Animal sam = new Samoyed();

			Animal lionfish = new LionFish();

			LionFish lion = (LionFish)lionfish;

			//lion = sam as LionFish;
			//Console.WriteLine(lion==null);
			//lion.Poison = "Deadly";
			//if(sam is LionFish)
			//{
			//	lion = (LionFish)sam;
			//}
			//else
			//{
			//	Console.WriteLine("Error");
			//}
			//Manat manat = new Manat() { Azn = 200};

			//Dollar dollar = (Dollar)manat;

			//Console.WriteLine(dollar.Usd);

			Person person1 = new Person("Ahad","Tagiyev",22);
			Person person2 = new Person("Nurxan","Masimzade",22);

			Console.WriteLine(person1==person2);
			Console.WriteLine(person1+person2);

		}
	}

	class Person
	{
		public string Name;
		public string Surname;
		public int Age;

		public Person(string name,string surname,int age)
		{
			Name = name;
			Surname = surname;
			Age = age;
		}
		public static bool operator >(Person p1,Person p2)
		{
			return p1.Age > p2.Age;
		}
		public static bool operator <(Person p1, Person p2)
		{
			return p1.Age < p2.Age;
		}
		public static int operator +(Person p1,Person p2)
		{
			return p1.Age + p2.Age;
		}
	}

	class Manat
	{
		public int Azn;

		public static explicit operator Dollar(Manat manat)
		{
			return new Dollar { Usd = manat.Azn * 2 };
		}

	}

	class Dollar
	{
		public int Usd;
	}


	abstract class Animal
	{
		public abstract void Eat();
	}

	abstract class Dog : Animal
	{
		public abstract void Bark();
	}

	abstract class Fish:Animal
	{
		public abstract void Swim();
	}

	class Samoyed : Dog
	{
		public string Fur;
		public override void Bark()
		{
			Console.WriteLine("Hav hav");
		}

		public override void Eat()
		{
			Console.WriteLine("Pedigree");
		}
	}

	class LionFish : Fish
	{
		public string Poison;
		public override void Eat()
		{
			Console.WriteLine("small fishes");
		}

		public override void Swim()
		{
			Console.WriteLine("fush fush");
		}
	}


	class Human
	{
		public string Name;

		public virtual void ShowInfo()
		{
			Console.WriteLine(Name);
		}
	}

	class Teacher:Human
	{
		public string School;

		public override void ShowInfo()
		{
			Console.WriteLine(School);
		}
	}
}
