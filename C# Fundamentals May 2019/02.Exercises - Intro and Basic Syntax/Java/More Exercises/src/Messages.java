import java.util.Scanner;
public class Messages {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int count = Integer.parseInt(scanner.nextLine());
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < count; i++) {
            String message = scanner.nextLine();
            char firstDigit = message.charAt(0);
            int lengthMessage = message.length();
            switch (firstDigit) {
                case '0':
                    result.append(" ");
                    break;
                case '2':
                    if (lengthMessage == 1) {
                        result.append("a");
                    } else if (lengthMessage == 2) {
                        result.append("b");
                    } else if (lengthMessage == 3) {
                        result.append("c");
                    }
                    break;
                case '3':
                    if (lengthMessage == 1) {
                        result.append("d");
                    } else if (lengthMessage == 2) {
                        result.append("e");
                    } else if (lengthMessage == 3) {
                        result.append("f");
                    }
                    break;
                case '4':
                    if (lengthMessage == 1) {
                        result.append("g");
                    } else if (lengthMessage == 2) {
                        result.append("h");
                    } else if (lengthMessage == 3) {
                        result.append("i");
                    }
                    break;
                case '5':
                    if (lengthMessage == 1) {
                        result.append("j");
                    } else if (lengthMessage == 2) {
                        result.append("k");
                    } else if (lengthMessage == 3) {
                        result.append("l");
                    }
                    break;
                case '6':
                    if (lengthMessage == 1) {
                        result.append("m");
                    } else if (lengthMessage == 2) {
                        result.append("n");
                    } else if (lengthMessage == 3) {
                        result.append("o");
                    }
                    break;
                case '7':
                    if (lengthMessage == 1) {
                       result.append("p");
                    } else if (lengthMessage == 2) {
                        result.append("q");
                    } else if (lengthMessage == 3) {
                        result.append("r");
                    } else if (lengthMessage == 4) {
                        result.append("s");
                    }
                    break;
                case '8':
                    if (lengthMessage == 1) {
                        result.append("t");
                    } else if (lengthMessage == 2) {
                        result.append("u");
                    } else if (lengthMessage == 3) {
                        result.append("v");
                    }
                    break;
                case '9':
                    if (lengthMessage == 1) {
                        result.append("w");
                    } else if (lengthMessage == 2) {
                        result.append("x");
                    } else if (lengthMessage == 3) {
                        result.append("y");
                    } else if (lengthMessage == 4) {
                        result.append("z");
                    }
                    break;
            }
        }

        System.out.println(result.toString());
    }
}
