using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "FadeOfShape/Upgrade/UpgradeCritChance")]
public class CriticalChanceUpgrade : Upgrades
{
    [SerializeField] AttackUpgrade attack;
    public override bool Upgradable()
    {
        
        return (attack.skill.UpgradeCounter > 1)  ? true : false;
    }

    public override void UpgradeSkill()
    {
        if (stats.skillPoint > 0 && skill.UpgradeCounter < 5)
        {

            stats.stats[(int)StatsEnum.critChance].value += stats.stats[(int)StatsEnum.critChance].value / 10;


        }
    }
}
