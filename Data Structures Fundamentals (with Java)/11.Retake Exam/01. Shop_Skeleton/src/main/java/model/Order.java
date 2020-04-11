package model;

public interface Order extends Comparable<Order> {
    int getId();
    void setId(int id);
    String getDescription();
    void setDescription(String description);
}
