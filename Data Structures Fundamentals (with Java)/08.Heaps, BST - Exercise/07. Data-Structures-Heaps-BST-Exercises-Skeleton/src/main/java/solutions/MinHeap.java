package solutions;

import interfaces.Decrease;
import interfaces.Heap;
import java.util.List;
import java.util.ArrayList;
import java.util.Collections;

public class MinHeap<E extends Comparable<E> & Decrease<E>> implements Heap<E> {
    private List<E> heap;

    public MinHeap() {
        this.heap = new ArrayList<>();
    }

    @Override
    public int size() {
        return this.heap.size();
    }

    @Override
    public void add(E element) {
        this.heap.add(element);
        this.heapifyUp(this.heap.size() - 1);
    }

    private void heapifyUp(int index) {
        while (index > 0 && isLess(index, getParentIndex(index))) {
            Collections.swap(this.heap, index, getParentIndex(index));
            index = getParentIndex(index);
        }
    }



    @Override
    public E peek() {
        ensureNotEmpty();
        return this.heap.get(0);
    }

    private void ensureNotEmpty() {
        if (this.heap.size() == 0) {
            throw new IllegalStateException("Empty heap");
        }
    }

    @Override
    public E poll() {
        ensureNotEmpty();

        E element = this.peek();
        Collections.swap(this.heap, 0, this.heap.size() - 1);
        this.heap.remove(this.heap.size() - 1);
        this.heapfyDown(0);

        return element;
    }

    private void heapfyDown(int index) {
        
    }

    @Override
    public void decrease(E element) {

    }

    private boolean isLess(int index, int parentIndex) {
        return this.heap.get(index).compareTo(this.heap.get(parentIndex)) < 0;
    }

    private int getParentIndex(int index) {
        return (index - 1) / 2;
    }
}
