using SQLite;

namespace ShortcutGUI.models
{
    [Table("Shorts")]
    public class Shorts
    {
        [PrimaryKey, AutoIncrement]
        [Column("Id")]
        public int Id { get; set; }

        [Column("ShortCutName")]
        [Unique]
        public string ShortCutName { get; set; }

        [Column("ShortCutText")]
        public string ShortCutText { get; set; }

        [Column("TimesUsed")]
        public int TimesUsed { get; set; }

    }
}
