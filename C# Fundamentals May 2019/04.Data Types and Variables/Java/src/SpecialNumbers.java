import java.util.Scanner;
public class SpecialNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <=number ; i++) {
            int currentNumber = i;

            int sum = 0;
            while (currentNumber > 0) {
                int digit = currentNumber % 10;
                sum += digit;
                currentNumber /=10;
            }

            if (sum == 5 || sum == 7 || sum == 11) {
                System.out.printf("%d -> True%n", i);
            } else {
                System.out.printf("%d -> False%n", i);
            }
        }
    }
}
