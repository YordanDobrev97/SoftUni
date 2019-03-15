import java.util.Scanner;

public class SumOfOddNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = Integer.parseInt(scanner.nextLine());

        int sum = 0;
        int num = 1;

        int count = 1;
        while (count <= number)
        {
            if (num % 2 == 1)
            {
                sum += num;
                System.out.println(num);
                num+=2;
            }
            count++;
        }
        System.out.println("Sum: "+ sum);
    }
}
