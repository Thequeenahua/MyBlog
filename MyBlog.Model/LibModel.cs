using System;

using SqlSugar;

namespace MyBlog.Model
{
    [SugarTable("baslib")]
    public class LibModel
    {
        [SugarColumn(ColumnDataType = "int(28)")]
        public int BIB_ID { get; set; }


        [SugarColumn(ColumnDataType = "int(28)")]
        public int BIB_AUTID { get; set; }


        [SugarColumn(ColumnDataType = "char(1)")]
        public char BIB_TYPE { get; set; }


        [SugarColumn(ColumnDataType = "varchar(250)")]
        public string BIB_NAME { get; set; }


        [SugarColumn(ColumnDataType = "text")]
        public string BIB_MEMO { get; set; }


        [SugarColumn(ColumnDataType = "varchar(8)")]
        public string BIB_CREATDT { get; set; }

    }
}
