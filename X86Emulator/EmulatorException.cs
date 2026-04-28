using System;

namespace X86Emulator
{
    internal class EmulatorException : Exception
    {
        public EmulatorException()
        {
        }

        public EmulatorException(string message)
            : base(message)
        {
        }

        public EmulatorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
