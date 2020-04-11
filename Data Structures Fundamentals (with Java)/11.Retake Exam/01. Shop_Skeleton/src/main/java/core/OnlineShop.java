package core;

import model.Order;
import shared.Shop;
import java.util.List;
import java.util.ArrayList;

public class OnlineShop implements Shop {
    private List<Order> data;

    public OnlineShop() {
        this.data = new ArrayList<>();
    }

    @Override
    public void add(Order order) {
        this.data.add(order);
    }

    @Override
    public Order get(int index) {
        if (index < 0 || index > this.data.size() - 1) {
            throw new IndexOutOfBoundsException("Invalid index");
        }
        return this.data.get(index);
    }

    @Override
    public int indexOf(Order order) {
        return this.data.indexOf(order);
    }

    @Override
    public Boolean contains(Order order) {
        return this.data.contains(order);
    }

    @Override
    public Boolean remove(Order order) {
        return this.data.remove(order);
    }

    @Override
    public Boolean remove(int id) {
        Order removedOrder = null;
        for (Order order : data) {
            if (order.getId() == id) {
                removedOrder = order;
                break;
            }
        }
        if (removedOrder != null) {
            this.data.remove(removedOrder);
            return true;
        }
        return false;
    }

    @Override
    public void set(int index, Order order) {
        if (index < 0 || index > this.data.size() - 1) {
            throw new IndexOutOfBoundsException("Invalid index");
        }

        this.data.add(index, order);
    }

    @Override
    public void set(Order oldOrder, Order newOrder) {
        int oldOrderIndex = this.indexOf(oldOrder);

        if (oldOrderIndex == -1) {
            throw new IndexOutOfBoundsException("Invalid order");
        }
        this.data.set(oldOrderIndex, newOrder);
    }

    @Override
    public void clear() {
        this.data.clear();
    }

    @Override
    public Order[] toArray() {
        if (this.data.size() == 0) {
            return new Order[0];
        }
        return (Order[]) new java.util.ArrayList<>(this.data).toArray();
    }

    @Override
    public void swap(Order first, Order second) {
        int indexFirst = this.indexOf(first);
        int indexSecond = this.indexOf(second);

        if (indexFirst == - 1 && indexSecond == -1)  {
            throw new IllegalArgumentException("Not found!");
        }

        java.util.Collections.swap(this.data, indexFirst, indexSecond);
    }

    @Override
    public List<Order> toList() {
        return new ArrayList<>(this.data);
    }

    @Override
    public void reverse() {
        java.util.Collections.reverse(this.data);
    }

    @Override
    public void insert(int index, Order order) {
        if (index < 0 || index > this.data.size()) {
            throw new IndexOutOfBoundsException("Invalid index");
        }
        this.data.set(index, order);
    }

    @Override
    public Boolean isEmpty() {
        return this.data.size() == 0;
    }

    @Override
    public int size() {
        return this.data.size();
    }
}
