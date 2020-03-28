using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter : MonoBehaviour
{

    public int keyCounter;
    public int maxKeys;

    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        keyCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = keyCounter + "/" + maxKeys;

        if (keyCounter > maxKeys)
            keyCounter = maxKeys;
    }

    public void AddKey()
    {
        keyCounter += 1;
    }
}
