import implementations.*;

public class Main {
    public static void main(String[] args) {
        DoublyLinkedList<String> linkedList = new DoublyLinkedList<>();
        linkedList.addFirst("73");

        System.out.println(linkedList.getFirst());
    }
}
