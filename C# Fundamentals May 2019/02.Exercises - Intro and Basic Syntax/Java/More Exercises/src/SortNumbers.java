import java.util.Scanner;

public class SortNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int firstNumber = Integer.parseInt(scanner.nextLine());
        int secondNumber = Integer.parseInt(scanner.nextLine());
        int thirdNumber = Integer.parseInt(scanner.nextLine());

        int biggestNumber = firstNumber;

        if (secondNumber > biggestNumber) {
            biggestNumber = secondNumber;
        }

        if (thirdNumber > biggestNumber) {
            biggestNumber = thirdNumber;
        }

        int smallestNumber = firstNumber;

        if (secondNumber < smallestNumber) {
            smallestNumber = secondNumber;
        }

        if (thirdNumber < smallestNumber) {
            smallestNumber = thirdNumber;
        }

        int middleNumber = firstNumber;

        boolean isFoundMiddleNumber = false;
        int counter = 1;

        while (!(isFoundMiddleNumber)) {
            if (counter == 1) {
                if (!(middleNumber > smallestNumber && middleNumber < biggestNumber)) {
                    middleNumber = secondNumber;
                }
            } else {
                if (!(middleNumber > smallestNumber && middleNumber < biggestNumber)) {
                    middleNumber = thirdNumber;
                }
            }
            counter++;
            isFoundMiddleNumber = counter >= 3;
        }

        System.out.println(biggestNumber);
        System.out.println(middleNumber);
        System.out.println(smallestNumber);
    }
}
