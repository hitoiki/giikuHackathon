using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Item
{
    void GetItem(PlayerState state);
    void ItemVanish();

}
