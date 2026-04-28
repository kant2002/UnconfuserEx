namespace MSILEmulator.Instructions.Arithmetic;

internal class Neg
{
    public static void Emulate(Context ctx)
    {
        int val = (int)ctx.Stack.Pop();

        ctx.Stack.Push(-val);
    }
}
