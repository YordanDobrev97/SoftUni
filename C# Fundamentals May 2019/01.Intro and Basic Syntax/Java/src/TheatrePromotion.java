import java.util.Scanner;

public class TheatrePromotion {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String typeOfDay = scanner.nextLine();
        int age = Integer.parseInt(scanner.nextLine());

        double price = 0;
        boolean hasError = false;
        if (typeOfDay.equals("Weekday"))
        {
            if (age >=0 && age <= 18)
            {
                price = 12;
            }
            else if (age > 18 && age <= 64)
            {
                price = 18;
            }
            else if(age > 64 && age <= 122)
            {
                price = 12;
            }
            else
            {
                hasError = true;
            }
        }
        else if(typeOfDay.equals("Weekend"))
        {
            if (age >=0 && age <= 18)
            {
                price = 15;
            }
            else if (age > 18 && age <= 64)
            {
                price = 20;
            }
            else if (age > 64 && age <= 122)
            {
                price = 15;
            }
            else
            {
                hasError = true;
            }
        }
        else
        {
            if (age >= 0 && age <= 18)
            {
                price = 5;
            }
            else if (age > 18 && age <= 64)
            {
                price = 12;
            }
            else if (age > 64 && age <= 122)
            {
                price = 10;
            }
            else
            {
                hasError = true;
            }
        }

        if (hasError)
        {
            System.out.println("Error!");
        }
        else
        {
            System.out.printf("%.0f$\n", price);
        }
    }
}
