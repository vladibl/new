package org.example;

import java.util.Scanner;

public class Laptop {
    private String name;
    private int price;
    private String processor;
    private String color;
    private int ram;

    public Laptop(String name, int price, String processor, String color, int ram) {
        this.name = name;
        this.price = price;
        this.processor = processor;
        this.color = color;
        this.ram = ram;
    }

    public void printInfo(int userRam, String userColor) {
        if (ram >= userRam && (color.equals(userColor) | userColor == "")){
            System.out.printf("У ноутбука %s цена: %s, процессор: %s, цвет: %s, размер оперативной памяти: %s%n", name, price, processor, color, ram);
            System.out.println("-----------\n");
        }
    }

    @Override
    public String toString() {
        return String.format("У ноутбука %s цена: %s, процессор: %s, цвет: %s, размер оперативной памяти: %s", name, price, processor, color, ram);
    }
}
