import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
        Scanner in=new Scanner (System.in);
        int N,i;
        N=in.nextInt();//total students
        long S=0; //holding the total number of candies        
        int students[]=new int[N];
        for(i=0;i<N;i++)
            {students[i]=in.nextInt();}
        
        int candies[]=new int[N];
        
        if(students[0]>students[1])
            {
            candies[0]=2;
            candies[1]=1;
            }
        else if(students[0]<students[1])
            {
            candies[0]=1;
            candies[1]=2;
            }
        else
            {
            candies[0]=1;
            candies[1]=1;
            }
         
        
        for(i=1;i<(N-1);i++)//going right incrementing the number of candies by one each time until i find a ranking crest
           {
            if(students[i]<students[i+1])
               {
               candies[i+1]=candies[i]+1;
               }
            else
            {
              candies[i+1]=1;
            }
            
           }
        for(int z=(N-1);z>0;z--)//repeating the above step but to the left.
            {
             if(students[z]<students[z-1])
                 {if(candies[z]>=candies[z-1])
                 {candies[z-1]=candies[z]+1;}
                 }
            }
        for(int m=0;m<N;m++)
            {
            S=S+candies[m];
            }
        System.out.println(S);
        
    }
}
