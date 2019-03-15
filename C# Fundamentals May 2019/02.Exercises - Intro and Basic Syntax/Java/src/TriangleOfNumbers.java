import java.util.Scanner;

public class TriangleOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = Integer.parseInt(scanner.nextLine());

        for(int row = 1; row <=number; row++){
            for(int col = 1; col <= row; col++){
                System.out.print(row + " ");
            }
            System.out.println();
        }
    }
}
