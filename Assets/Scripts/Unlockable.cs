using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour
{
    public Text unlockableText;
    public Text descriptionText;

    public string objectName;

    public GameObject objectToUnlock;

    public string description;

    void Start()
    {
        objectToUnlock.SetActive(false);
        //descriptionText = unlockableText.GetComponentInChildren<Text>();
    }

    public void Activate()
    {
        StartCoroutine(Work());
    }

    IEnumerator Work()
    {
        unlockableText.text = objectName + " Unlocked+";

        descriptionText.text = description;

        objectToUnlock.SetActive(true);

        PlayerPrefs.SetString(objectName, "Unlocked");

        gameObject.GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(2);

        unlockableText.text = "";

        descriptionText.text = "";

        Destroy(gameObject);
    }
}
