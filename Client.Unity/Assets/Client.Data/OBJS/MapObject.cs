﻿using UnityEngine;
using System.Runtime.InteropServices;

namespace Client.Data.OBJS
{
    public interface IMapObject
    {
        short Type { get; }
        Vector3 Position { get; }
        Vector3 Angle { get; }
        float Scale { get; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MapObjectV0 : IMapObject
    {
        public short Type { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Angle { get; set; }
        public float Scale { get; set; }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MapObjectV1 : IMapObject
    {
        public short Type { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Angle { get; set; }
        public float Scale { get; set; }

        public byte UnknownX { get; set; }
        public byte UnknownY { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MapObjectV2 : IMapObject
    {
        public short Type { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Angle { get; set; }
        public float Scale { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MapObjectV3 : IMapObject
    {
        public short Type { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Angle { get; set; }
        public float Scale { get; set; }

        public byte UnknownX { get; set; }
        public byte UnknownY { get; set; }
        public byte UnknownZ { get; set; }

        public Vector3 Ligthning { get; set; }
    }
}
