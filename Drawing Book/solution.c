#include <assert.h>
#include <limits.h>
#include <math.h>
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* readline();

/*
 * Complete the pageCount function below.
 */
int pageCount(int n, int p)
{ int i,j,c=0;
    /*
     * Write your code here.
     */
    if(n%2==0)//if n is even & last page will be at left
    {
        if(n/2>=p)//if p is in 1st half
        {
            for(int i=0;i<=n;i=i+2)
            {
                if(p==i||p==i+1)
                break;
                c++;
            }
        }
        else //if p is in 2nd half
        {
            for(i=n+1;i>=0;i=i-2)
            {
                if(p==i||p==i-1)
                
                    break;
                    c++;
                
            }
        }
    }
    else        //if n is odd & last page will be at right
    {
        if(n/2>=p)//if p is in 1st half
        {
            for(i=0;i<=n;i=i+2)
            {
                if(p==i||p==i+1)
                break;
                c++;
            }
        }
        else //if p is in 2nd half
        {
            for(i=n;i>=0;i=i-2)
            {
                if(p==i||p==i-1)
                
                    break;
                    c++;
                
            }
        }
    }
return c;
}

int main()
{
    FILE* fptr = fopen(getenv("OUTPUT_PATH"), "w");

    char* n_endptr;
    char* n_str = readline();
    int n = strtol(n_str, &n_endptr, 10);

    if (n_endptr == n_str || *n_endptr != '\0') { exit(EXIT_FAILURE); }

    char* p_endptr;
    char* p_str = readline();
    int p = strtol(p_str, &p_endptr, 10);

    if (p_endptr == p_str || *p_endptr != '\0') { exit(EXIT_FAILURE); }

    int result = pageCount(n, p);

    fprintf(fptr, "%d\n", result);

    fclose(fptr);

    return 0;
}

char* readline() {
    size_t alloc_length = 1024;
    size_t data_length = 0;
    char* data = malloc(alloc_length);

    while (true) {
        char* cursor = data + data_length;
        char* line = fgets(cursor, alloc_length - data_length, stdin);

        if (!line) { break; }

        data_length += strlen(cursor);

        if (data_length < alloc_length - 1 || data[data_length - 1] == '\n') { break; }

        size_t new_length = alloc_length << 1;
        data = realloc(data, new_length);

        if (!data) { break; }

        alloc_length = new_length;
    }

    if (data[data_length - 1] == '\n') {
        data[data_length - 1] = '\0';
    }

    data = realloc(data, data_length);

    return data;
}
