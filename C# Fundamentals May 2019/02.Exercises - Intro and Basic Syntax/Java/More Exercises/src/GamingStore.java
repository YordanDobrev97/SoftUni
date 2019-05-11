import java.util.Scanner;
public class GamingStore {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double balance = Double.parseDouble(scanner.nextLine());
        double totalPrice = 0;

        while (true) {
            String input = scanner.nextLine();
            if (input.equals("Game Time")) {
                break;
            }
            double gamePrice = 0;

            switch (input) {
                case "OutFall 4":
                    gamePrice = 39.99;
                    break;
                case "CS: OG":
                    gamePrice = 15.99;
                    break;
                case "Zplinter Zell":
                    gamePrice = 19.99;
                    break;
                case "Honored 2":
                    gamePrice = 59.99;
                    break;
                case "RoverWatch":
                    gamePrice = 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    gamePrice = 39.99;
                    break;
                default:
                    System.out.println("Not Found");
                    continue;
            }

            if (gamePrice > balance) {
                System.out.println("Too Expensive");
                continue;
            }

            balance -= gamePrice;
            totalPrice += gamePrice;

            System.out.printf("Bought %s\n", input);

            if (balance == 0) {
                System.out.println("Out of money!");
            }
        }

        System.out.printf("Total spent: $%.2f. Remaining: $%.2f", totalPrice, balance);
    }
}
