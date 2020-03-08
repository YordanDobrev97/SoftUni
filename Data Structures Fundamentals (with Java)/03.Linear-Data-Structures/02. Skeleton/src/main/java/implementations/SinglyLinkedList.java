package implementations;
import interfaces.LinkedList;
import java.util.Iterator;

public class SinglyLinkedList<E> implements LinkedList<E> {
    private static class Node<E> {
        private E value;
        private Node<E> next;

        public Node(E value) {
            this.value = value;
        }

        public Node<E> next() {
            return this.next;
        }

        public void setNext(Node<E> value) {
            this.next = value;
        }
    }

    private Node<E> node;
    private Node<E> end;
    private int size;

    @Override
    public void addFirst(E element) {
        var newNode = new Node<E>(element);
        newNode.setNext(this.node);
        this.node = newNode;
        this.size++;
    }

    @Override
    public void addLast(E element) {
        var newNode = new Node<E>(element);

        if (this.node != null){
            var lastNode = getLastNode();
            lastNode.setNext(newNode);
        } else {
            this.node = newNode;
        }

        this.end = newNode;
        this.size++;
    }

    @Override
    public E removeFirst() {
        if (this.node == null) {
            throw new IllegalStateException("Empty!");
        }

        E firstValue = this.node.value;
        this.node = this.node.next;
        this.size--;
        return firstValue;
    }

    @Override
    public E removeLast() {
        if (this.node == null) {
            throw new IllegalStateException("Empty!");
        }

        var last = this.node;
        var currentNode = this.node;

        while (true) {
            if (currentNode.next == null) {
                break;
            }
            last = currentNode;
            currentNode = currentNode.next;
        }

        E value = last.next.value;
        last.next = null;
        this.end = last;
        this.size--;
        return value;
    }

    @Override
    public E getFirst() {
        if (this.node == null) {
            throw new IllegalStateException("Empty!");
        }

        return this.node.value;
    }

    @Override
    public E getEnd() {
        if (this.node == null) {
            throw new IllegalStateException("Empty!");
        }
        return this.end.value;
    }

    @Override
    public int size() {
        return this.size;
    }

    @Override
    public boolean isEmpty() {
        return this.size == 0;
    }

    @Override
    public Iterator<E> iterator() {
        return  new ListIterator();
    }

    private Node<E> getLastNode() {
        var last = this.node;
        while (last.next != null) {
            last = last.next;
        }
        return last;
    }

    private final class ListIterator implements Iterator<E> {
        private Node<E> current;

        ListIterator() {
            current = node;
        }
        @Override
        public boolean hasNext() {
            return current != null;
        }

        @Override
        public E next() {
            E next = this.current.value;
            this.current = this.current.next;
            return next;
        }
    }
}