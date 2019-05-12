import java.math.BigDecimal;
import java.math.BigInteger;
import java.util.Scanner;
public class ExactSumOfRealNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int countNumbers = Integer.parseInt(scanner.nextLine());

        BigDecimal sum = new BigDecimal("0");

        for (int i = 0; i <countNumbers; i++) {
            BigDecimal value = new BigDecimal(scanner.nextLine());
            sum = sum.add(value);
        }

        System.out.println(sum);
    }
}
