import java.util.*;

public class Solution {

	public static void main(String[] args) {

	Scanner in = new Scanner(System.in);
		String format = "\\((\\+|\\-|)(([0-9]|[0-8][0-9])(\\.([0-9]+)|)|(90)(\\.([0]+)|)), (\\+|\\-|)(([0-9]|[0-9][0-9]|1[0-7][0-9])(\\.([0-9]+)|)|(180)(\\.([0]+)|))\\)";
		int testcase = in.nextInt();
		String dec = in.nextLine();

		for (int i = 0; i < testcase; i++) {
			String test = in.nextLine();
			if (test.matches(format)) {
				System.out.println("Valid");
			} else {
				System.out.println("Invalid");
			}
		}
	}
}