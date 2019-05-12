import java.io.IOException;
import java.util.Scanner;
public class CharsToString {
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);

        String firstSymbol = scanner.nextLine();
        String secondSymbol = scanner.nextLine();
        String thirdSymbol = scanner.nextLine();

        String concatSymbols = firstSymbol;
        concatSymbols = concatSymbols.concat(secondSymbol);
        concatSymbols = concatSymbols.concat(thirdSymbol);

        System.out.println(concatSymbols);
    }
}
