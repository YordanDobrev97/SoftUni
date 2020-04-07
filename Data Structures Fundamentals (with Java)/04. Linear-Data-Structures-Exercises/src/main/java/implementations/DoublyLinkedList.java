package implementations;
import interfaces.LinkedList;

import java.util.Iterator;

public class DoublyLinkedList<E> implements LinkedList<E> {
    private Node<E> head;
    private Node<E> tail;
    private int size;

    private static class Node<E> {
        E value;
        Node<E> next;
        Node<E> prev;

        Node(E value) {
            this.value = value;
        }
    }

    public DoublyLinkedList() {
    }

    @Override
    public void addFirst(E element) {
        if (this.head == null) {
            this.head = new Node<E>(element);
            this.tail = this.head;
        } else {
            Node<E> newNode = new Node<E>(element);
            newNode.next = this.head;
            this.head.prev = newNode;
            this.head = newNode;
        }
        this.size++;
    }

    @Override
    public void addLast(E element) {
        if (this.head == null) {
            this.head = new Node<>(element);
            this.tail = this.head;
        } else {
            Node<E> newNode = new Node<E>(element);
            newNode.prev = this.tail;
            this.tail.next = newNode;
            this.tail = newNode;
        }
        this.size++;
    }

    @Override
    public E removeFirst() {
        E first = this.head.value;
        this.head = this.head.next;
        this.size--;
        return first;
    }

    @Override
    public E removeLast() {
        E last = this.tail.value;
        this.tail = this.tail.prev;
        this.size--;
        return last;
    }

    @Override
    public E getFirst() {
        return this.head.value;
    }

    @Override
    public E getLast() {
        return this.tail.value;
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
                return current != null;
            }

            @Override
            public E next() {
                E element = current.value;
                current = current.next;
                return element;
            }
        };
    }
}
