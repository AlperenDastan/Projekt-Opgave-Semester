using Projekt_Opgave.Models;

namespace Projekt_Opgave.MockData
{
    public class MockItems
    {
        private static List<Item> items = new List<Item>() {
        new Item(1, "Håndsav", 5999, "Værktøj", "Sav"),
        new Item(2, "Bygge Træ", 320, "Bygge Materiale", "Byggemateriale"),
        new Item(3, "Brænde", 30, "Brændstof", "Brænde")
       };
        public static List<Item> GetMockItems() { return items; }
    }
}
