﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TeaApp.Model;



namespace TeaApp.Api
{
    public class CarApi
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<CarModel>> action)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/jly7p");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<CarModel>>(await response.Content.ReadAsStringAsync());
                action(list);
            }

        }
    }
}
// interview question and practice c#
1)what is typecasting.
    type casting is process to converting one data type value to other data type value.
    example convert string to int etc.
2) what is boxing and unboxing.
    it is procees of converting Valuetype datatype to reference type data type. 
    note- all data type except string is colled valuetype datatype. string is refrence type data type.
    
    so--> converting any data type to string is colled boxing. unboxing string to any data type.
    boxing example.
    int i = 10;
string s = i.Tostring();
   unboxing example
   string name ="suraj";
name=int.parse();
dataype.parse();
example. int.parse();, byte.parse(); ,double.parse();

3)conditional statment.
    A statment that will gate excute based on condition is called coditional statment.
    condition- A condition is use to compare 2 value or variable or expression.
    
    two type of condition
    1)if 
    2)switch 
    1)if-> a)if ,b)if else, c)else if ,d) multiple if e) nested if
       a) if)--> the statment will get excute when condition is true.
           if(true)
           {
               statment
           }
    example-
        if(2==2)
        {
            console.Writeline("i am suraj");
        }
   b)if else-->if condition is true . it will excute statment that was written inside if . If condition is falls. it will excute the statment which is written inside else. 
   
       example-
       if(2>1)
       {
           console.writenline("ok");
           
       }
       else
       { 
           console.writemline(" thanks");
       }
   
    c)else if-->it is use to check multiple condition and excute only one condition.
        if(condition)
        {
        }
        else if(condition)
        {
        }
        else if(condition)
        {
        }
        else if(condition)
        {
        }
example-->
    if(3>9)
    {
        console.WritenLine("ok");
            
    }
    else if(3==9)
    {
        C.W.L("thanks");
    }
    else if(3<9)
    {
        C.W.L("suraj");
    }
    else
    {
        C.W.L("nath");
    }
c)Multiple if-->it is use to check multiple condition and excute multiple condition.
    if(10>5)
    {
        C.W.L("hello");
    }
    if(20>2)
    {
        C.L.W("thanks");
    }
   if(10==10)
   {
       C.W.L(" thik hai");
   }
 e) Nested if--->the inner condition will get excute when outer condition is true.
     
     class suraj {
      static void Main(string[] args) {
         
         string a = "ram";
         srting b = "ravi";
         
         
         if (a == ram) {
            
            if (b == ravi) {
              
               Console.WriteLine("This is nested if");
            }
         }
         
 4)Switch case-->It will check perticular condition and excute all cases according to condition.
     switch(condition)
     {
             case1:
             break;
             case 2:
             break;
             case 3
             break;
         default:
             break;
     }
     q)write a program to expect a charecter from console and check whether given charecter is vowel or consonent.
using system;
class Program
{
 
