using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "FadeOfShape/Upgrade/UpgradeHP")]
public class HealthUpgrade : Upgrades
{
    public override bool Upgradable()
    {
        return true;
    }

    public override void UpgradeSkill()
    {
        if (stats.skillPoint > 0 && skill.UpgradeCounter < 5 && Upgradable()==true)
        {

            stats.stats[(int)StatsEnum.HP].value += stats.stats[(int)StatsEnum.HP].value / 10;
            UIControler.instance.healthBarsScale();
            
          
        }
    }

   
}
