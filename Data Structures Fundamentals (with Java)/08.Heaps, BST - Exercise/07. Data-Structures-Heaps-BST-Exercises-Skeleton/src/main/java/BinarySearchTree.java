import solutions.BinaryTree;
import java.util.function.Consumer;
import java.util.List;
import java.util.ArrayList;

public class BinarySearchTree<E extends Comparable<E>> {
    private Node<E> root;
    private boolean isContains;
    private int count;
    private int lessCount;

    public BinarySearchTree() {
    }

    public BinarySearchTree(Node<E> current) {
        this.copy(current);
    }

    private void copy(Node<E> node) {
        if (node != null) {
            this.insert(node.value);
            this.copy(node.leftChild);
            this.copy(node.rightChild);
        }
    }

    public static class Node<E> {
        private E value;
        private Node<E> leftChild;
        private Node<E> rightChild;

		public Node(E value) {
            this.value = value;
        }

        public Node<E> getLeft() {
            return this.leftChild;
        }

        public Node<E> getRight() {
            return this.rightChild;
        }

        public E getValue() {
            return this.value;
        }
    }
	
	public void eachInOrder(Consumer<E> consumer) {
         inOrder(this.root, consumer);
    }

    private void inOrder(Node<E> node, Consumer<E> consumer) {
        if (node == null) {
            return;
        }

        inOrder(node.getLeft(), consumer);
        consumer.accept(node.getValue());
        inOrder(node.getRight(), consumer);
    }

    public Node<E> getRoot() {
        return this.root;
    }

    public void insert(E element) {
        this.count++;
        if (this.root == null) {
            this.root = new Node<>(element);
        } else {
            this.addElement(this.getRoot(), element);
        }
    }

    private void addElement(Node<E> node, E element) {
        if (node.value.compareTo(element) > 0) {
            if (node.leftChild == null) {
                Node<E> leftNode = new Node<>(element);
                node.leftChild = leftNode;
            } else {
                addElement(node.leftChild, element);
            }
        } else {
            if (node.rightChild == null) {
                Node<E> right = new Node<>(element);
                node.rightChild = right;
            } else {
                addElement(node.rightChild, element);
            }
        }
    }

    public boolean contains(E element) {
        containsElement(this.root, element, isContains);
        return isContains;
    }

    private void containsElement(Node<E> root, E element, boolean isContains) {
        if (root == null){
            return;
        }

        if (root.value.compareTo(element) == 0) {
            this.isContains = true;
            return;
        }

        if (element.compareTo(root.value) < 0) {
            containsElement(root.leftChild, element, isContains);
        } else {
            containsElement(root.rightChild, element, isContains);
        }
    }

    public BinarySearchTree<E> search(E element) {
        BinarySearchTree<E> binarySearchTree = new BinarySearchTree<>();

        Node<E> current = this.root;
        while (current != null) {
            if (element.compareTo(current.value) < 0) {
                current = current.leftChild;
            } else if (element.compareTo(current.value) > 0) {
                current = current.rightChild;
            } else {
                return new BinarySearchTree<>(current);
            }
        }

        return binarySearchTree;
    }

    public List<E> range(E lower, E upper) {
      List<E> rangeList = new ArrayList<>();
      Node<E> root = this.root;
      findRangeElements(root, lower, upper, rangeList);

      return rangeList;
    }

    private void findRangeElements(Node<E> node, E lower, E upper, List<E> rangeList) {
        E value = node.getValue();
        boolean less = isLess(value, upper);
        boolean greather = isGreather(value, lower);
        boolean range = isRange(less, greather);

        if (range) {
            rangeList.add(value);
        }

        if (node.getLeft() != null) {
            findRangeElements(node.leftChild, lower, upper, rangeList);
        }

        if (node.getRight() != null) {
            findRangeElements(node.rightChild, lower, upper, rangeList);
        }
    }

    private boolean isRange(boolean less, boolean greather) {
        return less && greather;
    }

    private boolean isGreather(E value, E lower) {
        return value.compareTo(lower) >= 0;
    }

    private boolean isLess(E value, E upper) {
        return value.compareTo(upper) <= 0;
    }

    public void deleteMin() {
        if (this.root == null) {
            throw new IllegalArgumentException("Tree is empty");
        }
        Node<E> currentNode = this.root;
        Node<E> parent = this.root;
        this.count--;

        while (currentNode != null) {
            if (currentNode.getLeft() == null) {
                parent.leftChild = null;
                break;
            }

            parent = currentNode;
            currentNode = currentNode.getLeft();
        }
    }

    public void deleteMax() {
        if (this.root == null) {
            throw new IllegalArgumentException("Tree is empty");
        }

        Node<E> currentNode = this.root;
        Node<E> parent = this.root;
        this.count--;
        while (true) {
            if (currentNode.getRight() == null) {
                parent.rightChild = null;
                break;
            }
            parent = currentNode;
            currentNode = currentNode.getRight();
        }
    }

    public int count() {
        return this.count;
    }

    public int rank(E element) {
        Node<E> currentNode = this.root;
        getRank(currentNode, element);
        return lessCount;
    }

    private void getRank(Node<E> currentNode, E element) {
        if (currentNode == null) {
           return;
        }

        E value = currentNode.getValue();
        if (value.compareTo(element) < 0) {
            lessCount++;
        }

        if (currentNode.getLeft() != null) {
            getRank(currentNode.getLeft(), element);
        }

        if (currentNode.getRight() != null) {
            getRank(currentNode.getRight(), element);
        }
    }

    public E ceil(E element) {
        return null;
    }

    public E floor(E element) {
        return null;
    }
}
