﻿namespace StringLibrary
{
    public static class ClassStringLibrary
    {
        public static bool StartsWithUpper(this string? str)
        {
            if(string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);

        }

    }
}