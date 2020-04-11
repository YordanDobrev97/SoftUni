package shared;

import model.Order;

import java.util.List;

public interface Shop {
    void add(Order order);
    Order get(int index);
    int indexOf(Order order);
    Boolean contains(Order order);
    Boolean remove(Order order);
    Boolean remove(int id);
    void set(int index, Order order);
    void set(Order oldOrder, Order newOrder);
    void clear();
    Order[] toArray();
    void swap(Order first, Order second);
    List<Order> toList();
    void reverse();
    void insert(int index, Order order);
    Boolean isEmpty();
    int size();
}
