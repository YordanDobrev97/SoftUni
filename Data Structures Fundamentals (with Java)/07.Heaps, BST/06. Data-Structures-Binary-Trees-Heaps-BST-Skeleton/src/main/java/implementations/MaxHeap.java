package implementations;

import interfaces.Heap;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class MaxHeap<E extends Comparable<E>> implements Heap<E> {
    private List<E> items;

    public MaxHeap() {
        this.items = new ArrayList<>();
    }

    @Override
    public int size() {
        return this.items.size();
    }

    @Override
    public void add(E element) {
        this.items.add(element);
        heapifyUp(this.size() - 1);
    }

    private void heapifyUp(int index) {
        while (index > 0 && isLess(index, getParentIndex(index))) {
            Collections.swap(this.items, index, getParentIndex(index));
            index = getParentIndex(index);
        }
    }

    private boolean isLess(int index, int parentIndex) {
        return this.items.get(index).compareTo(this.items.get(parentIndex)) > 0;
    }

    private int getParentIndex(int index) {
        return (index - 1) / 2;
    }

    @Override
    public E peek() {
        if (this.size() == 0) {
            throw new IllegalStateException("Empty heap!");
        }
        return this.items.get(0);
    }
}
