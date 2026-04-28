namespace UnConfuserEx.Protections.Resources;

internal interface IDecryptor
{
    public byte[] Decrypt(uint[] key, uint[] data);

}
