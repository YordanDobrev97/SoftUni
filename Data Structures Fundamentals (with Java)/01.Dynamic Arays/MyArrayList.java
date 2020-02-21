import java.util.Iterator;

public class MyArrayList<T> implements Iterable<T> {
    private T[] data;
    private int count;
    private final int defaultSize = 2;

    public MyArrayList() {
        this.data = (T[]) new Object[this.defaultSize];
    }

    public T get(final int ind) {
        if (ind < 0 || ind >= this.count()) {
            throw new ArrayIndexOutOfBoundsException();
        }
        return this.data[ind];
    }

    public void add(final T item) {
        if (this.count >= this.data.length) {
            resize();
        }

        this.data[this.count] = item;
        this.count++;
    }

    public void removeAt(final int index) {
        if (index < 0 || index > this.data.length - 1) {
            throw new ArrayIndexOutOfBoundsException();
        }

        for (int i = index; i < this.data.length - 1; i++) {
            this.data[i] = this.data[i + 1];
        }

        this.count--;
    }

    public T remove() {
        this.count--;
        return this.data[this.data.length -1];
    }
    
    public int count() {
        return this.count;
    }

    @Override
    public Iterator<T> iterator() {
        return new ListIterator();
    }

    private void resize() {
        final T[] newArray = (T[]) new Object[this.data.length * 2];

        for (int i = 0; i < this.data.length; i++) {
            newArray[i] = this.data[i];
        }
        this.data = newArray;
    }

    private final class ListIterator implements Iterator<T> {
        private int counter;

        public ListIterator() {
            this.counter = 0;
        }

        @Override
        public boolean hasNext() {
            return count > this.counter;
        }

        @Override
        public T next() {
            return get(this.counter++);
        }
    }
}