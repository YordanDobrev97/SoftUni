import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class RecursiveFactorial {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        int number = Integer.parseInt(console.readLine());

        int factorial = factorial(number);
        System.out.printf("Recursion solution of Factorial: %s",factorial);
    }
    private static int factorial(int number){
        if(number == 0){
            return  1;
        }

        return  number * factorial(number - 1);
    }
}
