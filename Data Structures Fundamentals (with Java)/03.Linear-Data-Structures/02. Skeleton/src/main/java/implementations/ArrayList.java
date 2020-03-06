package implementations;
import interfaces.List;
import java.util.Iterator;

public class ArrayList<E> implements List<E> {
    private E[] data;
    private int size = 4;
    private int currentSize;

    public ArrayList() {
        this.data = (E[]) new Object[this.size];
        this.currentSize = 0;
    }

    @Override
    public boolean add(E element) {
        if (currentSize > this.data.length - 1) {
            this.data = resize();
        }
        this.data[currentSize] = element;
        this.currentSize++;
        return true;
    }

    @Override
    public boolean add(int index, E element) {
        if (!isValidIndex(index)) {
            throw new IndexOutOfBoundsException("Invalid index");
        }

        if (this.currentSize <= this.data.length) {
            for (int i = this.currentSize; i > index ; i--) {
                this.data[i] = this.data[i - 1];
            }
            this.data[index] = element;
        } else {
            var newArray = (E[]) new Object[this.currentSize * 2];
            for (int i = 0; i < index; i++) {
                newArray[i] = this.data[i];
            }

            newArray[index] = element;

            for (int i = index + 1; i < this.currentSize; i++) {
                newArray[i] = this.data[i - 1];
            }
            this.data = newArray;
        }
        this.currentSize++;
        return true;
    }

    @Override
    public E get(int index) {
        if (!isValidIndex(index)) {
            throw new IndexOutOfBoundsException("Invalid index");
        }
        return this.data[index];
    }

    @Override
    public E set(int index, E element) {
        if (!isValidIndex(index)) {
            throw new IndexOutOfBoundsException("Invalid index");
        }
        E prevValue = this.data[index];
        this.data[index] = element;
        return prevValue;
    }

    @Override
    public E remove(int index) {
        if (!isValidIndex(index)) {
            throw new IndexOutOfBoundsException("Invalid index");
        }

        var element = this.data[index];

        //shift
        for (int i = index; i < this.size(); i++) {
            this.data[i] = this.data[i + 1];
        }
        this.data[this.size()] = null;
        if (this.currentSize == this.data.length / 2) {
            this.data = shrink();
        }
        this.currentSize--;
        return element;
    }

    @Override
    public int size() {
        return this.currentSize;
    }

    @Override
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

    @Override
    public boolean contains(E element) {
        var isContains = false;

        for (int i = 0; i < this.data.length; i++) {
            if (this.indexOf(element) != -1) {
                isContains = true;
                break;
            }
        }

        return isContains;
    }

    @Override
    public boolean isEmpty() {
        return this.currentSize == 0;
    }

    @Override
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
            newArray[i] = this.data[i];
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