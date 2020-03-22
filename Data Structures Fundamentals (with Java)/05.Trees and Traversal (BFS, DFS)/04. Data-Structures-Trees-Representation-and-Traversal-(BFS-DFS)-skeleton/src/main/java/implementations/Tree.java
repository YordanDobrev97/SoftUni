package implementations;

import interfaces.AbstractTree;
import java.util.List;
import java.util.*;

public class Tree<E> implements AbstractTree<E> {
    private E element;
    private Tree<E> parent;
    private ArrayList<Tree<E>> children;

    public Tree(E element, Tree<E>... children) {
        this.element = element;
        this.children = new ArrayList<>();

        for (Tree<E> child: children) {
            this.children.add(child);
            child.parent = this;
        }
    }

    @Override
    public List<E> orderBfs() {
        ArrayList<E> data = new ArrayList<E>();
        ArrayDeque<Tree<E>> elements = new ArrayDeque<>();
        elements.push(this);

        while (!elements.isEmpty()) {
            Tree<E> element = elements.poll();
            data.add(element.element);
            for (Tree<E> child: element.children) {
                elements.offer(child);
            }
        }

        return data;
    }

    @Override
    public List<E> orderDfs() {
        ArrayList<E> data = new ArrayList<E>();

        Tree<E> current = this;
        dfs(current, data);

        return data;
    }

    private void dfs(Tree<E> node, ArrayList<E> data) {
        for (Tree<E> child: node.children) {
            this.dfs(child, data);
        }
        data.add(node.element);
    }

    @Override
    public void addChild(E parentKey, Tree<E> child) {
        Tree<E> search = find(this, parentKey);

        if (search == null) {
            throw new IllegalArgumentException("Not found!");
        }

        search.children.add(child);
        child.parent = search;
    }

    private Tree<E> find(Tree<E> node, E parentKey) {
        ArrayDeque<Tree<E>> elements = new ArrayDeque<>();
        elements.push(this);

        while (!elements.isEmpty()) {
            Tree<E> element = elements.poll();

            if (element.element.equals(parentKey)) {
                return element;
            }

            for (Tree<E> child: element.children) {
                elements.offer(child);
            }
        }

        return null;
    }
	
	@Override
    public void removeNode(E nodeKey) {
        if (this.children.size() == 0) {
           this.element = null;
           return;
        }
        Tree<E> foundSearch = find(this, nodeKey);
        if (foundSearch == null) {
            throw new IllegalArgumentException("Not found!");
        }

        for (Tree<E> child : foundSearch.children) {
            child.parent = null;
        }

        foundSearch.children.clear();

        Tree<E> node = foundSearch.parent;
        if (node != null) {
            node.children.remove(foundSearch);
        }
    }

    @Override
    public void swap(E firstKey, E secondKey) {

    }
}