import java.util.Scanner;

public class MultiplicationTable2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int start = Integer.parseInt(scanner.nextLine());
        int end = Integer.parseInt(scanner.nextLine());

        int count = 1;
        boolean specialCase = true;
        while (count <= 10 && end <=10)
        {
            System.out.printf("%s X %s = %s\n", start, end, (start * end));
            end++;
            count++;
            specialCase = false;
        }

        if (specialCase)
        {
            System.out.printf("%s X %s = %s", start, end, (start * end));
        }
    }
}