    static void Main(string[] args)
    {
 
        char ch;
 
        //Reading an alphabet from user
        Console.WriteLine("Enter any alphabet: ");
        ch = Convert.ToChar(Console.ReadLine());
 
 
    // checking vowel and consonant
        switch (ch)
        {
            case 'a': Console.WriteLine("vowel");
                break;
            case 'e': Console.WriteLine("vowel");
                break;
            case 'i': Console.WriteLine("vowel");
                break;
            case 'o': Console.WriteLine("vowel");
                break;
            case 'u': Console.WriteLine("vowel");
                break;
            case 'A': Console.WriteLine("vowel");
                break;
            case 'E': Console.WriteLine("vowel");
                break;
            case 'I': Console.WriteLine("vowel");
                break;
            case 'O': Console.WriteLine("vowel");
                break;
            case 'U': Console.WriteLine("vowel");
                break;
            default: Console.WriteLine("consonant");
                break;
        }
 
        Console.ReadLine();
 
    }
 
}
          
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----  ---  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    loop--> Loop ia a mechanism which is use to excute repeatedly data again and again until the condition become false.
    Loop divided in two part -->a) (for loop) or range based loop b)(While loop) or conditional based loop.
    
    Every loop consist3 thing in common
    1)Initialization
    2)Condition
    3)Increment /Decrement
    
   1)Initialization--> it is use to initialize the initial value in a variable. ex- int i=5;
   2) Condition-->A condition will always return boolean value ither tue or false.
       or-> a condition is use to compare 2 value or variable.
       ex-10>2 -->true
       1>10 -->false
    3)increment / decrement operator
       ex- int i=5;
          i++; -->6
              i=i+1; --> 7
                  
                  i=i-1; -->5
   
   for(initialization;condition;increment/decrement)
   {
   }
  q)write a program to print suraj 5 times.
      
      using system;
          Class A
          {
              static void Main()
              {
                  for(int i=1; i<=5; i++)
                  console.WriteLine("Suraj");
              }
          }
        note->loop will reduce your code.
   q)Write a program to accept 6 number from console and find there sum.
      using system;
          class A
          {
              Static Void Main()
              {
                  int sum=0;
                  for(int i=1; i<=6; i++)
                  {
                      console.WriteLine("enter number");
                      int number=int.parse(console.ReadLine());
                      Sum=Sum+Number;
                      Console.WriteLine(sum);
                  }
              }
              
          }
      q)Write a program to print.
          *#*#*
          *#*#*
          *#*#*
          *#*#*
          *#*#*
         using system;
          class A
          {
              static void Main()
              {
                  for(int i=1;i<=5;i++)
                  {
                      for(int j=1; j<=5; j++)
                      {
                          if(j%2==0)
                          {
                              C.W.L("#");
                              
                          }
                          else
                          {
                              C.W.L("*");
                          }
                      }
                  }
              }
          }

    q)write a program to print.
        ----*
        ---**
        --***
        -****
        *****
        
        using System;
          Class A
          {
              Static void Main()
              {
                  for(int i=1; i<=5; i++)
                  {
                      for(int j=4;j>=1;j--)
                      {
                          Console.WriteLine("");
                    
                      }
                      for(int K=1;k=i;K++)
                      {
                          Console.WriteLine("*");
                      }
                      Console.WritenLine();
                  }
              }
          }
     
          While loop -->In while loop, the condition is checked before the body is executed
using System;
          1)initialization
          2)condition
          3)operator
					
public class Program
{
	public static void Main()
	{
		int i = 0;

		while (i < 5)
		{
		
			int m=i*2;
			Console.WriteLine("Value of i: {0}", m);
            i++
		
			
		}
	}
}
          
 output-->Value of i: 0
Value of i: 2
Value of i: 4
Value of i: 6
Value of i: 8
    
 q)write while loop for sum of first 5 natural numbers.
     using System;
namespace Loop
{
	class WhileLoop
	{
		public static void Main(string[] args)
		{
			int i=1, sum=0;
			while (i<=5)
			{
				sum += i;
				i++;
			}
			Console.WriteLine("Sum = {0}", sum);
		}
	}
}
  output--> 15
 
      do while loop --> in do while loop condition is checked after the body is executed.
   do
{
	// body of do while loop
}
while (condition);
 using System;
  
	class DoWhileLoop
	{
		public static void Main(string[] args)
		{
			int i = 1, n = 5, product;
			do
			{
				product = n * i;
				Console.WriteLine("{0} * {1} = {2}", n, i, product);
				i++;
			} while (i <= 10);
		}
	}
          
 q) Difference between While loop and Do while loop.
    ans-->The do and while keyword is used to create a do...while loop. It is similar to a while loop, however there is a major difference between them
  
  ---------------------------------------------------------------------------------------------------------------------------------------------------------
 -------------------------------------------------------------------------------------------------------------------------------------------------------------
 
      OOPS(object oriented principle system)
      -->object oriented principle system (oops) is a concept which is used to write computer program by using class and object.
      
      Principle of oops
      1)Abstraction
      2)Encapsulation
      3)Inheritance
      4)polymorphism
   
   q)what is object oriented programing language.
     ans-->Any language that support oops principle then that language is called object oriented programing language.
      example--> Java, C#.net etc.
  q)what is object based programing language.
    ans-->Any language that does not support atleast one principle of oops among the above 4. ++
          then that language is called as object based programing language.
  example-javascript.
      
  1)Abstraction -->It is a proceess of getting required data and hiding unnecessary data.
  
  2)Encapsulation-->It is proceess of binding or grouping of common set of state and behaviore(variable and method).
                    in a single container.
      note-->we can apply encapsulation by using class.
     
  3)Inheritance-->It is a mechanism of creating a new class by already existing class.
               OR-->It is mechanism of establisting relationship between two or more classes.
               OR--->Or Inheritance is mechanism to optaining variable and methods from one class to another class.
                   -->the class which is giving variable and method is called as Base class or super class or parent class.
                   -->the class which is taking variable and method is called as Drive class or sub class or child class.
                       : operator is called inheritance operator.
  
   q)What are the advantages of inheritance.
       1)Reusabitity
       2)Extensability
       3)Reimplementation
			       
    4)polymorphism --> polymorphism means one thing in many forrms. 
		       There are two type of polymorphism.
       1)Compile time Polymorphism 
       2)Run time polymorphism
			       
       1)Complile time polymorphism --> When output is dicided at Compile time is called compile time polmorphism.
          example--> overloading.
       2)Runtime polymorphism --> When Output is dicided at runtime is called runtime polymorphism.
	   example--> overriding.
 -----------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------
