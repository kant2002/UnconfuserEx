using dnlib.DotNet.Emit;

namespace MSILEmulator.Instructions.Store
{
    internal class Stloc
    {
        public static void Emulate(Context ctx, Instruction instr)
        {
            int index;
            if (instr.Operand == null)
            {
                index = instr.OpCode.Code - Code.Stloc_0;
            }
            else
            {
                index = ((Local)instr.Operand).Index;
            }

            ctx.Locals[index] = ctx.Stack.Pop();
        }
    }
}
