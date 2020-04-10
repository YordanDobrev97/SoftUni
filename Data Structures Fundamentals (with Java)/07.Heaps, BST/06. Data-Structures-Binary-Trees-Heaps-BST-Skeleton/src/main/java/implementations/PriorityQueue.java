package implementations;

import interfaces.AbstractQueue;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class PriorityQueue<E extends Comparable<E>> implements AbstractQueue<E> {
    private List<E> queue;

    public PriorityQueue() {
        this.queue = new ArrayList<>();
    }

    @Override
    public int size() {
        return this.queue.size();
    }

    @Override
    public void add(E element) {
        this.queue.add(element);
        addCorrectlyPlace(queue.size() - 1);
    }

    private void addCorrectlyPlace(int index) {
        int parentIndex = (index - 1) / 2;

        while (isNotPlace(index) && parentIsLessChild(index, parentIndex)) {
            Collections.swap(this.queue, index, parentIndex);
            index = parentIndex;
            parentIndex = (index - 1) / 2;
        }
    }

    private boolean isNotPlace(int index) {
        return index > 0;
    }

    private boolean parentIsLessChild(int childIndex, int parentIndex) {
        return this.queue.get(childIndex).compareTo(this.queue.get(parentIndex)) > 0;
    }

    @Override
    public E peek() {
        if (this.queue.size() == 0) {
            throw new IllegalStateException("Heap is empty");
        }

        return this.queue.get(0);
    }

    @Override
    public E poll() {
        if (this.queue.size() == 0) {
            throw new IllegalStateException("Heap is empty");
        }

        E first = this.peek();
        Collections.swap(this.queue, 0, this.queue.size() - 1);
        this.queue.remove(this.queue.size() - 1);
        this.heapify(0);
        return first;
    }
    private void heapify(int index) {
        while (index < this.queue.size() && this.queue.get(index).compareTo(this.queue.get(index + 1)) < 0) {
            int child = 2 * index + 1; //left child

            if (child + 1 < this.queue.size() && this.queue.get(child).compareTo(this.queue.get(child + 1)) < 0){
                child += 1;
            }

            if (this.queue.get(child).compareTo(this.queue.get(index)) < 0) {
                break;
            }

            Collections.swap(this.queue, index, child);
            index = child;
        }
    }
}
