using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveSystem : MonoBehaviour
{
    public bool objectiveDone = false;
    public GameObject[] ObjectiveUI;
    int uiNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < ObjectiveUI.Length; x++)
        {
            ObjectiveUI[x].SetActive(false);
        }
        ObjectiveUI[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (objectiveDone)
        {
            ObjectiveUI[uiNum].SetActive(false);
            ObjectiveUI[uiNum + 1].SetActive(true);
            uiNum = uiNum + 1;
            objectiveDone = false;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            CompletedObjective();
        }

    }

   public void CompletedObjective()
    {
        objectiveDone = true;
    }
}
