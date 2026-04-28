using SharpDisasm;
using System.Collections.Generic;

namespace X86Emulator.Instructions
{
    internal class Neg : Instruction
    {
        private Operand Operand;

        public Neg(Operand operand)
        {
            Operand = operand;
        }

        public override void Emulate(Stack<int> stack, Registers registers)
        {
            int val = registers.GetValue(Operand.Base);

            val = -val;

            registers.SetValue(Operand.Base, val);
        }
    }
}
