using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string saveName;

    void Start()
    {
        PlayerPrefs.SetInt(saveName, 0);
        
    }

    public void SaveKey()
    {
        PlayerPrefs.SetInt(saveName, 1);
        FindObjectOfType<KeyCounter>().AddKey();
    }

}
