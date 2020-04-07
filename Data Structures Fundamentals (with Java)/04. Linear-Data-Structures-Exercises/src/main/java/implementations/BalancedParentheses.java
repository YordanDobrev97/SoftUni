package implementations;
import java.util.ArrayDeque;
import interfaces.Solvable;
import java.util.Set;
import java.util.Map;

public class BalancedParentheses implements Solvable {
    private Set<Character> openBrackets = Set.of('{', '(', '[');
    private Map<Character, Character> closingBrackets = Map.ofEntries(
            Map.entry(')', '('),
            Map.entry('}', '{'),
            Map.entry(']', '[')
    );

    private String parentheses;

    public BalancedParentheses(String parentheses) {
        this.parentheses = parentheses;
    }

    @Override
    public Boolean solve() {
        ArrayDeque<Character> stack = new ArrayDeque<>();

        for (int i = 0; i < this.parentheses.length(); i++) {
            char bracket = this.parentheses.charAt(i);
            if (openBrackets.contains(bracket)) {
                stack.push(bracket);
                continue;
            }

            if (closingBrackets.containsKey(bracket)) {
                char topElement = stack.pop();
                if (openBrackets.isEmpty() || !closingBrackets.get(bracket).equals(topElement)) {
                    return false;
                }
            }
        }

        return stack.isEmpty();
    }
}