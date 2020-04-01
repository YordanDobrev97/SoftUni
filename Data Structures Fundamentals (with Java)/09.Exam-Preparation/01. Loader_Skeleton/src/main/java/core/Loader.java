package core;

import interfaces.Buffer;
import interfaces.Entity;
import model.BaseEntity;

import java.util.Iterator;
import java.util.List;
import java.util.ArrayList;
import java.util.function.Predicate;
import java.util.stream.Collectors;
public class Loader implements Buffer {
    private List<Entity> entities;

    public Loader() {
        this.entities = new ArrayList<>();
    }

    @Override
    public void add(Entity entity) {
        this.entities.add(entity);
    }

    @Override
    public Entity extract(int id) {
        Entity foundEntity = null;

        for (Entity entity : entities) {
            if (entity.getId() == id) {
                foundEntity = entity;
                break;
            }
        }

        if (foundEntity != null) {
            this.entities.remove(foundEntity);
        }

        return foundEntity;
    }

    @Override
    public Entity find(Entity entity) {
        for (Entity currentEntity : entities) {
            if (currentEntity.getId() == entity.getId()) {
               return currentEntity;
            }
        }
        return null;
    }

    @Override
    public boolean contains(Entity entity) {
        return this.entities.contains(entity);
    }

    @Override
    public int entitiesCount() {
        return this.entities.size();
    }

    @Override
    public void replace(Entity oldEntity, Entity newEntity) {
        if (!this.contains(oldEntity)) {
            throw new IllegalStateException("Entity not found");
        }
        Entity entity = this.find(oldEntity);
        this.entities.set(oldEntity.getId(), newEntity);
    }

    @Override
    public void swap(Entity first, Entity second) {
        if (!this.contains(first) || !this.contains(second)) {
            throw new IllegalStateException("Entities not found");
        }
        Entity temp = first;
        first = second;
        second = temp;
    }

    @Override
    public void clear() {
        this.entities.clear();
    }

    @Override
    public Entity[] toArray() {
        Entity[] array = new Entity[this.entities.size()];
        array = this.entities.toArray(array);
        return array;
    }

    @Override
    public List<Entity> retainAllFromTo(BaseEntity.Status lowerBound, BaseEntity.Status upperBound) {
        List<Entity> result = new ArrayList<>();

        for (Entity entity : entities) {
            if (entity.getStatus().ordinal() >= lowerBound.ordinal() && entity.getStatus().ordinal() <= upperBound.ordinal()) {
                result.add(entity);
            }
        }

        return result;
    }

    @Override
    public List<Entity> getAll() {
        return this.entities;
    }

    @Override
    public void updateAll(BaseEntity.Status oldStatus, BaseEntity.Status newStatus) {
        for (Entity entity : entities) {
            if (entity.getStatus() == oldStatus){
                entity.setStatus(newStatus);
            }
        }
    }

    @Override
    public void removeSold() {
        Predicate<Entity> byStatus = e -> !e.getStatus().equals("SOLD");
        this.entities = this.entities.stream().filter(byStatus).collect(Collectors.toList());
    }

    @Override
    public Iterator<Entity> iterator() {
        return new ListIterator();
    }

    private final class ListIterator implements Iterator<Entity> {
        private int counter;

        public ListIterator() {
            this.counter = 0;
        }

        @Override
        public boolean hasNext() {
            return this.counter <= entitiesCount() - 1;
        }

        @Override
        public Entity next() {
            return entities.get(this.counter++);
        }
    }
}
