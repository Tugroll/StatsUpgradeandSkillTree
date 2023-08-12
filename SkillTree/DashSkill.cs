using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "FadeOfShape/TestSkill/DashSkillke")]
public class DashSkill : SkillsDataBase
{
    public override void IconImageColor(Image IconImage)
    {
        IconImage.color = Color.blue;
    }

    public override void OnProcess(Image FillImage, Image FrameImage, Image IconImage)
    {
        base.OnProcess(FillImage, FrameImage, IconImage);
    }
   
}
