using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Fish_State : Base_Player
{
  
    public override void LwlUpControl(Player player)
    {
        if (Image_Bar_System.instance.Image_Bar1.fillAmount >= 1)
        {
            player.SwitchState(player.BlueFishState);
        }
    }
}
