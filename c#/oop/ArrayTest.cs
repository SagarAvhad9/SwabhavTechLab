using System;  
public class ArrayTest 
{  

      public static void printArray(int[] arr)
        { 
      Console.WriteLine("Print arr elements:");  
         
        for (int i = 0; i < arr.Length; i++)  
        {  
              Console.WriteLine(arr[i]);  
        }
        }
      
      public static void printMin(int[] arr)  
        {  
        int min = arr[0];  
        for (int i = 1; i < arr.Length; i++)  
        {  
            if (min > arr[i])  
            {  
                min = arr[i];  
            }  
        }  
        Console.WriteLine("Minimum element is: " + min);  
        }

       
       public static void printMax(int[] arr)  
        {  
        int max = arr[0];  
        for (int i = 1; i < arr.Length; i++)  
        {  
            if (max < arr[i])  
            {  
                max = arr[i];  
            }  
        }  
        Console.WriteLine("Maximum element is: " + max);  
        }  

      
       public static void LastIndex(int[] arr) 
       {
       Console.WriteLine("Last Ele is : " + arr[arr.Length-1]);
       }

 
 public static void Main(string[] args) 

  {  
       int[] arr = new int[5] { 10, 20, 30, 40, 50 };            
       printMax(arr);
       printMin(arr);
       LastIndex(arr);
  }   
} 






















    

 















