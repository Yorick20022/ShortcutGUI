using SQLite;

namespace ShortcutGUI.models
{
    [Table("Config")]
    public class Config
    {

        [PrimaryKey, AutoIncrement]
        [Column("Id")]
        public int Id { get; set; }

        [Column("MostUsedTreshold")]
        public int MostUsedTreshold { get; set; }
    }
}
