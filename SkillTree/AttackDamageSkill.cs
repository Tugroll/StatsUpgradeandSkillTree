using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(menuName = "FadeOfShape/TestSkill/TestSkilke")]
public class AttackDamageSkill : SkillsDataBase
{

    public override void OnProcess(Image FillImage, Image FrameImage,Image IconeImage)
    {
        base.OnProcess(FillImage, FrameImage,IconeImage);

    }

    public override void IconImageColor(Image IconImage)
    {
        IconImage.color = Color.red;
    }

    

}
