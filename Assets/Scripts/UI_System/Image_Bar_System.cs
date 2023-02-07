using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Bar_System : MonoBehaviour
{
    public static Image_Bar_System instance;

    [SerializeField]
    private Image image_Bar1;
    public Image Image_Bar1 => image_Bar1;

    [SerializeField]
    private Image image_Bar2;
    public Image Image_Bar2 => image_Bar2;

    [SerializeField]
    private Image image_Bar3;
    public Image Image_Bar3 => image_Bar3;

    private Image currentImage;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Game_Events_System.instance.OnToFillImageBar += ToFillImageBar;
        currentImage = image_Bar1;
    }

    private void ToFillImageBar(float value)
    {
        if(image_Bar1.fillAmount!=1)
        {
            currentImage.fillAmount += value / 10f;
        
        }
        else if (image_Bar2.fillAmount!=1)
        {
            currentImage = Image_Bar2;
            currentImage.fillAmount += value / 25;
        }
        else if (image_Bar3.fillAmount != 1)
        {
            currentImage = Image_Bar3;
            currentImage.fillAmount += value / 100;
        }
    }

    

}
