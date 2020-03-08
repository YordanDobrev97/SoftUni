import implementations.*;

public class Main {
    public static void main(String[] args) {
        var linkedList = new SinglyLinkedList<Integer>();

        for (int i = 0; i < 100; i++) {
            linkedList.addLast(i);
        }

        for (int value: linkedList) {
            System.out.println(value);
        }
    }
}
