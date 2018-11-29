
public class Main {
    public static void main(String[] args) {
        ArrayList<Integer> list = new ArrayList<>();

        for(int i = 0; i < 10; i++){
            list.add(i + 1);
        }

        for (int value: list) {
            System.out.println(value);
        }
    }
}
