import java.util.Scanner;

public class StudentInformation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String studentName = scanner.nextLine();
        int studentAge = Integer.parseInt(scanner.nextLine());
        double studentAverageGrade = Double.parseDouble(scanner.nextLine());

        System.out.printf("Name: %s, Age: %s, Grade: %.2f \n", studentName, studentAge, studentAverageGrade);
    }
}
