global using LunarVeilChinesePack.Systems;
global using System;
global using System.Collections.Generic;
global using Terraria;
global using Terraria.ModLoader;

namespace LunarVeilChinesePack;

public class LunarVeilChinesePack : Mod
{
    public static string Tooltips_string(string old,string newst)
    {
        old = old.Replace(old,newst);
        return old;
    }
}
