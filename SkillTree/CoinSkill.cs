using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "FadeOfShape/TestSkill/CoinSkillke")]
public class CoinSkill : SkillsDataBase
{
    public override void IconImageColor(Image IconImage)
    {
        IconImage.color = Color.red;
    }

    public override void OnProcess(Image FillImage, Image FrameImage, Image IconImage)
    {
        base.OnProcess(FillImage, FrameImage, IconImage);
    }

}
