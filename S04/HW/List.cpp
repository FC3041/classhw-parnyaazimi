#include <iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_size;
        int* m_Pnums;

        MyList(int size,int* nums):m_size(size)
        {
            m_Pnums=(int* )malloc(sizeof(int)*size);
            int i;
            for ( i = 0; i < m_size; i++)
            m_Pnums[i]=nums[i];

        };
        ~MyList(){};
    
        void append(int a)
        {
            resizeAdd(m_size+1);
            m_Pnums[m_size-1]=a;
        }

        void pop()
        {
            int* NewArray=new int[m_size-1];    
            for (int i = 0; i < m_size-1; i++)
            {
                NewArray[i]=m_Pnums[i];
            }
            delete[] m_Pnums;
            m_Pnums=NewArray;
            m_size=m_size-1;     
        }

        bool InList(int a)
        {
            bool flag=false;
            for (int i = 0; i < m_size; i++)
            {
                if(m_Pnums[i]==a)
                {
                    flag=true;
                    break;
                }
            }
            return flag;
            
        }

        void remove(int a)
        {
            if(InList(a)==true)
            {
                int* NewArray=(int *)malloc(sizeof(int)*(m_size-1));
                int p=0; 
                for (int i = 0; i < m_size; i++)
                {
                    if (m_Pnums[i]==a)
                    {
                        p =i;
                        break;
                    }
                }
                for (int j = 0; j < m_size; j++)
                {
                    if (j<p)
                        NewArray[j]=m_Pnums[j];
                    else if (j>p)
                        NewArray[j-1]=m_Pnums[j];        
                }
                free(m_Pnums);
                m_Pnums=NewArray;
                m_size=m_size-1;
            }
            else
            {
                m_Pnums=m_Pnums;
                m_size=m_size;
            }
        }

        void insert(int a ,int index) 
        {
            int* NewArray=new int[m_size+1];
            for (int i = 0; i < m_size; i++)
            {
                if (i<index)
                    NewArray[i]=m_Pnums[i];
                else if(i==index)
                {
                    NewArray[i]=a;
                    NewArray[i+1]=m_Pnums[i];
                }
                else
                    NewArray[i+1]=m_Pnums[i];        
            }
            delete[]m_Pnums;
            m_Pnums=NewArray;
            m_size=m_size+1;
        }

        void update(int a,int index)
        {
            for (int i = 0; i < m_size; i++)
            {
                if(i==index)   
                    m_Pnums[i]=a;    
            }            
        }

        int findIndex(int a)
        {
            int out=0;
            for (int i = 0; i < m_size; i++)
            {
                if(m_Pnums[i]==a)
                {
                    out = i;
                    break;
                }
            }
            return out;
        }

        void sort()
        {
            for (int i = 0; i < m_size; i++)
            {
                for (int j = i; j < m_size; j++)
                {
                    if (m_Pnums[j]<m_Pnums[i])
                    {   
                        int a=m_Pnums[j];
                        m_Pnums[j]=m_Pnums[i];
                        m_Pnums[i]=a;
                    }
                }
            }
        }

        int Count(int a)
        {
            int count=0;
            for (int i = 0; i < m_size; i++)
            {
                if(m_Pnums[i]==a)
                    count++;
            }
            return count;
            
        }
        void Print()
        {
            for (int i = 0; i < m_size; i++)
            {
                cout<<m_Pnums[i]<<endl;
            }

        }

    private:

        void resizeAdd(int NewSize)
        {
            int* NewArray= (int*)malloc(sizeof(int)*NewSize);
            for (int i = 0; i < m_size; i++)
            {
                NewArray[i] = m_Pnums[i];
            }
            free(m_Pnums);
            m_size=NewSize;
            m_Pnums=NewArray;
        };
};
    
    int main()
    {
        int nums[7]={16,1,5,1,9,2,1};
        MyList m (7,nums);
        // m.append(14);
        // m.remove(5);
        // m.pop();
        // m.insert(9,2);
        // m.insert(18,5);
        // m.update(8,4);
        // cout<<m.find(5);
        // m.sort();
        // m.Print();
        int out =(m.Count(1));
        cout<<out;
        
    }