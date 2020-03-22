import implementations.Tree;
import java.util.List;
public class Main {
    public static void main(String[] args) {
        Tree<Integer> tree = new Tree<>(7,
                    new Tree<>(19,
                            new Tree<>(1),
                            new Tree<>(12),
                            new Tree<>(31)),
                new Tree<>(21),
                new Tree<>(14,
                        new Tree<>(23),
                        new Tree<>(6)));

        tree.removeNode(19);
        tree.removeNode(21);
        tree.removeNode(14);
        tree.removeNode(7);
    }
}
