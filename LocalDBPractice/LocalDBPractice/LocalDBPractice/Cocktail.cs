using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDBPractice
{
    class CockTail
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string name { get; set; }
        [MaxLength(10)]
        public string desc { get; set; }

        public string tags { get; set; }

        public string imagePath { get; set; }
    }
}
