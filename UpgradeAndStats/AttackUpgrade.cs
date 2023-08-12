using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "FadeOfShape/Upgrade/UpgradeAttack")]
public class AttackUpgrade : Upgrades
{
    public override bool Upgradable()
    {
        return true;
    }

    public override void UpgradeSkill()
    {
        if (stats.skillPoint > 0 && skill.UpgradeCounter < 5 && Upgradable() == true)
        {

            stats.stats[(int)(StatsEnum.AttackDamage)].value += (stats.GetValue(StatsEnum.AttackDamage) * 25)/ 100;
            weapon.attackDamage = (int)stats.stats[(int)(StatsEnum.AttackDamage)].value;
          
           
        }
    }
}
