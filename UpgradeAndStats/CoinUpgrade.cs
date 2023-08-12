using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "FadeOfShape/Upgrade/UpgradeCoin")]
public class CoinUpgrade : Upgrades
{
    [SerializeField] RedCristalSO coin;
    [SerializeField] ExpUpgrade exp;
    public override bool Upgradable()
    {
        return (exp.skill.UpgradeCounter > 1) ? true : false;
    }

    public override void UpgradeSkill()
    {
        if (stats.skillPoint > 0 && skill.UpgradeCounter < 5 && Upgradable() == true)
        {
            coin.coin += (coin.coin * 7) / 100;
        }
    }
}
