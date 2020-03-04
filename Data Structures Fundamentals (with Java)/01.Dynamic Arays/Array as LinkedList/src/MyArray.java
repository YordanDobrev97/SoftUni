public class MyArray<E> {
    private class ArrayNode<E> {
        private E value;
        private ArrayNode<E> nextAddress;

        public ArrayNode(E value){
            this.value = value;
            this.nextAddress = null;
        }
    }

    private ArrayNode<E> data;
    private ArrayNode<E> prevNode;

    public MyArray() {
        this.data = new ArrayNode<E>(null);
    }

    public void add(E element) {
        if (this.data.value == null) {
            this.data.value = element;
            this.prevNode = this.data;
        } else {
            var newArrayNode = new ArrayNode<E>(element);
            this.prevNode.nextAddress = newArrayNode;
            this.prevNode = newArrayNode;
        }
    }

    public E removeLast() {
        E last = null;
        ArrayNode<E> nodes = this.data;
        while (true){
            var currentNode = nodes;
            if (currentNode.nextAddress == null) {
                last = currentNode.value;
                currentNode = null;
                break;
            }
            nodes = nodes.nextAddress;
        }

        return last;
    }

    public void printConsole() {
        while (true) {
            ArrayNode<E> node = this.data;
            if (node.nextAddress == null) {
                break;
            }
            System.out.println(node.value);
            this.data = this.data.nextAddress;
        }
    }
}