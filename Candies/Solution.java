import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner in=new Scanner (System.in);
        int N,i;
        N=in.nextInt();
        long S;S=0;        
        int ar[]=new int[N];
        for(i=0;i<N;i++)
            {ar[i]=in.nextInt();}
        
        int a[]=new int[N];
        
        if(ar[0]>ar[1])
            {
            a[0]=2;
            a[1]=1;
            }
        else if(ar[0]<ar[1])
            {
            a[0]=1;
            a[1]=2;
            }
        else
            {a[0]=1;
            a[1]=1;
            }
         
        
        for(i=1;i<(N-1);i++)
           {
            if(ar[i]<ar[i+1])
               {
               a[i+1]=a[i]+1;
               }
            else
            {
              a[i+1]=1;
            }
            
           }
        for(int z=(N-1);z>0;z--)
            {
             if(ar[z]<ar[z-1])
                 {if(a[z]>=a[z-1])
                 {a[z-1]=a[z]+1;}
                 }
            }
        for(int m=0;m<N;m++)
            {
            S=S+a[m];
            }
        System.out.println(S);
        
    }
}
