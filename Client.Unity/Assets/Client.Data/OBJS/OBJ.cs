﻿using System.IO;
using System.Threading.Tasks;

namespace Client.Data.OBJS
{
    public class OBJ
    {
        public byte Version { get; set; } = 0;
        public int MapNumber { get; set; } = 0;
        public IMapObject[] Objects { get; set; } = new IMapObject[0];
    }
}
