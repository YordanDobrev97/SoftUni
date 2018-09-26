import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class IterativeArraySum {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        List<Integer> numbers =
                Arrays.stream(console.readLine().split("\\s+"))
                        .map(Integer::parseInt).collect(Collectors.toList());

        int sum = 0;

        for(Integer number: numbers){
            sum += number;
        }

        System.out.printf("Iterative solution sum of array: %s", sum);
    }
}
