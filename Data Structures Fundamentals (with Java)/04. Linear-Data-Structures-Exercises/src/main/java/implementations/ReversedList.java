package implementations;
import java.util.*;
import java.util.Iterator;

public class ReversedList<E> {
    private E[] data;
    private int size = 0;
    private int currentSize;
    private int capacity = 2;

    public ReversedList() {
        this.data = (E[]) new Object[this.capacity];
        this.currentSize = 0;
    }

    public boolean add(E element) {
        if (this.currentSize >= this.capacity) {
            this.data = resize();
            this.capacity *= 2;
            this.data[0] = element;
        } else {
            if (this.currentSize + 1 == this.capacity) {
                for (int i = this.currentSize; i > 0; i--) {
                    this.data[i] = this.data[i - 1];
                }
                this.data[0] = element;
            } else {
                this.data[currentSize] = element;
                reverseData();
            }
        }
        this.currentSize++;
        return true;
    }

    private void reverseData() {
        E[] reversedElements = (E[]) new Object[this.data.length];
        int index = 0;
        for (int i = currentSize; i >= 0; i--) {
            reversedElements[index++] = this.data[i];
        }
        this.data = reversedElements;
    }

    public E get(int index) {
        if (!isValidIndex(index)) {
            throw new IndexOutOfBoundsException("Invalid index");
        }
        return this.data[index];
    }

    public int capacity() {
        return this.capacity;
    }

    public E set(int index, E element) {
        if (!isValidIndex(index)) {
            throw new IndexOutOfBoundsException("Invalid index");
        }
        E prevValue = this.data[index];
        this.data[index] = element;
        return prevValue;
    }

    public E removeAt(int index) {
        if (!isValidIndex(index)) {
            throw new IndexOutOfBoundsException("Invalid index");
        }

        var element = this.data[index];

        //shift
        for (int i = index; i < this.size() - 1; i++) {
            this.data[i] = this.data[i + 1];
        }
        this.data[this.size() - 1] = null;
        if (this.currentSize == this.data.length / 2) {
            this.data = shrink();
        }
        this.currentSize--;

        reverseData();
        return element;
    }

    public int size() {
        return this.currentSize;
    }

    public int indexOf(E element) {
        int index = -1;

        for (int i = 0; i < this.data.length; i++) {
            if (element.equals(this.data[i])) {
                index = i;
                break;
            }
        }

        return index;
    }

    public boolean isEmpty() {
        return this.currentSize == 0;
    }

    public Iterator<E> iterator() {
        return new ListIterator();
    }

    private E[] shrink() {
        var newArray = (E[]) new Object[Math.max(this.data.length / 2, this.size)];

        for (int i = 0; i < this.size(); i++) {
            newArray[i] = this.data[i];
        }
        return newArray;
    }

    private E[] resize() {
        var newArray = (E[]) new Object[this.currentSize * 2];
        for (int i = 0; i < this.currentSize; i++) {
            newArray[i + 1] = this.data[i];
        }
        return newArray;
    }

    private boolean isValidIndex(int index) {
        return index >= 0 && index <= this.size() - 1;
    }

    private final class ListIterator implements Iterator<E> {
        private int counter;

        public ListIterator() {
            this.counter = 0;
        }

        @Override
        public boolean hasNext() {
            return this.counter <= size() - 1;
        }

        @Override
        public E next() {
            return get(this.counter++);
        }
    }
}
