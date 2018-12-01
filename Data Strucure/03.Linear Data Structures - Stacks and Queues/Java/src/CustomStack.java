import java.util.Iterator;

public class CustomStack<T> implements Iterable<T>{
    private T[] array;
    private int capacity = 4;
    private int index;
    private int count;

    public CustomStack(){
        this.array = (T[])new Object[this.capacity];
        this.count = 0;
        this.index = 0;
    }

    public void push(T item){
        if(this.count >= this.capacity){
            resizeArray();
            this.capacity *=2;
        }
        this.array[index] = item;
        this.count++;
        this.index++;
    }

    public T peek(){
        T lastElement = this.array[index - 1];
        return lastElement;
    }

    public T pop(){
        T lastElement = this.array[index - 1];
        this.array[index - 1] = null;
        this.count--;
        this.index--;

        return lastElement;
    }

    public int count(){
        return this.count;
    }

    private void resizeArray(){
        T[] newArray = (T[])new Object[this.capacity * 2];

        for (int i = 0; i <this.array.length; i++) {
            newArray[i] = this.array[i];
        }
        this.array = newArray;
    }

    public T get(int index){
        if(index < 0 || index >= this.count){
            throw new ArrayIndexOutOfBoundsException();
        }
        return this.array[index];
    }

    @Override
    public Iterator<T> iterator() {
        return new ListIterator();
    }
    private final class ListIterator implements Iterator<T>{
        private int counter;

        public ListIterator(){
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
