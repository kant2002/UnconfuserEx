namespace MSILEmulator.Instructions.Logic;

internal class Not
{
    public static void Emulate(Context ctx)
    {
        int val = (int)ctx.Stack.Pop();

        ctx.Stack.Push(~val);
    }
}
