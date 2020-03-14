package implementations;
import java.util.ArrayDeque;
import interfaces.Solvable;

public class BalancedParentheses implements Solvable {
    private String parentheses;
    private ArrayDeque<String> stack;

    public BalancedParentheses(String parentheses) {
        this.parentheses = parentheses;
        this.stack = new ArrayDeque<>();
    }

    @Override
    public Boolean solve() {
        boolean isBalanced = true;

        int length = parentheses.length();
        for (int i = 0; i < length; i++) {
            char symbol = parentheses.charAt(i);

            if (symbol == '{' || symbol == '[' || symbol == '(') {
                stack.push("" + symbol);
            } else if (symbol == '}' || symbol == ']' || symbol == ')') {
                String last = stack.pop();

                if (symbol == '}' && !last.equals("{")) {
                    isBalanced = false;
                    break;
                } else if (symbol == ']' && !last.equals("[")) {
                    isBalanced = false;
                    break;
                } else if (symbol == ')' && !last.equals("(")) {
                    isBalanced = false;
                    break;
                }
            }
        }

        if (!this.stack.isEmpty() || this.parentheses.length() == 0) {
            isBalanced = false;
        }
        return isBalanced;
    }
}