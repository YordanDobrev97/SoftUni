import java.math.BigInteger;
import java.util.Scanner;

public class SumBigNumbersRange {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        BigInteger first = new BigInteger(scanner.nextLine());
        BigInteger second = new BigInteger(scanner.nextLine());

        BigInteger sum = new BigInteger("0");

        for (BigInteger i = first; i.compareTo(second) == -1 || i.compareTo(second) == 0; i = i.add(BigInteger.valueOf(1))) {
            sum = sum.add(i);
        }
        System.out.println(sum);
    }
}
