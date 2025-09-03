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
    
        void append(int a)
        {
            resize(m_size+1);
            m_Pnums[m_size+1]=a;
        }
    private:

        void resize(int newsize)
        {
            int* newMen= (int*)malloc(sizeof(int)*newsize);
            for (int i = 0; i < m_size; i++)
            {
                newMen[i] = m_Pnums[i];
            }
            free(m_Pnums);
            m_size=newsize;
            m_Pnums=newMen;
        };
    };
    
    int main()
    {
        int nums[5]={1,2,3,4,5};
    MyList m (5,nums);
    m.append(14);
}