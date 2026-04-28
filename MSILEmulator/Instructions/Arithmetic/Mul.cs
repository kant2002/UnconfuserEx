namespace MSILEmulator.Instructions.Arithmetic
{
    internal class Mul
    {
        public static void Emulate(Context ctx)
        {
            int val2 = (int)ctx.Stack.Pop();
            int val1 = (int)ctx.Stack.Pop();

            ctx.Stack.Push(val1 * val2);
        }
    }
}
