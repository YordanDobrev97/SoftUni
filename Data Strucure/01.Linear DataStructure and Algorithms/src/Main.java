public class Main {
    public static void main(String[] args) {
        CustomArrayList<Integer> list = new CustomArrayList<>();
        list.add(2);
        list.add(23);
        list.add(24);
        list.add(25);
        list.add(29);

        int removeItem = list.removeAt(0);
        int countArray = list.count();

        System.out.printf("Count array: %s%n", countArray);
        System.out.printf("Remove item: %s%n", removeItem);

        for (int value: list) {
            System.out.println(value);
        }
    }
}
