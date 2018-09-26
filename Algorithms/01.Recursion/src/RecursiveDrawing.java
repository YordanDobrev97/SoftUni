import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class RecursiveDrawing {
    public static void main(String[] args) throws IOException {
        BufferedReader console = new BufferedReader(
                new InputStreamReader(System.in));

        int number = Integer.parseInt(console.readLine());

        drawing(number);
    }
    static void drawing(int number){
        if(number <= 0){
            return;
        }

        for(int j = 0; j < number; j++){
            System.out.print("*");
        }
        System.out.println();

        drawing(number - 1);

        for(int j = 0; j < number; j++){
            System.out.print("#");
        }
        System.out.println();
    }
}
