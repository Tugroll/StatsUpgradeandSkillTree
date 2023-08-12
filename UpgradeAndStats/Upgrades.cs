using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FadeOfShape.Weapons;
using TMPro;

[CreateAssetMenu(menuName = "FadeOfShape/Player/PlayerUpgrades")]
public abstract class Upgrades : ScriptableObject
{
    public StatsUpgrade stats;
    public WeaponTypeAbstract weapon;
    public SkillsDataBase skill;
    


    private void OnEnable()
    {
        weapon.attackDamage = (int)stats.stats[(int)(StatsEnum.AttackDamage)].value;
    }

    public abstract void UpgradeSkill();

    public abstract bool Upgradable();
   


}
