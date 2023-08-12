using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SkillMonoManager : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] SkillsDataBase skills;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] StatsUpgrade stats;
    [SerializeField] Upgrades upgradeable;

    public Image FillImage;
    public Image FrameImage;
    public Image IconImage;

    public GameObject skillContentPanel;
    public TextMeshProUGUI skilltext;
    public Image SkillSprite;

    bool isHover = true;

    private void Start()
    {
        skills.OnClick = false;
    }
    private void Update()
    {


        if (skills.OnClick == true && skills.UpgradeCounter < 5)
        {
            skills.OnProcess(FillImage, FrameImage, IconImage);
            //UpdateText();
        }

    }
   
    public void OnClickCtrl()
    {
        if(skills.UpgradeCounter < 5 && stats.skillPoint >0 && upgradeable.Upgradable() == true)
        {
            skills.OnClick = true;
            int value = int.Parse(text.text);
            text.text = (value + 1).ToString();
            skills.UpgradeCounter++;
            stats.skillPoint--;

        }
       


    }

    //to see the information of the skill when the skill is hovered over
    public void OnPointerEnter(PointerEventData eventData)
    {
        skills.ShowThePopUp(skillContentPanel, SkillSprite, skilltext, isHover);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        skills.ShowThePopUp(skillContentPanel, SkillSprite, skilltext, !isHover);
    }
}
