import java.util.Scanner;

public class BackIn30Minutes {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int hour = Integer.parseInt(scanner.nextLine());
        int minutes = Integer.parseInt(scanner.nextLine());
        minutes +=30;

        if (minutes > 59){
            hour++;
            minutes-=60;
        }

        if(hour > 23){
            hour = 0;
        }

        if(minutes < 10){
            System.out.printf("%s:0%s", hour, minutes);
        }else{
            System.out.printf("%s:%s", hour, minutes);
        }

    }
}
