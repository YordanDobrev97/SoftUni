package model;

import java.util.Objects;

public class HardwareOrder implements Order {
    private int id;
    private String description;

    public HardwareOrder(int id, String description) {
        this.id = id;
        this.description = description;
    }

    @Override
    public int getId() {
        return this.id;
    }

    @Override
    public void setId(int id) {
        this.id = id;
    }

    @Override
    public String getDescription() {
        return this.description;
    }

    @Override
    public void setDescription(String description) {
        this.description = description;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        HardwareOrder that = (HardwareOrder) o;
        return id == that.id &&
                Objects.equals(description, that.description);
    }

    @Override
    public int hashCode() {
        return Objects.hash(id, description);
    }

    @Override
    public int compareTo(Order other) {
        return Integer.compare(this.id, other.getId());
    }
}
