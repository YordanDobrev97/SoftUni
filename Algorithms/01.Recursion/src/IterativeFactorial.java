import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class IterativeFactorial {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        int number = Integer.parseInt(console.readLine());

        int factorial = 1;

        for(int i = number; i > 0; i--){
            factorial *=i;
        }
        System.out.printf("Iterative solution of factorial: %s",factorial);
    }
}
