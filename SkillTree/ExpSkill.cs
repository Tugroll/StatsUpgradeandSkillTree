using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "FadeOfShape/TestSkill/ExpSkilke")]
public class ExpSkill : SkillsDataBase
{
    public override void IconImageColor(Image IconImage)
    {
        IconImage.color = Color.yellow;
    }
    public override void OnProcess(Image FillImage, Image FrameImage, Image IconImage)
    {
        base.OnProcess(FillImage, FrameImage, IconImage);
    }

}
