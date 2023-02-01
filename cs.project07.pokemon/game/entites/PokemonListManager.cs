﻿namespace cs.project07.pokemon.game.entites
{
    internal static class PokemonListManager
    {
        private static List<Pokemon> _pokemonCaptured;
        private static Pokemon[] _battleTeam;
        public static Pokemon[] BattleTeam { get => _battleTeam; }
        public static List<Pokemon> PokemonCaptured { get => _pokemonCaptured; }

        public static void Init()
        {
            _battleTeam = new Pokemon[6];
            _pokemonCaptured = new List<Pokemon>();
            SetStarter();
        }

        private static void SetStarter()
        {
            _battleTeam[0] = new Pokemon(PokemonRegistry.GetRandomStarter());
            _battleTeam[1] = new Pokemon(PokemonRegistry.GetRandomStarter());
            _battleTeam[2] = new Pokemon(PokemonRegistry.GetPokemonByPokedexId(493));
            _battleTeam[3] = new Pokemon(PokemonRegistry.GetRandomStarter());
            _battleTeam[4] = new Pokemon(PokemonRegistry.GetRandomStarter());
            _battleTeam[5] = new Pokemon(PokemonRegistry.GetRandomStarter());
        }

        public static void AddPokemon(Pokemon pokemon)
        {
            _pokemonCaptured.Add(pokemon);
            SetPokemonInBattleTeam(pokemon);
        }

        public static int GetAverageLevel()
        {
            float avgLevel = 0;
            int pokemonInTeam = 0;

            foreach (var pokemon in BattleTeam)
            {
                if (pokemon != null)
                {
                    pokemonInTeam++;
                    avgLevel += pokemon.Level;
                }
            }
            avgLevel /= pokemonInTeam;

            return (int)avgLevel;
        }

        public static bool IsAllPokemonDead()
        {
            foreach (var pokemon in BattleTeam)
            {
                if (!pokemon.IsDead)
                {
                    return false;
                }
            }

            return true;
        }

        public static void SetPokemonInBattleTeam(Pokemon pokemonToAdd)
        {
            if (_battleTeam.Last() != null) return;
            
            for (int i = 0; i < _battleTeam.Length; i++)
            {
                if (_battleTeam[i] == null)
                {
                    _battleTeam[i] = pokemonToAdd;
                    break;
                }
            }
        }
    }
}
