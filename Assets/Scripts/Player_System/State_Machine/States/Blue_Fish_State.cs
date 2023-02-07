using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Fish_State : Base_Player,IEnterState
{
    public void EnterState(Player player)
    { 
        player.transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
        player.gameObject.GetComponent<SpriteRenderer>().sprite = player.PlayerRenderer.BlueFishSprite;
    }


    public override void LwlUpControl(Player player)
    {
        if (Image_Bar_System.instance.Image_Bar2.fillAmount >= 1)
        {
            player.SwitchState(player.RedFishState);
        }
       
    }
}
