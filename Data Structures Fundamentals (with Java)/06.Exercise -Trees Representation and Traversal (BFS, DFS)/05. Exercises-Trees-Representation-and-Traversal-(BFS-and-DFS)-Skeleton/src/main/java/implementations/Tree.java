package implementations;
import java.util.ArrayDeque;
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

    public E getValue(){
        return this.value;
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
        do {
            for (Tree<E> child : currentChildren) {
                if (child.children.size() == 0) {
                    deepestNode = child;
                    isFound = true;
                    break;
                }
                currentChildren = child.children;
                break;
            }

        } while (!isFound);
        return deepestNode;
    }

    @Override
    public List<E> getLongestPath() {
        Tree<E> leftNode = this.getDeepestLeftmostNode();
        ArrayDeque<E> longestPath = new ArrayDeque<>();

        while (true) {
            E currentNode = leftNode.value;
            longestPath.push(currentNode);
            Tree<E> upNode = leftNode.parent;
            leftNode = upNode;

            if (upNode.parent == null) {
                longestPath.push(upNode.value); // root element
                break;
            }
        }

        return new ArrayList<>(longestPath);
    }

    private void longestPathNodes(Tree<E> node, List<Tree<E>> nodes) {
        nodes.add(node);

        for (Tree<E> tree : node.children) {
            if (nodes.size() < tree.getChildren().size()) {
                longestPathNodes(tree, nodes);
            }
        }
    }

    @Override
    public List<List<E>> pathsWithGivenSum(int sum) {
        List<E> sums = new ArrayList<>();
        List<List<E>> resultList = new ArrayList<>();
        sums.add(this.value);
        getSums(this.children, sums, sum, resultList);

        return resultList;
    }

    private void getSums(List<Tree<E>> children, List<E> sums, int sum, List<List<E>> resultList) {
        for (Tree<E> child : children) {
            sums.add(child.value);

            int currentSum = SumListGeneric.getSum((java.util.List<Integer>) sums);
            if (currentSum == sum) {
                ArrayList<E> cloneSum = new ArrayList<E>(sums);
                resultList.add(cloneSum);
                removeAllWithoutFirst(sums);
                return;
            }

            if (currentSum > sum) {
                sums.remove(child.value);
            }
            getSums(child.children, sums, sum, resultList);
        }
    }

    private void removeAllWithoutFirst(List<E> sums) {
        while (sums.size() > 1) {
            sums.remove(1);
        }
    }

    @Override
    public List<Tree<E>> subTreesWithGivenSum(int sum) {
        return null;
    }

    public List<Tree<E>> getChildren() {
        return this.children;
    }
}



