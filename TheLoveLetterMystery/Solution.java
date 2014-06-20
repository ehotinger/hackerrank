import java.util.Scanner;

public class Solution {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);

		int numTestCases = s.nextInt();

		while (numTestCases > 0) {

			String word = s.next();

			System.out.println(getNumRotations(word));

			--numTestCases;
		}

		s.close();
	}

	public static int getNumRotations(String word) {
		char[] wordArr = word.toCharArray();
		
		int count = 0;
		int j = word.length() - 1;
		
		for(int i = 0; i < wordArr.length / 2; i++, j--){
			count += Math.abs((int)(wordArr[i] - wordArr[j]));
		}

		return count;
	}

}
