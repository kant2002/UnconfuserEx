using dnlib.DotNet;

namespace UnConfuserEx.Protections;

internal interface IProtection
{
    /// <summary>
    /// Gets name of the protection which is being detected/removed. This is used for logging purposes.
    /// </summary>
    string Name { get; }

    public bool IsPresent(ref ModuleDefMD module);

    public bool Remove(ref ModuleDefMD module);
}
