using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace MagicVilla_VillaAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        private string secretKey;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;


        public UserRepository(ApplicationDbContext db, IConfiguration config, UserManager<AppUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            secretKey = config.GetValue<string>("ApiSettings:Secret");
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }
        public bool IsUnique(string username)
        {

            var user = _db.AppUsers.FirstOrDefault(x => x.UserName == username);

            if (user == null) 
            {
                return true;
            }

            return false;
        }

        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            var user = _db.AppUsers.FirstOrDefault(x => x.UserName.ToLower() == loginRequestDto.Username.ToLower()) ;

            bool isValid =  await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);

            if (user == null || isValid == false)
            {
                return new LoginResponseDto()
                {
                    Token = "",
                    User = null
                };
            }


            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var roles = await _userManager.GetRolesAsync(user);  
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault())
                }), 
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token =tokenHandler.CreateToken(tokenDescriptor);

            LoginResponseDto loginResponseDto = new LoginResponseDto()
            {
                Token = tokenHandler.WriteToken(token),
                User = _mapper.Map<UserDto>(user),
                Role = roles.FirstOrDefault(),
            };

            return loginResponseDto;

        }

        public async Task<UserDto> Register(RegistrationRequestDto registrationRequestDto)
        {
            AppUser user = new()
            {
                UserName = registrationRequestDto.Username,
                Email = registrationRequestDto.Username,
                NormalizedEmail = registrationRequestDto.Username.ToUpper(),
                Name = registrationRequestDto.Name,
            };

            try
            {
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);
                if (result.Succeeded) 
                {
                    if (!_roleManager.RoleExistsAsync("admin").GetAwaiter().GetResult()) {
                        await _roleManager.CreateAsync(new IdentityRole("admin"));
                        await _roleManager.CreateAsync(new IdentityRole("admin"));

                    }
                    //await _userManager.AddToRoleAsync(user, "admin");
                    var userReturn = _db.AppUsers.FirstOrDefault(u => u.UserName == registrationRequestDto.Username);
                    return _mapper.Map<UserDto>(userReturn);
                    //return new UserDto()
                    //{
                    //    ID = userReturn.Id,
                    //    UserName = userReturn.UserName,
                    //    Name = userReturn.Name,
                    //};

                }
            }
            catch (Exception)
            {

                throw;
            }

            return new UserDto();
        }
    }
}
