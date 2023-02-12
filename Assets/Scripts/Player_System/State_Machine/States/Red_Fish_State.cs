using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Fish_State : Base_Player
{
    public override void EnterState(Player player)
    {
        player.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        player.gameObject.GetComponent<SpriteRenderer>().sprite = player.PlayerRenderer.RedFishSprite;
    }

    public override void OnTrigger(Player player)
    {
        if (Image_Bar_System.instance.Image_Bar3.fillAmount >= 1)
        {
            Game_Events_System.instance.LoadWinPanel();
        }
    }

}
