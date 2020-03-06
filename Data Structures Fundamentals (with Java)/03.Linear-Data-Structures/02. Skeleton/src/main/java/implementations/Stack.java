package implementations;
import interfaces.AbstractStack;
import java.util.Iterator;

public class Stack<E> implements AbstractStack<E> {
    private E[] data;
    private int size;
    private int index;
    private int capacity = 4;

    public Stack() {
        this.data =  (E[]) new Object[this.capacity];
    }

    @Override
    public void push(E element) {
        if (this.size == this.capacity) {
            this.data = resize();
            this.capacity *= 2;
        }

        this.data[this.size] = element;
        this.size++;
    }

    @Override
    public E pop() {
        if (this.isEmpty()) {
            throw new IllegalStateException("Empty stack");
        }
        var top = this.data[this.size - 1];
        this.data[this.size - 1] = null;
        this.size--;
        return top;
    }

    @Override
    public E peek() {
        if (this.isEmpty()) {
            throw new IllegalStateException("Empty stack");
        }
        return this.data[this.size - 1];
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
        return new ListIterator();
    }

    private E[] resize() {
        var newArray = (E[]) new Object[this.size * 2];
        for (int i = 0; i < this.data.length; i++) {
            newArray[i] = this.data[i];
        }
        return newArray;
    }

    private final class ListIterator implements Iterator<E> {
        @Override
        public boolean hasNext() {
            return size() > 0;
        }

        @Override
        public E next() {
            return pop();
        }
    }
}
