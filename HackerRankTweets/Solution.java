import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Solution {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);

		int n = Integer.parseInt(s.nextLine());
		String[] lines = new String[n];

		for (int i = 0; i < n; i++) {
			lines[i] = s.nextLine();
		}

		s.close();

		int numTweets = 0;
		Pattern p = Pattern.compile(".*hackerrank.*", Pattern.CASE_INSENSITIVE);
		
		for (String line : lines) {
			Matcher m = p.matcher(line);
			if (m.matches()) {
				numTweets++;
			}
		}

		System.out.println(numTweets);

	}
}
