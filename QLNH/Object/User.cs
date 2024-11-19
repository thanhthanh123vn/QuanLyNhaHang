using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Object
{
    using System;

    public class User
    {
        public int UserID { get; set; } // Tự động tăng
        public string FullName { get; set; } // Không cho phép null
        public string Email { get; set; } // Không cho phép null, duy nhất
        public string PasswordHash { get; set; } // Không cho phép null
        public string PhoneNumber { get; set; } // Có thể null
        public string Address { get; set; } // Có thể null
        public string Role { get; set; } // Giá trị mặc định 'Phuc Vu'
        public DateTime CreatedAt { get; set; } // Giá trị mặc định là thời gian hiện tại

        // Constructor mặc định
        public User() { }
        public User(string fullName, string role)
        {
            
            FullName = fullName;
         
            Role = role;
         
        }
        // Constructor đầy đủ
        public User(int userId, string fullName, string email, string passwordHash, string phoneNumber, string address, string role, DateTime createdAt)
        {
            UserID = userId;
            FullName = fullName;
            Email = email;
            PasswordHash = passwordHash;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
            CreatedAt = createdAt;
        }

        // Phương thức override ToString để hiển thị thông tin
        public override string ToString()
        {
            return $"UserID: {UserID}, FullName: {FullName}, Email: {Email}, Role: {Role}, CreatedAt: {CreatedAt}";
        }
    }

}
