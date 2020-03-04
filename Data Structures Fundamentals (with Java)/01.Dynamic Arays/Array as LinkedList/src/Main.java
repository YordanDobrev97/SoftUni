public class Main {
    public static void main(String[] args) {
       var numbers = new MyArray<Integer>();
       numbers.add(10);
       numbers.add(11);
       numbers.add(12);
       numbers.add(13);
       numbers.add(14);
       int last = numbers.removeLast(); // remove 14
       System.out.println(last);
       numbers.printConsole(); // print -> 10, 11, 12, 13
    }
}