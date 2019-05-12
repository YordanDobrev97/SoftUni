import java.util.Scanner;
public class ReversedChars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String firstLine = scanner.nextLine();
        String secondLine = scanner.nextLine();
        String thirdLine = scanner.nextLine();

        System.out.printf("%s %s %s", thirdLine, secondLine, firstLine);
    }
}
