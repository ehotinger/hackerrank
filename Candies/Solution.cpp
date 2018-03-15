#include <iostream>
#include <vector>
using namespace std;

long long GetRequiredCandies(vector<long long> Students) {
    long long N = Students.size();
    long long TotalCandies = 0;

    vector<long long> Left = vector<long long>(N, 1);
    vector<long long> Right = vector<long long>(N, 1);
    
    for (long long i = N - 2; i >= 0; i--) {
        if (Students[i + 1] < Students[i])
            Right[i] = 1 + Right[i + 1];
    }

    for (long long i = 1; i < N; i++) {
        if (Students[i - 1] < Students[i])
            Left[i] = 1 + Left[i - 1];
    }

    for (long long i = 0; i < N; i++) {
        TotalCandies += max(Right[i], Left[i]);
    }

    return TotalCandies;
}

int main() {
    long long N, Score;
    cin >> N;

    vector<long long> Students;

    for (long long i = 0; i < N; i++) {
        cin >> Score;
        Students.push_back(Score);
    }

    cout << GetRequiredCandies(Students) << endl;

    return 0;
}
