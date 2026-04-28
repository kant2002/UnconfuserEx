using SharpDisasm;
using System.Collections.Generic;

namespace X86Emulator.Instructions
{
    internal class Push : Instruction
    {
        private Operand Operand;

        public Push(Operand operand)
        {
            Operand = operand;
        }

        public override void Emulate(Stack<int> stack, Registers registers)
        {
            int val;
            if (Operand.Type == SharpDisasm.Udis86.ud_type.UD_OP_REG)
            {
                val = registers.GetValue(Operand.Base);
            }
            else
            {
                val = Operand.LvalSDWord;
            }

            stack.Push(val);
        }
    }
}
