using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {
        static List<Character> characters = new List<Character>
        {
            new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Hero" },
            new Character { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Hero" },
            new Character{Id = 3, Name = "Bowser", Game = "Super Mario Bros.", Role = "Villan" },
            new Character{Id = 4, Name = "Zelda", Game = "The Legend of Zelda", Role = "Princess" },
        };

        public async Task<List<Character>> GetAllCharactersAsync()
           => await Task.FromResult(characters); // same a comment below
            //{ 
            //    return Ok(characters);
            //}

        public async Task<Character> GetCharacterByIdAsync(int id)
        {
            // checks if the character with the given id exists in the list and returns it, otherwise returns null
            var result = characters.FirstOrDefault(c => c.Id == id);

            return await Task.FromResult(result);
        }

        public async Task<Character> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
