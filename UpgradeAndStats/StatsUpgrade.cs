
using UnityEngine;
using FadeOfShape.Enemy;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "FadeOfShape/Player/PlayerStat")]
public class StatsUpgrade : ScriptableObject
{
    public List<StatsCons> stats = new List<StatsCons>();
 
    public int currentLevel;
    public int skillPoint;
    public float expLimit;
    


    [ContextMenu("setstats")]
    void setstats()
    {
        for (int i = 0; i < stats.Count; i++)
        {
            //statlist.Add((StatsEnum)i);
            stats[i].type = (StatsEnum)i;
        }
    }

    public float GetValue(StatsEnum type)
    {
        foreach (var s in stats)
        {
            if (s.type == type)
                return s.value;

            
        }
        return 0;
    }
   
    public void levelUp(Image Level,DamagebleObject damagable,StatsEnum health,StatsEnum attack)
    {
        currentLevel++;
        Level.fillAmount = 0;
        stats[(int)StatsEnum.exp].value = 0;
        stats[(int)health].value += 3;
        stats[(int)attack].value += 1;
        damagable.CurrentHealth = stats[(int)health].value;
        skillPoint++;
        expLimit += (expLimit * 10) / 100;


    }
   


   
}
