using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoGameCharacterApi.Data;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Dtos;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
    {
        public async Task<List<CharacterResponse>> GetAllCharactersAsync()
           => await context.Characters.Select(c => new CharacterResponse
           {
               Name = c.Name,
               Game = c.Game, 
               Role = c.Role
           }).ToListAsync();

        public async Task<CharacterResponse> GetCharacterByIdAsync(int id)
        {
            // checks if the character with the given id exists in the list and returns it, otherwise returns null
            var result = await context.Characters
                .Where(c => c.Id == id).Select(c => new CharacterResponse
                {
                    Name = c.Name,
                    Game = c.Game,
                    Role = c.Role
                }).FirstOrDefaultAsync();

            return result;
        }

        public async Task<CharacterResponse> AddCharacterAsync(Character character)
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
