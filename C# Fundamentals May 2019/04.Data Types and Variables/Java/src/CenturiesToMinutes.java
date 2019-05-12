import java.util.Scanner;

public class CenturiesToMinutes {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int centuries = Integer.parseInt(scanner.nextLine());
        int years = centuries * 100;
        long days = (long)(years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;

        System.out.printf("%d centuries = %d years = %d days = %d hours = %s minutes%n", centuries, years, days,hours, minutes);
    }
}
