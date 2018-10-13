import java.util.Objects;
import java.util.Scanner;

public class Login {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String userName = scanner.nextLine();
        String password = new StringBuilder(userName)
                .reverse()
                .toString();

        //String reversedPassword = string.Join("", password);

        String passwordInput = scanner.nextLine();
        int count = 1;
        boolean hasCorrectlyPassword = false;
        while (true)
        {
            if (Objects.equals(passwordInput, password))
            {
                hasCorrectlyPassword = true;
                break;
            }

            if (count >=4)
            {
                break;
            }
            System.out.println("Incorrect password. Try again.");
            count++;
            passwordInput = scanner.nextLine();
        }

        if (!hasCorrectlyPassword)
        {
            System.out.printf("User %s blocked!", userName);
        }
        else
        {
            System.out.printf("User %s logged in.", userName);
        }
    }
}
