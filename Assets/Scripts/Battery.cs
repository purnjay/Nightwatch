using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{

    public Image[] cells;

    public int batteryNumber;

    public Light torchLight; 

    public Torch torch;

    public float timer;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cells.Length; i++) {

            cells[i].enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
