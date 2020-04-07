package implementations;
import interfaces.AbstractQueue;
import java.util.Iterator;
import java.util.List;
import java.util.ArrayList;

public class Queue<E> implements AbstractQueue<E> {
    private Node<E> head;
    private Node<E> tail;
    private int size;

    private List<E> list;

    public Queue() {
        this.list = new ArrayList<>();
    }

    private static final class Node<E> {
        private E value;
        Node<E> next;

        Node(E value) {
            this.value = value;
        }
    }

    @Override
    public void offer(E element) {
        //this.list.add(element);

        if (this.head == null) {
            this.head = new Node<>(element);
            this.tail = this.head;
        } else {
            Node<E> newNode = new Node<E>(element);
            this.tail.next = newNode;
            this.tail = newNode;
        }

        this.size++;
    }

    @Override
    public E poll() {
        if (this.size() == 0) {
            throw new IllegalStateException("Empty queue");
        }

        E first = this.head.value;
        this.head = this.head.next;

        //E first = this.list.remove(0);
        this.size--;
        return first;
    }

    @Override
    public E peek() {
        if (this.size() == 0) {
            throw new IllegalStateException("Empty queue");
        }

        return this.head.value;
        //return this.list.get(0);
    }

    @Override
    public int size() {
        return this.size;
    }

    @Override
    public boolean isEmpty() {
        return this.size() == 0;
    }

    @Override
    public Iterator<E> iterator() {
       return new Iterator<E>() {
           private Node<E> current = head;
           @Override
           public boolean hasNext() {
               return this.current.next != null;
           }

           @Override
           public E next() {
               E value = current.value;
               current = current.next;
               return value;
           }

           /*
           @Override
           public boolean hasNext() {
               return list.size() > 0;
           }

           @Override
           public E next() {
               return list.remove(0);
           }
            */
       };
    }

}
