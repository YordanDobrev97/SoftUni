package implementations;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.List;
import java.util.Arrays;
import java.util.Collections;

public class TreeFactory {
    private Map<Integer, Tree<Integer>> nodesByKeys;
    private Tree<Integer> key;
    private boolean noExistInChild = true;

    public TreeFactory() {
        this.nodesByKeys = new LinkedHashMap<>();
    }

    public Tree<Integer> createTreeFromStrings(String[] input) {
        List<String> data = Arrays.asList(input);
        //Collections.reverse(data);

        for (String value : data) {
            String[] items = value.split("\\s+");
            int parent = Integer.parseInt(items[0]);
            int child = Integer.parseInt(items[1]);

            Tree<Integer> treeParent = this.createNodeByKey(parent);
            Tree<Integer> treeChild = this.createNodeByKey(child);

            if (!this.nodesByKeys.containsKey(parent) && noExistInChild) {
                treeParent.addChild(treeChild);
                treeChild.setParent(treeParent);
                this.nodesByKeys.put(parent, treeParent);
                this.key = treeParent;
            } else {
                treeParent.addChild(treeChild);
                treeChild.setParent(treeParent);
            }

        }
        return this.getRoot();
    }

    private Tree<Integer> getRoot() {
        for (Tree<Integer> value : nodesByKeys.values()) {
            if (value.getParent() == null) {
                return value;
            }
        }
        return null;
    }

    public Tree<Integer> createNodeByKey(int key) {

        if (this.nodesByKeys.containsKey(key)) {
            return this.nodesByKeys.get(key);
        }

        Tree<Integer> node = this.checkIsNodeHasChild(key);

        if (node != null) {
            return node;
        }

        return new Tree<>(key);
    }

    private Tree<Integer> checkIsNodeHasChild(int key) {
        if (this.nodesByKeys.size() == 0) {
            return null;
        }

        Tree<Integer> currentNode = null;

        for (Tree<Integer> child : this.key.getChildren()) {
            if (child.getKey() == key) {
                noExistInChild = false;
                currentNode = child;
                break;
            }
        }
        
        return currentNode;
    }

    public void addEdge(int parent, int child) {

    }
}



