using System.Text.RegularExpressions;

namespace ApiUser.Extensions
{
    public static class StringExtensions
    {
        public static string ToPassword(this string str) => BCrypt.Net.BCrypt.HashPassword(str);

        public static bool CheckPassword(this string passwordHash, string passwordToTest) => BCrypt.Net.BCrypt.Verify(passwordToTest, passwordHash);

    }
}
