using System;

using SqlSugar;

namespace MyBlog.Model
{
    [SugarTable("basaut")]
    public class UserModel
    {
        [SugarColumn(ColumnDataType = "int(28)")]
        public int BUT_ID { get; set; }


        [SugarColumn(ColumnDataType = "varchar(50)")]
        public string BUT_PWD { get; set; }


        [SugarColumn(ColumnDataType = "varchar(50)")]
        public string BUT_NAME { get; set; }


        [SugarColumn(ColumnDataType = "text")]
        public string BUT_MEMO { get; set; }


        [SugarColumn(ColumnDataType = "char(1)")]
        public char BUT_SEX { get; set; }


        [SugarColumn(ColumnDataType = "varchar(8)")]
        public string BUT_BIRTHDAY { get; set; }


        [SugarColumn(ColumnDataType = "char(1)")]
        public char BUT_TYPE { get; set; }

    }
}
