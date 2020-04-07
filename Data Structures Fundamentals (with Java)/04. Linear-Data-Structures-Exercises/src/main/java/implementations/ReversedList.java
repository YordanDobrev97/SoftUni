package implementations;
import java.util.Iterator;
import java.util.Arrays;
public class ReversedList<E> implements Iterable<E> {
    private final int INITIAL_CAPACITY = 2;
    private E[] list;
    private int capacity;
    private int index;
    private int size;

    public ReversedList() {
        this.list = (E[]) new Object[INITIAL_CAPACITY];
        this.capacity = INITIAL_CAPACITY;
    }

    public boolean add(E element) {
        if (noEnoughCapacity()) {
            resize();
        }

        this.size++;
        this.list[this.index++] = element;
        return true;
    }

    public E get(int index) {
        throwExceptionIfOutOfRange(index);

        return this.list[this.size - 1 - index];
    }

    public E removeAt(int index) {
        throwExceptionIfOutOfRange(index);

        int position = this.size - 1 - index;
        E element = this.list[position];

        for (int i = position; i < this.size - 1; i++) {
            this.list[i] = this.list[i + 1];
        }

        this.size--;
        return element;
    }

    private void throwExceptionIfOutOfRange(int index) {
        if (index < 0 || index >= this.size()) {
            throw new IndexOutOfBoundsException("Out of range!");
        }
    }

    public int size() {
        return this.size;
    }

    public int capacity() {
        return capacity;
    }

    private void resize() {
        this.capacity *= 2;
        this.list = Arrays.copyOf(this.list, this.capacity);
    }

    private boolean noEnoughCapacity() {
        return this.size() + 1 > this.capacity();
    }

    @Override
    public Iterator<E> iterator() {
        return new Iterator<E>() {
            private int index = size() - 1;
            @Override
            public boolean hasNext() {
                return this.index >= 0;
            }

            @Override
            public E next() {
                E value = list[this.index];
                this.index -= 1;
                return value;
            }
        };
    }
}
