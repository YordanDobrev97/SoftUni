import java.util.ArrayList;
import java.util.Scanner;

public class PrintAndSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int startNumber = Integer.parseInt(scanner.nextLine());
        int endNumber = Integer.parseInt(scanner.nextLine());

        int sum = 0;

        ArrayList<Integer> range = new ArrayList<Integer>();

        for (int i = startNumber; i <=endNumber; i++)
        {
            sum += i;
            range.add(i);
        }

        for(int i = 0; i < range.size(); i++){
            System.out.print(range.get(i) + " ");
        }
        System.out.println();
        System.out.println("Sum: " + sum);
    }
}
