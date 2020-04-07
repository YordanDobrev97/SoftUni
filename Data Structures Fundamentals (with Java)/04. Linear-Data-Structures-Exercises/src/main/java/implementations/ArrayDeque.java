package implementations;
import interfaces.Deque;
import java.util.Iterator;

public class ArrayDeque<E> implements Deque<E> {
   private final int INITIAL_CAPACITY = 7;
   private Object[] list;
   private int capacity;
   private int head;
   private int tail;
   private int size;
   private int middle;

    public ArrayDeque() {
        this.list = new Object[this.INITIAL_CAPACITY];
        this.middle = this.list.length / 2;
        this.head = this.tail = this.middle;
        this.capacity = this.INITIAL_CAPACITY;
    }

    @Override
    public void add(E element) {
        if (this.size == 0) {
            this.list[this.tail] = element;
        } else {
            this.tail++;
            if (this.tail >= this.capacity()) {
                this.list = grow();
            }
            this.list[this.tail] = element;
        }
        this.size++;
    }

    @Override
    public void offer(E element) {
        this.add(element);
    }

    @Override
    public void addFirst(E element) {
        if (this.head == 0) {
            this.list = grow();
        }
        this.list[this.head - 1] = element;
        this.head--;
        this.size++;
    }

    @Override
    public void addLast(E element) {
        if (this.tail >= this.capacity()) {
            this.list = grow();
        }
        this.list[this.tail++] = element;
        this.size++;
    }

    @Override
    public void push(E element) {
        this.add(element);
    }

    @Override
    public void insert(int index, E element) {

    }

    @Override
    public void set(int index, E element) {

    }

    @Override
    public E peek() {
        E element = (E) this.list[this.tail];
        return element;
    }

    @Override
    public E poll() {
        E element = (E) this.list[this.head];
        this.list[this.head] = null;
        this.head++;
        this.size--;
       return element;
    }

    @Override
    public E pop() {
        E element = this.peek();
        this.list[this.tail - 1] = null;
        this.size--;
        return element;
    }

    @Override
    public E get(int index) {
        return (E) this.list[index];
    }

    @Override
    public E get(Object object) {
        return null;
    }

    @Override
    public E remove(int index) {
        return null;
    }

    @Override
    public E remove(Object object) {
        return null;
    }

    @Override
    public E removeFirst() {
        E element = (E) this.list[this.head];
        this.list[this.head] = null;
        this.head++;
        this.size--;
        return element;
    }

    @Override
    public E removeLast() {
        E element = (E) this.list[this.tail - 1];
        this.list[this.tail] = null;
        this.tail--;
        this.size--;
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
        return this.size() == 0;
    }

    @Override
    public java.util.Iterator<E> iterator() {
        return null;
    }

    private Object[] grow() {
        this.capacity *= 2;
        Object[] newArray = new Object[this.capacity + 1];

        int newMiddle = newArray.length / 2;

        int indexList = this.head;
        for (int i = newMiddle; indexList < this.tail; i++) {
            newArray[i] = this.list[indexList++];
        }

        this.head = newMiddle;
        this.tail = this.head + this.size;
        return newArray;
    }
}
