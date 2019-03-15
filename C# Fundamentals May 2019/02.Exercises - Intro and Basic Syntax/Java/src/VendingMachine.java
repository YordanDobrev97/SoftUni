import java.util.*;

public class VendingMachine {
    static boolean contains(double[] arr, double item){
        for(int i =0; i < arr.length; i++){
            if (arr[i] == item){
                return true;
            }
        }
        return false;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        double totalCoins = 0;
        double[] validCoins = new double[]{
                0.1, 0.2, 0.5, 1, 2
        };

        Map<String, Double> validProducts = new HashMap<>();

        validProducts.put("Nuts", 2.0);
        validProducts.put("Water", 0.7);
        validProducts.put("Crisps",1.5);
        validProducts.put("Soda",0.8);
        validProducts.put("Coke",1.0);

        while (!Objects.equals(input, "Start"))
        {
            double coins = Double.parseDouble(input);
            if (contains(validCoins, coins))
            {
                totalCoins += coins;
            }
            else
            {
                System.out.printf("Cannot accept %s\n", coins);
            }

            input = scanner.nextLine();
        }

        String product = scanner.nextLine();

        while (true)
        {
            if (Objects.equals(product, "End"))
            {
                break;
            }

            if (validProducts.containsKey(product))
            {
                double value = validProducts.get(product);
                if ((totalCoins - value) >= 0)
                {
                    System.out.printf("Purchased %s\n", product);
                    totalCoins -= value;
                }
                else
                {
                    System.out.println("Sorry, not enough money");
                }

            }
            else
            {
                System.out.println("Invalid product");
            }

            product = scanner.nextLine();
        }

        System.out.printf("Change: %.2f\n", totalCoins);
    }
}
