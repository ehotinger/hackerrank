import java.util.*;
import java.util.regex.*;

public class Solution {
	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();

		String regex = "(\\w+)(| ).*>.*";
		Pattern pattern = Pattern.compile(regex);

		ArrayList<String> tags = new ArrayList<String>();

		// Jump to the next line.
		scan.nextLine();

		for (int i = 0; i < n; i++) {
			String line = scan.nextLine();

			String[] allTags = line.split("<");

			for (int j = 0; j < allTags.length; j++) {

				if (allTags[j].matches(regex) == true) {

					Matcher match = pattern.matcher(allTags[j]);
					match.matches();

					if (tags.contains(match.group(1)) == false)
						tags.add(match.group(1));

				}
			}
		}

		Collections.sort(tags);

		for (int k = 0; k < tags.size(); k++) {

			if (k == tags.size() - 1)
				System.out.println(tags.get(k));
			else

				System.out.print(tags.get(k) + ";");
		}
		scan.close();
	}
}