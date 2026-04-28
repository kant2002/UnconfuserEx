using dnlib.DotNet.Emit;

namespace MSILEmulator.Instructions.Load;

internal class Ldelem
{
    public static void EmulateU4(Context ctx, Instruction instr)
    {
        int index = (int)ctx.Stack.Pop();
        var array = (uint[])ctx.Stack.Pop();

        ctx.Stack.Push(unchecked((int)array[index]));
    }
}
