// https://www.hackerrank.com/challenges/maximizing-xor
import java.util.Scanner;
 
public class Solution {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		short l = s.nextShort();
		short r = s.nextShort();
		short max = 0;

		for (int a = l; a <= r; a++) {
			for (int b = a; b <= r; b++) {
				int curr = a ^ b;

				if (curr > max)
					max = (short) curr;
			}
		}

		System.out.println(max);
		s.close();
	}

}
