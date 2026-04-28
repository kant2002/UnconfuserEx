using SharpDisasm;
using System.Collections.Generic;

namespace X86Emulator.Instructions
{
    internal class Pop : Instruction
    {
        private Operand? Operand = null;

        public Pop(Operand? operand)
        {
            Operand = operand;
        }

        public override void Emulate(Stack<int> stack, Registers registers)
        {
            int val = stack.Pop();

            if (Operand != null)
            {
                registers.SetValue(Operand.Base, val);
            }
        }
    }
}
