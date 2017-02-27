#include <iostream.h>
using namespace std;
//the maximum number in the set
int FindMaximum(int array[], int arraysize)
{        int max=0;
         for (int i=0;i<=arraysize-1;i++)
         {
            if(array[i]>max)
               max=array[i];
         }
 
        return max;
}
//average of numbers in the set
float FindAverage(int array[], int arraysize)
{        float Sum=0;
         float Avg=0;
         for(int i=0;i<=arraysize-1;i++)
         {
               Sum+=array[i];
         }
         Avg = Sum/arraysize;
         return Avg;
}
//mode of the data set
int FindMode(int array[], int arraysize)
{
    
        int counter = 0;
        int max = 0;
        int mode = 0;
        for (int i = 0; i <= arraysize - 1; i++)
        {
            counter = 0;
            for (int j = 0; j < arraysize - 1; j++)
            {
                if(array[i] == array[j])
                {
                    counter++;
                }
            }
            if(counter > max)
            {
                max = counter;
                mode = array[i];
            }
          
        }
        return mode;
}
//median of the numbers in data set
float FindMedian(int array[], int arraysize)
{      
       //sort Aray to find the median
       int temp;
       for(int i=0;i<=arraysize;i++)
       {
         for(int j=0;j<=arraysize-i;j++)
         {
            if(array[j]>array[j+1])
            {
                temp=array[j];
                array[j]=array[j+1];
                array[j+1]=temp;
            }
         }
      }

    //Find Median
    int middle;
    float average, median;
    middle = arraysize / 2.0;
 
    if (arraysize % 2)
    {

        median = (array[middle] + array[middle + 1]) / 2.0;
    }
    else
    {
        median = array[middle] ;
    }

    return median;
}

int main()
{
  int arraysize;
  cout << "Please enter array size: ";
   cin >> arraysize;
  int array[arraysize];
  int input;
  for(int i=0;i<=arraysize-1;i++)
  {
      cout << "Please enter a number: ";
      cin >> input;;
      array[i] = input;
  }
   
   int Max = FindMaximum(array,arraysize);
   float Average = FindAverage(array, arraysize);
   int Mode = FindMode(array, arraysize);
   float Median  = FindMedian(array, arraysize);
 
  cout<<"The maximum number is: = "<<Max<<endl;
  cout<<"The average is: "<<Average<<endl;
  cout << "The mode is: " << Mode << endl;
  cout << "The median is: " << Median << endl;
}

OUTPUT:
Please enter array size: 5
Please enter a number: 1 1 3 4 5
The maximum number is: 5
The average is: 2.8
The mode is: 1
The median is: 3.0

OUTPUT:
Please enter array size: 6
Please enter a number:  4 5 6 8 9 4 
The maximum number is: 9
The average is: 6.0
The mode is: 4
The median is:  5.5 

©jalpapandya
