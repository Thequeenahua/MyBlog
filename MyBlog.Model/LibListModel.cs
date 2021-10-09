using System;

using SqlSugar;

namespace MyBlog.Model
{
    [SugarTable("liblist")]
    public class LibListModel
    {
        [SugarColumn(ColumnDataType = "int(28)")]
        public int LST_ID { get; set; }


        [SugarColumn(ColumnDataType = "int(28)")]
        public int LST_SEQ { get; set; }


        [SugarColumn(ColumnDataType = "char(1)")]
        public char LST_TYPE { get; set; }


        [SugarColumn(ColumnDataType = "varchar(17)")]
        public string LST_CREATDTTM { get; set; }


        [SugarColumn(ColumnDataType = "varchar(17)")]
        public string LST_CANCELDTTM { get; set; }


        [SugarColumn(ColumnDataType = "varchar(50)")]
        public string LST_LIBGUID { get; set; }

    }
}
