import java.util.Scanner;

public class LowerOrUpperLetter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();

        String upperCaseLine = line.toUpperCase();

        if (line.equals(upperCaseLine)) {
            System.out.println("upper-case");
        } else {
            System.out.println("lower-case");
        }
    }
}
