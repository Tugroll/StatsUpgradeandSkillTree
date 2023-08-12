
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public  abstract class SkillsDataBase : ScriptableObject
{
    public Sprite skillSprite;
   
    public int UpgradeCounter;
  
    public bool OnClick = false;
    public float lerpSpeed;

    public string content;
    public virtual void OnProcess(Image FillImage,Image FrameImage,Image IconImage)
    {
        lerpSpeed = 1.5f * Time.deltaTime;
        FillImage.fillAmount = Mathf.Lerp(FillImage.fillAmount,
              1, lerpSpeed);

        if (FillImage.fillAmount > .95f)
        {
            FrameImage.fillAmount = Mathf.Lerp(FrameImage.fillAmount,
                 1, lerpSpeed);
        }
        if (FrameImage.fillAmount > .99f)
        {
            IconImageColor(IconImage);
            OnClick = false;
        }
    }
    public abstract void IconImageColor(Image IconImage);
  

    public virtual void ShowThePopUp(GameObject panel,Image image, TextMeshProUGUI text,bool isHover)
    {
        
        image.sprite = skillSprite;
        text.text = content;
        panel.SetActive(isHover);
    }
}
