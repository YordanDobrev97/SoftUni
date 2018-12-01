import java.util.Iterator;

public class CustomQueue<T> implements Iterable<T> {
    private T[] array;
    private int capacity = 4;
    private int count;
    private int index;
    private int nextIndex;

    public CustomQueue(){
        this.array = (T[])new Object[capacity];
        this.count = 0;
    }

    public T get(int index){
        if(index < 0 || index >= this.count){
            throw new ArrayIndexOutOfBoundsException();
        }
        return this.array[index];
    }

    public void enqueue(T item){
        if(count >= capacity){
            resize();
            this.capacity *=2;
        }
        this.array[index] = item;
        this.count++;
        this.index++;
    }

    public T dequeue(){
        T item = this.array[nextIndex];
        this.array[0] = null;
        this.index--;
        this.count--;
        this.nextIndex++;

        return item;
    }

    public int count(){
        return this.count;
    }

    private void resize() {
        T[] newArray = (T[])new Object[capacity * 2];

        for (int i = 0; i <this.array.length; i++) {
            newArray[i] = this.array[i];
        }
        this.array = newArray;
    }

    @Override
    public Iterator<T> iterator() {
        return new ListIterator();
    }

    private final class ListIterator implements Iterator<T>{
        private int counter;
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
