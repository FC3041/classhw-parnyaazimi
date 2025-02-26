#include <iostream>
#include<stdlib.h>

using namespace std;

class MyList
{
    public:
        int m_size;
        int m_capasity=m_size*2;
        int* m_Pnums;

        MyList(int size,int* nums):m_size(size)
        {
            m_Pnums=(int* )malloc(sizeof(int)*m_capasity);
            int i;
            for ( i = 0; i < m_size; i++)
            m_Pnums[i]=nums[i];

        }
        ~MyList(){};
    
        void append(int a)
        {
            resizeAdd(m_size+1);
            m_Pnums[m_size]=a;
            m_size++;
        }
        
        void pop()
        {
            int* NewArray=new int[m_capasity];    
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
                int* NewArray=(int *)malloc(sizeof(int)*(m_capasity));
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
            int p=0;
            if(m_size<m_capasity) 
                p=m_capasity;
            
            else
            {
                m_capasity=m_size*2;
                p=m_capasity;
            }
            int* NewArray=new int[p];
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
                cout<<m_Pnums[i]<<" , ";
            }

        }
        
        private:
        
        void resizeAdd(int NewSize)
        {
            if(NewSize>m_capasity)
            {
                int* NewArray= (int*)malloc(sizeof(int)*m_size*2);
                for (int i = 0; i < m_size; i++)
                {
                    NewArray[i] = m_Pnums[i];
                }
                free(m_Pnums);
                m_capasity=m_size*2;
                m_Pnums=NewArray;
            }
        };
};
    
    int main()
    {
        // MyList();
        int nums[1]={1};
        MyList m (1,nums);
        // cout<<"\nIndex of 18 : "<<m.findIndex(18);
        // cout<<"\ncout 16 : "<<m.Count(16)<<"\n";
        // m.sort();
        // m.Print();
        // m.update(4,1);
        // cout<<"\n";
        // m.Print();
        // cout<<"\n"<<m.InList(8);
        // cout<<"=====";
        // m.pop();
        // cout<<"\n";
        // m.Print();
        m.append(14);
        m.append(15);
        m.append(16);
        m.append(17);
        m.append(18);
        m.Print();
        m.insert(500,0);
        m.insert(400,3);
        m.insert(200,6);
        cout<<"\n";
        m.Print();

        
    }