// 90. Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.

void RandomData(out int[] a, int size=10,int min=0,int max=2)
        {
            a=new int[size];
            Random random=new Random();
            for(int i=0;i<size;i++)
                a[i]=random.Next(min,max+1);    
        }


void Print(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}

void RandomInfo(out int[] info, int [] data, int min=1, int max=4)
        {
            int size=data.Length;
            int [] temp=new int[size];
            int sum=data.Length;
            int s=1;
            Random random=new Random();
            for(int i=0;i<=size;i++)
            {
                temp[i]=random.Next(min,max+1);
                sum=sum-temp[i];
                if (sum==0) 
                {
                    s=i+1;
                    break;
                }    
                if (sum<0) 
                {
                    temp[i]=temp[i] +sum;
                    s=i+1;
                    break;
                }
            }
            info=new int[s];
            for(int j=0;j<s;j++) info[j]=temp[j];    

        }


void DataDec (int [] data, int [] info)
{
int i;
int d=0;
for (i=0; i<info.Length; i++)
{
string s="";
if(info[i]<=1) 
{
    s=Convert.ToString(data[d]);
    d++;
}
else
{
for (int j=0; j < info[i]; j++)
{
   s=s+Convert.ToString(data[d]); 
    d++;
}

} 
System.Console.Write($"{Convert.ToInt32(s,2),5}");
}
}

int sizeofdata=40;
int[] data=new int [sizeofdata];
int[] info;
RandomInfo(out info, data, 1,4);
RandomData(out data, sizeofdata,0,1);
System.Console.Write("Массив Data: ");
Print(data,2);
System.Console.WriteLine();
System.Console.Write("Массив Info: ");
Print(info,5);
System.Console.WriteLine(); 
System.Console.Write("Числа в Dec: ");
DataDec(data, info);