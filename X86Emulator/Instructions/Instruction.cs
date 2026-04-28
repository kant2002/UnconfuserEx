using System.Collections.Generic;

namespace X86Emulator.Instructions;

internal abstract class Instruction
{
    public abstract void Emulate(Stack<int> stack, Registers registers);
}
