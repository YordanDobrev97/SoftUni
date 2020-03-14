package implementations;
import interfaces.Deque;
import java.util.Iterator;

public class ArrayDeque<E> implements Deque<E> {
    private final int initialCapacity = 3;
    private E[] data;
    private int size;
    private int capacity;

    public ArrayDeque(){
        this.data = (E[]) new Object[initialCapacity];
        this.size = 0;
        this.capacity = initialCapacity;
    }

    @Override
    public void add(E Element) {
        ensureCapacity();

        this.data[this.size] = Element;
        this.size++;
    }

    @Override
    public void offer(E element) {
        this.add(element);
    }

    @Override
    public void addFirst(E element) {
        ensureCapacity();

        for (int i = this.size; i > 0; i--) {
            this.data[i] = this.data[i - 1];
        }

        this.data[0]= element;
        this.size++;
    }

    private void ensureCapacity() {
        if (!(this.size + 1 <= this.capacity)) {
            this.data = this.resize();
        }
    }

    @Override
    public void addLast(E element) {
        ensureCapacity();

        this.data[this.size] = element;
        this.size++;
    }

    @Override
    public void push(E element) {
        ensureCapacity();

        this.data[this.size] = element;
        this.size++;
    }

    @Override
    public void insert(int index, E element) {
        if (index < 0 || index > this.data.length) {
            throw new IndexOutOfBoundsException("Invalid index!");
        }

        for (int i = index; i < this.size; i++) {
            this.data[i + 1] = this.data[i];
        }
        this.data[index] = element;
    }

    @Override
    public void set(int index, E element) {
        this.insert(index, element);
    }

    @Override
    public E peek() {
        if (this.data.length == 0) {
            return null;
        }
        return this.data[this.data.length - 1];
    }

    @Override
    public E poll() {
        if (this.data.length == 0) {
            return null;
        }

        E element = this.data[0];

        for (int i = 0; i < this.data.length; i++) {
            this.data[i] = this.data[i + 1];
        }

        this.data[this.data.length - 1] = null;
        return element;
    }

    @Override
    public E pop() {
        if (this.data.length == 0) {
            return null;
        }

        E element = this.peek();
        this.data[this.data.length - 1] = null;
        return element;
    }

    @Override
    public E get(int index) {
        if (index < 0 || index > this.data.length) {
            throw new IndexOutOfBoundsException("Invalid index!");
        }

        return this.data[index];
    }

    @Override
    public E get(Object object) {
        return null;
    }

    @Override
    public E remove(int index) {
        if (index < 0 || index > this.data.length) {
            throw new IndexOutOfBoundsException("Invalid index!");
        }
        E element = this.data[index];

        this.data[index] = null;
        return element;
    }

    @Override
    public E remove(Object object) {
        return null;
    }

    @Override
    public E removeFirst() {
        if (this.data.length == 0) {
            return null;
        }

        E element = this.data[0];
        this.data[0] = null;
        return element;
    }

    @Override
    public E removeLast() {
        if (this.data.length == 0){
            return null;
        }
        E element = this.data[this.data.length - 1];
        this.data[this.data.length - 1] = null;
        return element;
    }

    @Override
    public int size() {
        return this.size;
    }

    @Override
    public int capacity() {
        return this.capacity;
    }

    @Override
    public void trimToSize() {

    }

    @Override
    public boolean isEmpty() {
        return this.size == 0;
    }

    private E[] resize() {
        E[] newArray = (E[]) new Object[this.capacity * 2];

        for (int i = 0; i < this.data.length; i++) {
            newArray[i] = this.data[i];
        }
        this.capacity *= 2;
        return newArray;
    }

    @Override
    public Iterator<E> iterator() {
        return null;
    }
}
