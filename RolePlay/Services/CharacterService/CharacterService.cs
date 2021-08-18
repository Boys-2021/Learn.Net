using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RolePlay.Data;
using RolePlay.Dtos.Character;
using RolePlay.Models;

namespace RolePlay.Services.CharacterService
{
    public class CharacterService : ICharacterInterface
    {

        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{
                Id = 1,
                Name = "Fernando"
            }
        };

        private readonly IMapper mapper;
        private readonly DatabaseContext _context;

        public CharacterService(IMapper map, DatabaseContext context)
        {
            _context = context;
            mapper = map;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            Character temp = mapper.Map<Character>(newCharacter);
            _context.Characters.Add(temp);
            await _context.SaveChangesAsync();
            var response = new ServiceResponse<List<GetCharacterDto>>();
            var dbCharacters = await _context.Characters.ToListAsync();
            response.Data = dbCharacters.Select(c => mapper.Map<GetCharacterDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
            var response = new ServiceResponse<List<GetCharacterDto>>();
            try
            {
                Character current = await _context.Characters.FirstAsync(c => c.Id == id);
                _context.Characters.Remove(current);
                await _context.SaveChangesAsync();
                response.Data = characters.Select(c => mapper.Map<GetCharacterDto>(c)).ToList();
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var response = new ServiceResponse<List<GetCharacterDto>>();
            var dbCharacters = await _context.Characters.ToListAsync();
            response.Data = dbCharacters.Select(c => mapper.Map<GetCharacterDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var dbCharacter = await _context.Characters.FirstOrDefaultAsync(c=> c.Id==id);
            var response = new ServiceResponse<GetCharacterDto> { Data = mapper.Map<GetCharacterDto>(dbCharacter) };
            return response;
        }

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = new ServiceResponse<GetCharacterDto>();
            try
            {
                Character current = await _context.Characters.FirstOrDefaultAsync(c => c.Id == updatedCharacter.Id);
                current.Name = updatedCharacter.Name;
                current.Charac = updatedCharacter.Charac;

                await _context.SaveChangesAsync();
                response.Data = mapper.Map<GetCharacterDto>(current);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;

        }
    }
}