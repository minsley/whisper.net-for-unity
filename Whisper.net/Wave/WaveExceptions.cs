﻿using System;

namespace Whisper.net.Wave
{
    public class CorruptedWaveException : Exception
    {
        public CorruptedWaveException(string? message) : base(message)
        {
        }
    }

    public class NotSupportedWaveException : Exception
    {
        public NotSupportedWaveException(string? message) : base(message)
        {
        }
    }
}
