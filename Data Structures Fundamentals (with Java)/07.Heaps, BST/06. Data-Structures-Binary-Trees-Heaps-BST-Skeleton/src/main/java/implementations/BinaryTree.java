package implementations;

import interfaces.AbstractBinaryTree;

import java.util.ArrayList;
import java.util.List;
import java.util.function.Consumer;

public class BinaryTree<E> implements AbstractBinaryTree<E> {
    private E key;
    private BinaryTree<E> leftChild;
    private BinaryTree<E> rightChild;

    public BinaryTree(E value) {
        this.key = value;
    }

    public BinaryTree(E value, BinaryTree<E> leftChild, BinaryTree<E> rightChild) {
        this.key = value;
        this.leftChild = leftChild;
        this.rightChild = rightChild;
    }

    @Override
    public E getKey() {
        return this.key;
    }

    @Override
    public AbstractBinaryTree<E> getLeft() {
        return this.leftChild;
    }

    @Override
    public AbstractBinaryTree<E> getRight() {
        return this.rightChild;
    }

    @Override
    public void setKey(E key) {
        this.key = key;
    }

    @Override
    public String asIndentedPreOrder(int indent) {
        StringBuilder sb = new StringBuilder();
        String padding = newString(indent) + this.getKey();
        sb.append(padding);

        if (this.getLeft() != null) {
           String result = this.getLeft().asIndentedPreOrder(indent + 2);
            sb.append(System.lineSeparator()).append(result);
        }

        if (this.getRight() != null) {
            String result = this.getRight().asIndentedPreOrder(indent + 2);
            sb.append(System.lineSeparator()).append(result);
        }

        return sb.toString();
    }

    private String newString(int count) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < count; i++) {
            sb.append(" ");
        }

        return sb.toString();
    }

    @Override
    public List<AbstractBinaryTree<E>> preOrder() {
        //root, left, right
        List<AbstractBinaryTree<E>> result = new ArrayList<>();

        result.add(this);

        if (this.getLeft() != null){
           result.addAll(this.getLeft().preOrder());
        }

        if (this.getRight() != null) {
           result.addAll(this.getRight().preOrder());
        }

        return result;
    }

    @Override
    public List<AbstractBinaryTree<E>> inOrder() {
        //left, root, right
        List<AbstractBinaryTree<E>> result = new ArrayList<>();

        if (this.getLeft() != null){
            result.addAll(this.getLeft().inOrder());
        }

        result.add(this);

        if (this.getRight() != null) {
            result.addAll(this.getRight().inOrder());
        }

        return result;
    }

    @Override
    public List<AbstractBinaryTree<E>> postOrder() {
        List<AbstractBinaryTree<E>> result = new ArrayList<>();

        if (this.getLeft() != null){
            result.addAll(this.getLeft().postOrder());
        }

        if (this.getRight() != null) {
            result.addAll(this.getRight().postOrder());
        }

        result.add(this);

        return result;
    }

    @Override
    public void forEachInOrder(Consumer<E> consumer) {
        if (this.getLeft() != null){
            this.getLeft().forEachInOrder(consumer);
        }

        consumer.accept(this.getKey());

        if (this.getRight() != null) {
            this.getRight().forEachInOrder(consumer);
        }
    }
}
