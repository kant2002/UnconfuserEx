using dnlib.DotNet;

namespace UnConfuserEx.Protections;

internal interface IProtection
{
    string Name { get; }

    public bool IsPresent(ref ModuleDefMD module);

    public bool Remove(ref ModuleDefMD module);
}
