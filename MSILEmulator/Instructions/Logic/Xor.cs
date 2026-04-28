namespace MSILEmulator.Instructions.Logic
{
    internal class Xor
    {
        public static void Emulate(Context ctx)
        {
            int val2 = (int)ctx.Stack.Pop();
            int val1 = (int)ctx.Stack.Pop();

            ctx.Stack.Push(val2 ^ val1);
        }
    }
}
