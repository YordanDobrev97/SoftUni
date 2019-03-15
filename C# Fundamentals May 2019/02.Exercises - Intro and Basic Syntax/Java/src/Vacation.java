import java.util.Objects;
import java.util.Scanner;

public class Vacation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberStudent = Integer.parseInt(scanner.nextLine());
        String typeGroup = scanner.nextLine();
        String dayOfWeek = scanner.nextLine();

        double price = 0.0;

        if (dayOfWeek.equals("Friday"))
        {
            if (Objects.equals(typeGroup, "Students"))
            {
                price = 8.45;
            }
            else if(Objects.equals(typeGroup, "Business"))
            {
                price = 10.90;
            }
            else if(Objects.equals(typeGroup, "Regular"))
            {
                price = 15;
            }
        }
        else if(Objects.equals(dayOfWeek, "Saturday"))
        {
            if (Objects.equals(typeGroup, "Students"))
            {
                price = 9.80;
            }
            else if (Objects.equals(typeGroup, "Business"))
            {
                price = 15.60;
            }
            else if (Objects.equals(typeGroup, "Regular"))
            {
                price = 20;
            }
        }
        else if(Objects.equals(dayOfWeek, "Sunday"))
        {
            if (Objects.equals(typeGroup, "Students"))
            {
                price = 10.46;
            }
            else if (Objects.equals(typeGroup, "Business"))
            {
                price = 16;
            }
            else if (Objects.equals(typeGroup, "Regular"))
            {
                price = 22.50;
            }
        }

        price *= numberStudent;

        if (numberStudent >= 30 && Objects.equals(typeGroup, "Students"))
        {
            price = price - (price * 0.15);
        }
        else if (numberStudent >= 10 && numberStudent <= 20 && Objects.equals(typeGroup, "Regular"))
        {
            price = price - (price * 0.05);
        }
        else if(numberStudent >= 100 && Objects.equals(typeGroup, "Business"))
        {
            price = price - (price * 0.1);
        }

        System.out.printf("Total price: %.2f", price);
    }
}
