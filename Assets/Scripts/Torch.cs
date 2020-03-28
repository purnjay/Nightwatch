using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{

    public Light torch;

    public bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
        }

        torch.enabled = isOn;
    }
}
