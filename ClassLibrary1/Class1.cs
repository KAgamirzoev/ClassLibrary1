using System;
using System.Collections.Generic;

public class Sneaker
{
    public string Model { get; set; }
    public decimal Price { get; set; }
    public List<int> Sizes { get; set; }

    public Sneaker(string model, decimal price, List<int> sizes)
    {
        Model = model;
        Price = price;
        Sizes = sizes;
    }

    public override string ToString()
    {
        return $"Модель: {Model}, Цена: {Price} руб., Доступные размеры: {string.Join(", ", Sizes)}";
    }
}

public class SneakerLibrary
{
    private Dictionary<string, List<Sneaker>> brandModels;

    public SneakerLibrary()
    {
        brandModels = new Dictionary<string, List<Sneaker>>();

        // Заполняем библиотеку брендами, моделями, ценами и размерами
        brandModels["Nike"] = new List<Sneaker>
        {
            new Sneaker("Air Max", 8999m, new List<int> { 40, 41, 42, 43, 44 }),
            new Sneaker("Air Force 1", 7499m, new List<int> { 39, 40, 41, 42, 43 }),
            new Sneaker("Blazer", 6999m, new List<int> { 38, 39, 40, 41, 42 }),
            new Sneaker("React Infinity", 9999m, new List<int> { 40, 42, 43 }),
            new Sneaker("Zoom Pegasus", 8499m, new List<int> { 41, 42, 44 })
        };

        brandModels["Adidas"] = new List<Sneaker>
        {
            new Sneaker("Ultraboost", 12999m, new List<int> { 40, 41, 42, 43 }),
            new Sneaker("NMD", 9999m, new List<int> { 39, 40, 42, 43, 44 }),
            new Sneaker("Superstar", 7999m, new List<int> { 38, 39, 40, 41 }),
            new Sneaker("Stan Smith", 6999m, new List<int> { 39, 40, 42 }),
            new Sneaker("Yeezy", 19999m, new List<int> { 40, 41, 43 })
        };

        brandModels["Puma"] = new List<Sneaker>
        {
            new Sneaker("RS-X", 7999m, new List<int> { 40, 41, 42, 43 }),
            new Sneaker("Suede Classic", 5999m, new List<int> { 39, 40, 41 }),
            new Sneaker("Cali", 6499m, new List<int> { 38, 39, 40, 41 }),
            new Sneaker("Future Rider", 7499m, new List<int> { 40, 42 }),
            new Sneaker("Mirage", 8999m, new List<int> { 39, 41, 43 })
        };

        brandModels["New Balance"] = new List<Sneaker>
        {
            new Sneaker("574", 8999m, new List<int> { 40, 41, 42 }),
            new Sneaker("997", 10999m, new List<int> { 40, 41, 42, 43 }),
            new Sneaker("990v5", 15999m, new List<int> { 41, 42, 44 }),
            new Sneaker("1080v11", 13999m, new List<int> { 40, 41, 43 }),
            new Sneaker("FuelCell Rebel", 12999m, new List<int> { 39, 41, 44 })
        };

        brandModels["Asics"] = new List<Sneaker>
        {
            new Sneaker("Gel-Kayano", 12999m, new List<int> { 40, 41, 42, 43 }),
            new Sneaker("Gel-Nimbus", 11999m, new List<int> { 39, 40, 42, 44 }),
            new Sneaker("Gel-Quantum", 10999m, new List<int> { 40, 41, 43 }),
            new Sneaker("GT-2000", 9999m, new List<int> { 39, 42, 44 }),
            new Sneaker("Gel-Lyte III", 8999m, new List<int> { 40, 41, 42 })
        };
    }

    public List<Sneaker> GetModelsByBrand(string brand)
    {
        if (brandModels.ContainsKey(brand))
        {
            return brandModels[brand];
        }
        else
        {
            Console.WriteLine("Такого бренда не найдено.");
            return new List<Sneaker>();
        }
    }
}
