import implementations.*;

public class Main {
    public static void main(String[] args) {
        ReversedList<String> reversedList = new ReversedList<>();
        reversedList.add("Item 1");
        reversedList.add("Item 2");
        reversedList.add("Item 3");
        reversedList.add("Item 4");
        reversedList.add("Item 5");
        reversedList.add("Item 6");
        reversedList.add("Item 7");
        reversedList.add("Item 8");
        reversedList.add("Item 9");

        while (reversedList.size() > 0) {
            String element = reversedList.removeAt(0);
            System.out.println(element);
        }
        System.out.println(reversedList.size());
    }
}
