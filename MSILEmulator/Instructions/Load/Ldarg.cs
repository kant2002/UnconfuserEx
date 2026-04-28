using dnlib.DotNet.Emit;

namespace MSILEmulator.Instructions.Load
{
    internal class Ldarg
    {
        public static void Emulate(Context ctx, Instruction instr)
        {
            int index;
            if (instr.Operand == null)
            {
                index = instr.OpCode.Code - Code.Ldarg_0;
            }
            else
            {
                index = (int)instr.Operand;
            }

            if (ctx.Args.TryGetValue(index, out var val))
            {
                ctx.Stack.Push(val);
            }
            else
            {
                ctx.Stack.Push(0);
            }
        }
    }
}
