import java.util.Scanner;
public class ReverseString {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        StringBuffer sb = new StringBuffer();
        sb.append(input);

        sb.reverse();

        System.out.println(sb.toString());
    }
}
