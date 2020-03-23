import implementations.*;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        String[] input = {
                "7 19",
                "7 21",
                "7 14",
                "19 1",
                "19 12",
                "19 31",
                "14 23",
                "14 6"
        };

        TreeFactory factory = new TreeFactory();
        Tree<Integer> result = factory.createTreeFromStrings(input);
        List<Integer> tree = result.getLongestPath();
        System.out.println(tree);
    }
}
