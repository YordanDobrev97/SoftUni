import java.util.Iterator;

public class CustomArrayList<T> implements Iterable<T> {
    private int capacity = 4;
    private T[] array;
    private int count;
    private int index;

    public CustomArrayList(){
        this.array = (T[]) new Object[capacity];
    }

    public void add(T element){
        if(this.count >=this.capacity){
            resizeArray();
            this.capacity *=2;
        }
        this.array[index] = element;
        this.count++;
        this.index++;
    }

    public T removeAt(int index){
        T item = this.array[index];

        for(int i = index; i < this.array.length - 1; i++){
            this.array[i] = this.array[i + 1];
        }

        this.count--;
        return item;
    }

    public int count(){
        return this.count;
    }

    public T get(int index){
        if(index < 0 || index >= this.count){
            throw new ArrayIndexOutOfBoundsException();
        }
        return this.array[index];
    }

    private void resizeArray() {
        T[] newArray = (T[])new Object[count * 2];

        for (int i = 0; i < array.length; i++){
            newArray[i] = array[i];
        }
        this.array = newArray;
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
