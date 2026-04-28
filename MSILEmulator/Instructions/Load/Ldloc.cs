using dnlib.DotNet.Emit;
using System;

namespace MSILEmulator.Instructions.Load
{
    internal class Ldloc
    {
        public static void Emulate(Context ctx, Instruction instr)
        {
            int index;
            if (instr.Operand == null)
            {
                index = instr.OpCode.Code - Code.Ldloc_0;
            }
            else
            {
                index = ((Local)instr.Operand).Index;
            }

            if (ctx.Locals.TryGetValue(index, out var local))
            {
                ctx.Stack.Push(local);
            }
            else
            {
                throw new NotImplementedException("Attempted to load local that hasn't been set.");
            }
        }

    }
}
