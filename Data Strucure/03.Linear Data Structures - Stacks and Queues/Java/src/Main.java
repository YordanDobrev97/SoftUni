public class Main {
    public static void main(String[] args) {
        CustomQueue<Integer> queue = new CustomQueue<>();
        queue.enqueue(1);
        queue.enqueue(2);
        queue.enqueue(3);
        queue.enqueue(4);
        queue.enqueue(5);

        for(int value: queue){
            System.out.printf("Enqueue: %s%n",value);
        }

        int count = queue.count();
        while (count > 0){
            System.out.printf("Dequeue: %s%n", queue.dequeue());
            count = queue.count();
        }


        CustomStack<Integer> stack = new CustomStack<>();
        stack.push(1);
        stack.push(2);
        stack.push(5);
        stack.push(7);
        stack.push(9);
        stack.push(10);
        stack.push(11);

        int popElement = stack.pop();
        System.out.printf("Pop element: %s%n", popElement);
        stack.push(500);
        int peekElement = stack.peek();
        System.out.printf("Peek element %s%n", peekElement);

        for (int i = 1; i <=100; i++) {
            stack.push(i);
        }

        for(int value: stack){
            System.out.println(value);
        }

        System.out.println();
        for (int i = 1; i <=100 ; i++) {
            System.out.printf("Pop elements: %s%n", stack.pop());
        }
        int countStack = stack.count();
        System.out.printf("Size of stack: %s", countStack);

    }
}
