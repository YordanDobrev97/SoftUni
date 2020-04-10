import org.junit.Test;

import java.util.List;
import java.util.ArrayList;
import static org.junit.Assert.*;

public class BinarySearchTreeTest {
    @Test
    public void insertRootToBinarySearchTree() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        assertEquals(Integer.valueOf(5), tree.getRoot().getValue());
    }

    @Test
    public void testEachInOrder() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(2);
        tree.insert(3);
        List<Integer> list = new ArrayList<>();
        tree.eachInOrder(list::add);

        assertEquals(Integer.valueOf(2), list.get(0));
        assertEquals(Integer.valueOf(3), list.get(1));
        assertEquals(Integer.valueOf(5), list.get(2));
    }

    @Test
    public void testContainsElementWithExistElement() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);

        boolean containsRightChild = tree.contains(7);
        assertTrue(containsRightChild);
    }

    @Test
    public void testContainsElementWithNotExistElement() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);

        boolean containsRightChild = tree.contains(15);
        assertFalse(containsRightChild);
    }

    @Test
    public void testSearchElementReturnSubTree() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);
        tree.insert(2);
        tree.insert(4);
        tree.insert(6);
        tree.insert(9);

        BinarySearchTree<Integer> subTree = tree.search(7);
        assertEquals(Integer.valueOf(7), subTree.getRoot().getValue());
        assertEquals(Integer.valueOf(6), subTree.getRoot().getLeft().getValue());
        assertEquals(Integer.valueOf(9), subTree.getRoot().getRight().getValue());
    }

    @Test
    public void testDeleteMinTree() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);
        tree.insert(2);
        tree.insert(4);
        tree.insert(6);
        tree.insert(9);

        tree.deleteMin();
        boolean searchMinElement = tree.contains(2);
        assertFalse(searchMinElement);
    }

    @Test
    public void testDeleteMaxTree() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);
        tree.insert(2);
        tree.insert(4);
        tree.insert(6);
        tree.insert(9);

        tree.deleteMax();
        boolean searchMinElement = tree.contains(9);
        assertFalse(searchMinElement);
    }

    @Test
    public void testRange() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);
        tree.insert(2);
        tree.insert(4);
        tree.insert(6);
        tree.insert(9);

        List<Integer> result = tree.range(2, 5);
        assertEquals(4, result.size());
    }

    @Test
    public void testCountElements() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);
        tree.insert(2);
        tree.insert(4);
        tree.insert(6);
        tree.insert(9);

        int count = tree.count();
        assertEquals(7, count);
    }

    @Test
    public void testCountElementsAfterRemoveElement() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);
        tree.insert(2);
        tree.insert(4);
        tree.insert(6);
        tree.insert(9);

        tree.deleteMax();
        int count = tree.count();
        assertEquals(6, count);
    }

    @Test
    public void testRank() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        tree.insert(5);
        tree.insert(3);
        tree.insert(7);
        tree.insert(2);
        tree.insert(4);
        tree.insert(6);
        tree.insert(9);

        int count = tree.rank(5);
        assertEquals(3, count);
    }

    @Test
    public void testRankWithNullRoot() {
        BinarySearchTree<Integer> tree = new BinarySearchTree<Integer>();
        int count = tree.rank(5);
        assertEquals(0, count);
    }
}
