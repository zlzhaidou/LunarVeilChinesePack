﻿namespace LunarVeilChinesePack.Projectiles;

internal class MiscProjectileLocalizer : ModSystem
{
    public override void Load()
    {
        #region AuroreanStarbomber
        ForceLocalizeSystem.LocalizeByTypeName("AuroreanStarbomber", "SpawnStarBomber", new() {
            { "STARBOMBER crashes down!", "星爆者从天砸落！" },
        });
        #endregion
        #region BloodLampProjectileModifications
        ForceLocalizeSystem.LocalizeByTypeName("BloodLampProjectileModifications", "OnHitNPC", new() {
            { "This NPC has been hit with a modified projectile ", "此NPC被特殊弹幕击中 " },
            { " times.", " 次." },
        });
        #endregion
        #region ProjectileModifications
        ForceLocalizeSystem.LocalizeByTypeName("ProjectileModifications", "OnHitNPC", new() {
            { "This NPC has been hit with a modified projectile ", "此NPC被特殊弹幕击中 " },
            { " times.", " 次." },
        });
        #endregion
        #region IgniterStart
        ForceLocalizeSystem.LocalizeByTypeName("IgniterStart", "OnHitNPC", new() {
            { "STRIKE!!", "攻击！！" },
            { "MAGIC!", "魔法！！" },
        });
        #endregion
    }
}
