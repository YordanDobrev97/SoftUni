public class Main {
    public static void main(String[] args) {
        MyArrayList<String> list = new MyArrayList<>();
        list.add("Pesho");
        list.add("Gosho");
        list.add("Ivo");
        list.add("Penka");
        list.add("Toshka");

        list.remove();
        list.remove();
        list.remove();

        for (int i = 0; i < list.count(); i++) {
            System.out.println(list.get(i));
        }
    }
}