some important interview questions.
----	-----	------	    ---   ------ -----
Q)What is constroctor.
  ANS-->A constructor is a member function in a class that has the same name as its class. The constructor is automatically invoked whenever an object class is created.
	Constroctor is used to initializing class.  

Q)What is an object.
  ANS--> An object is an instance of a class.

Q) What is the difference between public, static, and void.
  ANS-->public-Public declared variables or methods are accessible anywhere in the application.
	static-Static declared variables or methods are globally accessible without creating an instance of the class. 
	void-Void is tells that the method or variable does not return any value.
	Note-Static member are by default not globally accessible it depends upon the type of access modified used.
		
Q)What is the use of 'using' statement in C#.
  ANS-->The 'using' block is used to obtain a resource and process it and then automatically dispose of when the execution of the block completed.
		
Q)Can multiple catch blocks be executed.
 ANS-->No, Multiple catch blocks can't be executed. Once the proper catch code executed, the control is transferred to the finally block, and then the code that follows the finally block gets executed.

Q)What is Jagged Arrays.
  ANS--> combination of single dimensional and multidiamentional array is called jagged array. OR Array of arrays is called jagged array.

Q)What is the difference between ref & out parameters.
 ANS-->An argument passed as ref must be initialized before passing to the method whereas out parameter needs not to be initialized before passing to a method.

Q)What is serialization.
 ANS-->When we want to transport an object through a network, then we have to convert the object into a stream of bytes. The process of converting an object into a stream of bytes is called Serialization. For an object to be serializable, it should implement ISerialize Interface. 
	 De-serialization is the reverse process of creating an object from a stream of bytes.

Q)Can we use "this" command within a static method.
  ANS-->We can't use 'This' in a static method because we can only use static variables/methods in a static method.

Q)What is the difference between constants and read-only.
  ANS-->Constant variables are declared and initialized at compile time. The value can't be changed afterward. Read-only is used only when we want to assign the value at run time.

Q)What is an interface class/
  ANS-->An Interface is an abstract class which has only public abstract methods, and the methods only have the declaration and not the definition. These abstract methods must be implemented in the inherited classes.
	 OR-> interface is used to achieve multiple inheritance which can't be achieved by class in .net.
	  -->interfaces will contain only the declaration of the members(means only method heding). The implementation of interface’s members will be given by class who implements the interface.

Q)What are value types and reference types.
 ANS-->A value type holds a data value within its own memory space.
       example--> Value type data type (int i=10; etc.)
       Reference type stores the address of the Object where the value is being stored. It is a pointer to another memory location.
	example--> string d="suraj";
	      
Q)What are Custom Control and User Control.
  Custom Controls are controls generated generated by default.
  those are easier to use and can be added to toolbox. Developers can drag and drop
  -->user Control are control generated by user. User controls can't be placed in the toolbox for drag and drop.

Q)
