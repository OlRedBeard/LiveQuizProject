using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    public class QuizInstance
    {
        public int Id { get; set; }
        public string RoomCode { get; set; }
        public string HostIP { get; set; }
        public bool Completed { get; set; }
        public List<User> Contestants { get; set; }

        public static Random random = new Random();

        public QuizInstance()
        {
            this.RoomCode = GetRoomCode();
        }

        public string GetRoomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
