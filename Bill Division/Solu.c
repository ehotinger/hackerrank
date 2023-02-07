#include <assert.h>
#include <ctype.h>
#include <limits.h>
#include <math.h>
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* readline();
char* ltrim(char*);
char* rtrim(char*);
char** split_string(char*);

// Complete the bonAppetit function below.
void bonAppetit(int bill_count, int* bill, int k, int b) {
int i,a,sum=0,asum;
for(i=0;i<bill_count;i++)
{
    sum=sum+bill[i];
}
a=sum-bill[k];
asum=a/2;
if(asum==b)
printf("Bon Appetit");
else {
sum=(sum-a)/2;
printf("%d",sum);
}

}

int main()
{
    char** nk = split_string(rtrim(readline()));

    char* n_endptr;
    char* n_str = nk[0];
    int n = strtol(n_str, &n_endptr, 10);

    if (n_endptr == n_str || *n_endptr != '\0') { exit(EXIT_FAILURE); }

    char* k_endptr;
    char* k_str = nk[1];
    int k = strtol(k_str, &k_endptr, 10);

    if (k_endptr == k_str || *k_endptr != '\0') { exit(EXIT_FAILURE); }

    char** bill_temp = split_string(rtrim(readline()));

    int* bill = malloc(n * sizeof(int));

    for (int i = 0; i < n; i++) {
        char* bill_item_endptr;
        char* bill_item_str = *(bill_temp + i);
        int bill_item = strtol(bill_item_str, &bill_item_endptr, 10);

        if (bill_item_endptr == bill_item_str || *bill_item_endptr != '\0') { exit(EXIT_FAILURE); }

        *(bill + i) = bill_item;
    }

    int bill_count = n;

    char* b_endptr;
    char* b_str = ltrim(rtrim(readline()));
    int b = strtol(b_str, &b_endptr, 10);

    if (b_endptr == b_str || *b_endptr != '\0') { exit(EXIT_FAILURE); }

    bonAppetit(bill_count, bill, k, b);

    return 0;
}

char* readline() {
    size_t alloc_length = 1024;
    size_t data_length = 0;
    char* data = malloc(alloc_length);

    while (true) {
        char* cursor = data + data_length;
        char* line = fgets(cursor, alloc_length - data_length, stdin);

        if (!line) {
            break;
        }

        data_length += strlen(cursor);

        if (data_length < alloc_length - 1 || data[data_length - 1] == '\n') {
            break;
        }

        alloc_length <<= 1;

        data = realloc(data, alloc_length);

        if (!data) {
            data = '\0';

            break;
        }
    }

    if (data[data_length - 1] == '\n') {
        data[data_length - 1] = '\0';

        data = realloc(data, data_length);

        if (!data) {
            data = '\0';
        }
    } else {
        data = realloc(data, data_length + 1);

        if (!data) {
            data = '\0';
        } else {
            data[data_length] = '\0';
        }
    }

    return data;
}

char* ltrim(char* str) {
    if (!str) {
        return '\0';
    }

    if (!*str) {
        return str;
    }

    while (*str != '\0' && isspace(*str)) {
        str++;
    }

    return str;
}

char* rtrim(char* str) {
    if (!str) {
        return '\0';
    }

    if (!*str) {
        return str;
    }

    char* end = str + strlen(str) - 1;

    while (end >= str && isspace(*end)) {
        end--;
    }

    *(end + 1) = '\0';

    return str;
}

char** split_string(char* str) {
    char** splits = NULL;
    char* token = strtok(str, " ");

    int spaces = 0;

    while (token) {
        splits = realloc(splits, sizeof(char*) * ++spaces);

        if (!splits) {
            return splits;
        }

        splits[spaces - 1] = token;

        token = strtok(NULL, " ");
    }

    return splits;
}
