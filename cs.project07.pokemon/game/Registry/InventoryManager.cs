﻿using cs.project07.pokemon.game.items;
using cs.project07.pokemon.game.items.list;

namespace cs.project07.pokemon.game.Registry
{
    internal static class InventoryManager
    {
        private static List<Item> _inventory = new()
        {
            new Pokeball(0, 10),
            new Pokeball(1),
            new Pokeball(2),
            new Pokeball(3),
            new Potion(0, 10),
            new Potion(1),
            new Potion(2),
            new Potion(3),
            new Spray(3),
        };

        public static List<Item> Inventory => _inventory;

    }
}