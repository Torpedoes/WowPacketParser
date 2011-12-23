using System;

namespace WowPacketParser.Enums
{
    [Flags]
    public enum SplineFlag422 : uint
    {
        None = 0x00000000,
        Forward = 0x00000001,
        Backward = 0x00000002,
        StrafeLeft = 0x00000004,
        Straferight = 0x00000008,
        TurnLeft = 0x00000010,
        TurnRight = 0x00000020,
        PitchUp = 0x00000040,
        PitchDown = 0x00000080,
        Trajectory = 0x00000100,
        Falling = 0x00000200,
        NoSpline = 0x00000400,
        Unknown5 = 0x00000800,
        FinalPoint = 0x00001000,
        FinalTarget = 0x00002000,
        FinalOrientation = 0x00004000,
        Unknown1 = 0x00008000,
        Unknown2 = 0x00010000,
        Unknown3 = 0x00020000,
        AnimationTier = 0x00040000,
        Cyclic = 0x00080000,
        EnterCicle = 0x00100000,
        Unknown4 = 0x00200000,
        Frozen = 0x00400000,
        Transport = 0x00800000,
        ExitVehicle = 0x01000000,
        Unknown7 = 0x02000000,
        Unknown8 = 0x04000000,
        MovingBackwards = 0x08000000,
        UsePathSmoothing = 0x10000000,
        Animation = 0x20000000,
        UncompressedPath = 0x40000000,
        Unknown10 = 0x80000000
    }
}
