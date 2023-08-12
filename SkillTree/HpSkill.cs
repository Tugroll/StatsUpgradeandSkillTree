using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
[CreateAssetMenu(menuName = "FadeOfShape/TestSkill/TestSkilkeHP")]
public class HpSkill : SkillsDataBase
{
    
    public override void OnProcess(Image FillImage, Image FrameImage, Image IconImage)
    {
        base.OnProcess(FillImage, FrameImage, IconImage);
    }
    public override void IconImageColor(Image IconImage)
    {
        IconImage.color = Color.green;
    }

   
}
