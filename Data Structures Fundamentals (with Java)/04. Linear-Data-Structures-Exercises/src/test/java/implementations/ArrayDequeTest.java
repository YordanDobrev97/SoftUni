package implementations;

import static org.junit.Assert.*;

public class ArrayDequeTest {

    @org.junit.Test
    public void testAddInMiddleArrayDeque() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();
        numbers.add(3);
        numbers.add(2);
        numbers.add(1);
        assertEquals(Integer.valueOf(3), numbers.get(3));
        assertEquals(Integer.valueOf(2), numbers.get(4));
        assertEquals(Integer.valueOf(1), numbers.get(5));
    }

    @org.junit.Test
    public void testAddFullCapacityOfArrayDeque() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();

        numbers.add(3);
        numbers.add(2);
        numbers.add(1);
        numbers.add(0);
        numbers.add(2);
        numbers.add(9);
        int expectedCapacity = 14;
        int actialCapacity = numbers.capacity();
        assertEquals(expectedCapacity, actialCapacity);
    }

    @org.junit.Test
    public void testAddFirstShouldBeCorrectlyAdding() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();

        numbers.add(3);
        numbers.add(2);
        numbers.addFirst(10);

        int expectedCapacity = 10;
        int actialCapacity = numbers.get(2);
        assertEquals(expectedCapacity, actialCapacity);
    }

    @org.junit.Test
    public void testAddLastShouldBeCorrectlyAdding() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();

        numbers.addLast(10);
        numbers.addLast(20);

        int expectedCapacity = 20;
        int actialCapacity = numbers.get(4);
        assertEquals(expectedCapacity, actialCapacity);
    }

    @org.junit.Test
    public void testOfferAddingInArrayDeque() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();
        numbers.offer(1);
        numbers.offer(2);
        numbers.offer(3);

        int expectedCapacity = 3;
        int actialCapacity = numbers.get(5);
        assertEquals(expectedCapacity, actialCapacity);
    }

    @org.junit.Test
    public void testPopFromStack() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();
        numbers.push(3);
        int top = numbers.pop();

        int expectedCapacity = 3;

        int size = 0;
        assertEquals(expectedCapacity, top);
        assertEquals(size, numbers.size());
    }

    @org.junit.Test
    public void testRemoveFirst() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();
        numbers.addFirst(3);
        int element = numbers.removeFirst();

        int expectedCapacity = 3;

        int size = 0;
        assertEquals(expectedCapacity, element);
        assertEquals(size, numbers.size());
    }

    @org.junit.Test
    public void testRemoveLast() {
        ArrayDeque<Integer> numbers = new ArrayDeque<>();
        numbers.addLast(3);
        numbers.addLast(13);
        int element = numbers.removeLast();

        int expectedCapacity = 13;

        int size = 1;
        assertEquals(expectedCapacity, element);
        assertEquals(size, numbers.size());
    }
}