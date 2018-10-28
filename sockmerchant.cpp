#include<iostream>
using namespace std;
int main()
{
    int n,i,A[101],k,c=0,m=102,B[101],j;
    cin>>n;
    for(i=0;i<n;i++)
    {
        cin>>A[i];
        B[i]=0;
    }
    for(i=0;i<n-1;i++)
    {
        if(B[i]==0)
        {
            for(j=i+1;j<n;j++)
            {
                if(A[i]==A[j])
                {
                    B[j]=1;
                    c++;
                    break;
                }
            }
        }
    }
    cout<<c;
    return 0;
}
