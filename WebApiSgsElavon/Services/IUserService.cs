using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.Helpers;
//using WebApiSgsElavon.Model;
using WebApiSgsElavon.ModelsTest;

namespace WebApiSgsElavon.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }

    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User{ Id = 1 , FirstName="Admin" , LastName="User" , UserName = "admin" , Password = "admin", Role = Role.Admin},
            new User{ Id = 2 , FirstName="Normal" , LastName="User" , UserName = "user" , Password = "user", Role = Role.User},
        };

        private readonly AppSettings _appSettings;
        private readonly ELAVONTESTContext _context;

        public UserService(IOptions<AppSettings> appSettings, ELAVONTESTContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var usuario = await _context.CUsuarios.Where(x => x.Username == username).FirstOrDefaultAsync();

            if(usuario == null)
            {
                return null;
            }

            if (!await ValidatePassword(usuario.IdUsuario, password))
            {
                return null;
            }

            User user = new User
            {
                Id = usuario.IdUsuario,
                FirstName = usuario.Nombre,
                LastName = usuario.Paterno + " " + usuario.Materno,
                Role = usuario.IdTipoUsuario == 8 ? Role.User : Role.Admin
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, user.FirstName +" "+ user.LastName),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            user.Password = null;

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _users.Select(x => {
                x.Password = null;
                return x;
            });
        }

        public User GetById(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            if(user != null)
            {
                user.Password = null;
            }

            return user;
        }

        public async Task<bool> ValidatePassword(int idUsuario,string passwordApp)
        {
            SpGetPassword procedure = await _context.Query<SpGetPassword>().FromSql("EXEC SP_GET_PASSWORD @p0", idUsuario).SingleOrDefaultAsync();

            if (!procedure.pw.Equals(passwordApp))
            {
                return false;
            }

            return true;
        }
    }

}
