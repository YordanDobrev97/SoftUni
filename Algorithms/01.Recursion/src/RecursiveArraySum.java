import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class RecursiveArraySum {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        List<Integer> numbers =
                Arrays.stream(console.readLine().split("\\s+"))
                .map(Integer::parseInt).collect(Collectors.toList());

        int length = numbers.get(numbers.size() - 1);
        int sumArray = sumArray(numbers, length);

        System.out.printf("Recursion solution of sum array: %s\n", sumArray);
    }
    static int sumArray(List<Integer> numbers, int index){
        if(index == 1){
            return 1;
        }

        return sumArray(numbers, index - 1) + numbers.get(index - 1);
    }
}
