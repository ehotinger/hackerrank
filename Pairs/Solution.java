import java.util.Arrays;
import java.util.Scanner;

public class Solution {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		String[] N_K = s.nextLine().split(" ");

		// N numbers of
		int N = Integer.valueOf(N_K[0]);

		// K difference
		int K = Integer.valueOf(N_K[1]);

		String[] numbers = s.nextLine().split(" ");

		s.close();

		int[] ints = new int[N];

		for (int i = 0; i < N; i++) {
			ints[i] = Integer.parseInt(numbers[i]);
		}

		System.out.println(PairsOfDiffK(ints, K));
	}

	public static int PairsOfDiffK(int[] arr, int diff) {
		int numPairs = 0;

		Arrays.sort(arr);

		for (int i = 0; i < arr.length - 1; i++) {
			if (arr[i + 1] - arr[i] == diff) {
				numPairs++;
			}
		}

		return numPairs;
	}
}