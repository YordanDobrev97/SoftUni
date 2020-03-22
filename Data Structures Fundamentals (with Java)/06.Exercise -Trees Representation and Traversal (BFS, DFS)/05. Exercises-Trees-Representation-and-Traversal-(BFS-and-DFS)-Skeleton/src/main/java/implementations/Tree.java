package implementations;

import interfaces.AbstractTree;
import java.util.List;
import java.util.ArrayList;

public class Tree<E> implements AbstractTree<E> {
    private E value;
    private Tree<E> parent;
    private List<Tree<E>> children;

    public Tree(E value, Tree<E>... children) {
        this.value = value;
        this.children = new ArrayList<>();
        java.util.Collections.addAll(this.children, children);
    }

    @Override
    public void setParent(Tree<E> parent) {
        this.parent = parent;
    }

    @Override
    public void addChild(Tree<E> child) {
        this.children.add(child);
    }

    @Override
    public Tree<E> getParent() {
        return this.parent;
    }

    @Override
    public E getKey() {
        return this.value;
    }

    @Override
    public String getAsString() {
        StringBuilder fullTree = new StringBuilder();

        int initialSpaces = 2;
        fullTree.append(this.value);
        fullTree.append(System.lineSeparator());

        fillTree(this.children, fullTree, initialSpaces);

        return fullTree.toString().trim();
    }

    private StringBuilder fillTree(List<Tree<E>> children, StringBuilder fullTree, int spaces) {
        for (Tree<E> child : children) {
            String space = this.newString(" ", spaces);
            fullTree.append(space);
            fullTree.append(child.value);
            fullTree.append(System.lineSeparator());
            fillTree(child.children, fullTree, spaces + 2);
        }

        return fullTree;
    }

    private String newString(String string, int count) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; i++) {
            result.append(string);
        }
        return result.toString();
    }

    @Override
    public List<E> getLeafKeys() {
        List<E> leafs = new ArrayList<>();
        getLeafs(this.children, leafs);
        return leafs;
    }

    private void getLeafs(List<Tree<E>> children, List<E> leafs) {
        for (Tree<E> child : children) {
            if (child.children.size() == 0){
                leafs.add(child.value);
            }
            getLeafs(child.children, leafs);
        }
    }

    @Override
    public List<E> getMiddleKeys() {
        List<E> middleKeys = new ArrayList<>();

        this.getMiddleNodes(this.children, middleKeys);

        return middleKeys;
    }

    private void getMiddleNodes(List<Tree<E>> children, List<E> middleKeys) {
        for (Tree<E> child : children) {
            if (child.getChildren().size() > 0) {
                middleKeys.add(child.value);
            }
            getMiddleNodes(child.children, middleKeys);
        }
    }

    @Override
    public Tree<E> getDeepestLeftmostNode() {

        Tree<E> deepestNode = null;

        List<Tree<E>> currentChildren = this.children;
        boolean isFound = false;
        while (true) {
            for (Tree<E> child : currentChildren) {
                if (child.children.size() == 0) {
                    deepestNode = child;
                    isFound = true;
                    break;
                }
                currentChildren = child.children;
                break;
            }

            if (isFound) {
                break;
            }
        }
        return deepestNode;
    }



    @Override
    public List<E> getLongestPath() {
        return null;
    }

    @Override
    public List<List<E>> pathsWithGivenSum(int sum) {
        return null;
    }

    @Override
    public List<Tree<E>> subTreesWithGivenSum(int sum) {
        return null;
    }

    public List<Tree<E>> getChildren() {
        return this.children;
    }
}



