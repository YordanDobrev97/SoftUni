import java.util.Scanner;

public class PadawanEquipment {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double amountMoney = Double.parseDouble(scanner.nextLine());
        int numberStudents = Integer.parseInt(scanner.nextLine());
        double numberLightsabers = Double.parseDouble(scanner.nextLine());
        double numberRobes = Double.parseDouble(scanner.nextLine());
        double numberBelts = Double.parseDouble(scanner.nextLine());

        double discountStudents = Math.ceil(numberStudents + (numberStudents * 0.10));
        double lightsabersPrice = numberLightsabers * discountStudents;
        double robesPrice = numberRobes * numberStudents;
        double discountBelts = numberStudents - numberStudents / 6;
        double beltsPrice = numberBelts * discountBelts;

        double price = lightsabersPrice + robesPrice + beltsPrice;

        if (price <= amountMoney)
        {
            System.out.printf("The money is enough - it would cost %.2flv.", price);
        }
        else
        {
            System.out.printf("Ivan Cho will need %.2flv more.",price - amountMoney);
        }
    }
}
