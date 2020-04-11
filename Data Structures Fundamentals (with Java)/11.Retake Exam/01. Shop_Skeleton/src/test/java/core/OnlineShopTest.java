package core;

import model.HardwareOrder;
import model.Order;
import org.junit.Test;
import shared.Shop;
import java.util.List;

import static org.junit.Assert.*;

public class OnlineShopTest {

    @Test
    public void testContainsShouldReturnTrue() {
        Shop shop = new OnlineShop();
        for (int i = 0; i < 20; i++) {
            shop.add(new HardwareOrder(i, "hardware_order"));
        }
        Boolean isPresent = shop.contains(new HardwareOrder(13, "hardware_order"));
        assertNotNull(isPresent);
        assertTrue(isPresent);
    }

    @Test
    public void testIndexOfShouldReturnCorrectValue() {
        Shop shop = new OnlineShop();
        for (int i = 0; i < 20; i++) {
            shop.add(new HardwareOrder(i, "hardware_order"));
        }
        int index = shop.indexOf(new HardwareOrder(13, "hardware_order"));
        assertEquals(13, index);
    }

    @Test(expected = IndexOutOfBoundsException.class)
    public void testGetByIndexShouldThrow() {
        Shop shop = new OnlineShop();
        for (int i = 0; i < 20; i++) {
            shop.add(new HardwareOrder(i, "hardware_order"));
        }
        shop.get(20);
    }

    @Test
    public void testGetByIndex() {
        Shop shop = new OnlineShop();
        for (int i = 0; i < 20; i++) {
            shop.add(new HardwareOrder(i, "hardware_order"));
        }
        Order order = shop.get(10);
        assertNotNull(order);
        assertEquals(10, order.getId());
    }

    @Test
    public void testAddMultipleElements() {
        Shop shop = new OnlineShop();
        assertEquals(0, shop.size());

        for (int i = 0; i < 100; i++) {
            shop.add(new HardwareOrder(i, "hardware_order"));
        }

        assertEquals(100, shop.size());
    }

    @Test
    public void testToArrayReturnEmptyArray() {
        Shop shop = new OnlineShop();

        Object[] arr = shop.toArray();

        assertEquals(0, arr.length);
    }

    @Test
    public void testToListReturnEmptyList() {
        Shop shop = new OnlineShop();

        List<Order> arr = shop.toList();

        assertEquals(0, arr.size());
    }

    @Test
    public void testReverse() {
        Shop shop = new OnlineShop();

        shop.add(new model.HardwareOrder(1, "1"));
        shop.add(new model.HardwareOrder(2, "1"));
        shop.add(new model.HardwareOrder(3, "1"));

        shop.reverse();

        assertEquals(3, shop.get(0).getId());
    }


    @Test
    public void testRemoveById() {
        Shop shop = new OnlineShop();

        Order order = new HardwareOrder(13, "hardware_order");
        shop.add(order);

        shop.remove(13);
        assertEquals(0, shop.size());
    }
}