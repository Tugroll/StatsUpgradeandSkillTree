using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FadeOfShape.Player;

[CreateAssetMenu(menuName = "FadeOfShape/Upgrade/UpgradeDash")]
public class DashUpgrade : Upgrades
{
    [SerializeField] AttackUpgrade attack;
    [SerializeField] DashDataAbstractBase dashData;
    public override bool Upgradable()
    {
        return (attack.skill.UpgradeCounter > 3) ? true : false;
    }

    public override void UpgradeSkill()
    {
        if (stats.skillPoint > 0 && skill.UpgradeCounter < 1)
        {

            dashData.isTransparent = true;


        }
    }
}
