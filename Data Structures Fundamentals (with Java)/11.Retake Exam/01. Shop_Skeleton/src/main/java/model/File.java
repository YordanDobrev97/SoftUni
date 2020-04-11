package model;

import java.util.List;

public interface File extends Comparable<File> {
    int getNumber();
    void setNumber(int number);
    String getName();
    void setName(String name);
    List<File> getChildren();
    void setGetChildren(List<File> children);
}
