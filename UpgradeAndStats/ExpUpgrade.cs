using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "FadeOfShape/Upgrade/UpgradeExp")]
public class ExpUpgrade : Upgrades
{
    [SerializeField] ExpCristalSO exp;
    public override bool Upgradable()
    {
        return true;
    }

    public override void UpgradeSkill()
    {

        if (stats.skillPoint > 0 && skill.UpgradeCounter < 5 && Upgradable() == true)
        {
            exp.exp += (exp.exp * 7) / 100;
        }
       
      

    }


}
