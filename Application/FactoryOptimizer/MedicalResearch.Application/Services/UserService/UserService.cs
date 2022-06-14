using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Users;
using MedicalResearch.Domain.Users;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.UserService
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public async Task<int> Create(RegisterDto dto)
        {
            var password = HashPassword(dto.Password);
            var user = await _userRepository.Get(dto.Email, password);
            if(user != null)
            {
                throw new Exception("Даний користувач існує.");
            }

            if(await _userRepository.ExistEmail(dto.Email))
            {
                throw new Exception($"Користувач з email = {dto.Email} існує.");
            }

            var newUser = new User
            {
                Email = dto.Email,
                Password = password,
                CanChange = false
            };

            await _userRepository.Create(newUser);
            await _userRepository.SaveChanges();

            return newUser.Id;
        }

        public async Task<UserDto> Get(int id)
        {
            return await _userRepository.GetUser(id);
        }

        public async Task<IList<UserDto>> GetList()
        {
            return await _userRepository.GetList();
        }

        public async Task<string> LogIn(LogInDto dto)
        {
            dto.Password = HashPassword(dto.Password);
            var user = await _userRepository.LogIn(dto);
            if(user == null)
            {
                throw new ArgumentNullException("Даний користувач не зареєстрований у системі, або ж не має доступу до змін.");
            }
            else
            {
                return user.Email;
            }
        }

        public async Task Update(int id, bool canChange)
        {
            var user = await _userRepository.GetById(id);
            if (user == null)
                throw new ArgumentNullException("User with id not exist");

            user.CanChange = canChange;
            await _userRepository.SaveChanges();
        }

        private string HashPassword(string password)
        {
            var salt = 1540332987;

            byte[] saltBytes = new byte[4];
            saltBytes[0] = (byte)(salt >> 24);
            saltBytes[1] = (byte)(salt >> 16);
            saltBytes[2] = (byte)(salt >> 8);
            saltBytes[3] = (byte)(salt);

            byte[] passwordBytes = UTF8Encoding.UTF8.GetBytes(password);

            byte[] preHashed = new byte[saltBytes.Length + passwordBytes.Length];
            System.Buffer.BlockCopy(passwordBytes, 0, preHashed, 0, passwordBytes.Length);
            System.Buffer.BlockCopy(saltBytes, 0, preHashed, passwordBytes.Length, saltBytes.Length);

            SHA1 sha1 = SHA1.Create();
            return Convert.ToBase64String(sha1.ComputeHash(preHashed));

        }
    }
}
