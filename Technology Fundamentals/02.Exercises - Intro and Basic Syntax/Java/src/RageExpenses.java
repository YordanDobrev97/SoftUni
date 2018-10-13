import java.util.Scanner;

public class RageExpenses {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int lostGamesCount = Integer.parseInt(scanner.nextLine());
        double headsetPrice = Double.parseDouble(scanner.nextLine());
        double mousePrice = Double.parseDouble(scanner.nextLine());
        double keyboardPrice = Double.parseDouble(scanner.nextLine());
        double displayPrice = Double.parseDouble(scanner.nextLine());

        int trashedHeadsetCount = 0;
        int trashedMouseCount = 0;
        int trashedKeyboard = 0;
        int trashedDisplay = 0;

        for (int i = 1; i <=lostGamesCount; i++)
        {
            if (i % 2 == 0)
            {
                trashedHeadsetCount++;
            }

            if (i % 3 == 0)
            {
                trashedMouseCount++;
            }

            if (i % 6 == 0)
            {
                trashedKeyboard++;
            }

            if (i % 12 == 0)
            {
                trashedDisplay++;
            }
        }

        double totalCost = trashedHeadsetCount * headsetPrice +
                trashedMouseCount * mousePrice +
                trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;


        System.out.printf("Rage expenses: %.2f lv.",totalCost);
    }
}
