using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item {

    public enum ItemType
    {
        Collectable,
        Unlockable,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite() {
        switch (itemType) {
            default:
            case ItemType.Collectable: return ItemAssets.Instance.key;
            case ItemType.Unlockable:  return ItemAssets.Instance.torch;


        }
    }

}
