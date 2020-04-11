package model;

import java.util.ArrayList;
import java.util.Objects;
import java.util.List;

public class SampleFile implements File {
    private int number;
    private String name;
    private List<File> children;

    public SampleFile(int number, String name) {
        this.number = number;
        this.name = name;
        this.children = new ArrayList<>();
    }


    @Override
    public int getNumber() {
        return this.number;
    }

    @Override
    public void setNumber(int number) {
        this.number = number;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public void setName(String name) {
        this.name = name;
    }

    @Override
    public List<File> getChildren() {
        return this.children;
    }

    @Override
    public void setGetChildren(List<File> children) {
        this.children = children;
    }

    @Override
    public int compareTo(File other) {
        return Integer.compare(this.number, other.getNumber());
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        SampleFile myFile = (SampleFile) o;
        return number == myFile.number &&
                Objects.equals(name, myFile.name);
    }

    @Override
    public int hashCode() {
        return Objects.hash(number, name);
    }
}
