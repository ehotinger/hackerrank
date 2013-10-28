#include <iostream>
#include <vector>
using namespace std;

int GetRequiredCandies(vector<int> Students) {
    int N = Students.size();
    int TotalCandies = 0;

    vector<int> Left = vector<int>(N, 1);
    vector<int> Right = vector<int>(N, 1);
    
    for (int i = N - 2; i >= 0; i--) {
        if (Students[i + 1] < Students[i])
            Right[i] = 1 + Right[i + 1];
    }

    for (int i = 1; i < N; i++) {
        if (Students[i - 1] < Students[i])
            Left[i] = 1 + Left[i - 1];
    }

    for (int i = 0; i < N; i++) {
        TotalCandies += max(Right[i], Left[i]);
    }

    return TotalCandies;
}

int main() {
    int N, Score;
    cin >> N;

    vector<int> Students;

    for (int i = 0; i < N; i++) {
        cin >> Score;
        Students.push_back(Score);
    }

    cout << GetRequiredCandies(Students) << endl;

    return 0;
}