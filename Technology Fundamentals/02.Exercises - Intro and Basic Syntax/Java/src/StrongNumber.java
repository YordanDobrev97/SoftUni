import java.util.Scanner;

public class StrongNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        long number = Long.parseLong(scanner.nextLine());

        long factorialSum = 0;
        long temp = number;
        while (temp > 0)
        {
            long lastDigit = temp % 10;
            long factorial = factorial(lastDigit);
            factorialSum += factorial;
            temp /= 10;
        }

        if (factorialSum == number)
        {
            System.out.println("yes");
        }
        else
        {
            System.out.println("no");
        }
    }
    static long factorial(long number)
    {
        long factorial = 1;

        for (int i = 2; i <=number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
