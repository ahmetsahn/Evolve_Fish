using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEatable
{
    void Eat(Player player, Collider2D collision);
}

