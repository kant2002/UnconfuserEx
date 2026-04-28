namespace UnConfuserEx.Protections.AntiTamper;

internal interface IKeyDeriver
{

    public uint[] DeriveKey(uint[] dst, uint[] src);

}
