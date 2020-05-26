package P7;
import java.util.Scanner;

public class P7RecursiveFibonacci {
    private static Long[] fibonacci;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        fibonacci = new Long[n + 1];
        fibonacci[0] = 1L;
        fibonacci[1] = 1L;

        long result = recursiveFibonacci(n);
        System.out.println(result);
    }

    public static long recursiveFibonacci(int n) {
        if (n == 0 || fibonacci[n] != null) {
            return fibonacci[n];
        }

        fibonacci[n] = recursiveFibonacci(n - 1) + recursiveFibonacci(n - 2);
        return fibonacci[n];
    }
}