using System.Data.SqlTypes;



public static class UrlEncodeFunction
{
    public static SqlString UrlEncode(SqlString input)
    {
        string encodedString = System.Uri.EscapeDataString(input.Value);
        return new SqlString(encodedString);
    }
}

