import implementations.*;

public class Main {
    public static void main(String[] args) {
        BalancedParentheses parentheses = new BalancedParentheses("");
        boolean result = parentheses.solve();
        System.out.println(result);
    }
}
