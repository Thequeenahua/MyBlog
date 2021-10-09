using System;
using System.Collections.Generic;

using SqlSugar;

namespace MyBlog.Model
{
    [SugarTable("libcontent")]
    public class ContentModel
    {
        [SugarColumn(ColumnDataType = "int(28)")]
        public int LNT_ID { get; set; }


        [SugarColumn(ColumnDataType = "int(28)")]
        public int LNT_SEQ { get; set; }


        [SugarColumn(ColumnDataType = "varchar(50)")]
        public string LNT_GUID { get; set; }


        [SugarColumn(ColumnDataType = "text")]
        public string LNT_CONTENT { get; set; }

    }
}
