package P2;

import java.util.Scanner;

public class P2RecursiveFactorial {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        long result = factorial(n, 1);
        System.out.println(result);
    }

    public static long factorial(int n, int current) {
        if (current == n) {
            return n;
        }
        return current * factorial(n, current + 1);
    }
}
