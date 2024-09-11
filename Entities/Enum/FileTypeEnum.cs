using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
    public enum FileTypeEnum : byte
    {

        None = 0,
        Entities = 1
    }


    public static class
    FileType
    {

        public static readonly Dictionary<FileTypeEnum, string> FileTypes = new Dictionary<FileTypeEnum, string>()
        {

            [FileTypeEnum.None] = "",
            [FileTypeEnum.Entities] = "Entities",

        };

    }


}
