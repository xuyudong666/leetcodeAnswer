#region 将标题首字母大写
Console.WriteLine(CapitalizeTitle("L hV")); ;
static string CapitalizeTitle(string title)
{
    var chars = title.ToCharArray();
    int left = 0,right = 0;
    while (right < title.Length)
    {
        while (right < title.Length && title[right] != ' ')
        {
            ++right;
        }

        if(right - left > 2)
        {
            chars[left] = char.ToUpper(title[left]);
            ++left;
        }

        while(left < right)
        {
            chars[left] = char.ToLower(chars[left]);
            ++left;
        }
        left = right + 1;
        ++right;
    }

    return new string(chars);
}
#endregion