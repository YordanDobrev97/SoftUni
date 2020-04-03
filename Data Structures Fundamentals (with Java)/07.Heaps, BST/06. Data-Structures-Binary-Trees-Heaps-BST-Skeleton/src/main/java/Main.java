import implementations.*;
public class Main {
    public static void main(String[] args) {
        BinaryTree<Integer> tree = new BinaryTree<>(10,
                new BinaryTree(3,
                        new BinaryTree<>(2),
                        new BinaryTree<>(1)),
                new BinaryTree(4));

        String result = tree.asIndentedPreOrder(0);
        System.out.println(result);

        /*
               10
            3     4
         2    1
         */
        /*
         10
           3
             2
             1
           4
         */
    }
}
