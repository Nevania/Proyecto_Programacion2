

using SQLite;

namespace Proyecto_Programacion2.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public String Name { get; set; }

        public String Notes { get; set; }

        public bool Done { get; set; }
    }
}
