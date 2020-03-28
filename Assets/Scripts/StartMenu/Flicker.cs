using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public GameObject Light;
    public MeshRenderer Mesh;
    public float timer;

    void Start()
    {
        StartCoroutine(FlickeringLight());
    }

    IEnumerator FlickeringLight()
    {
        Light.SetActive(true);
        Mesh.enabled = true;
        timer = Random.Range(0.1f, 1.5f);
        yield return new WaitForSeconds(timer);
        Light.SetActive(false);
        Mesh.enabled = false;
        timer = Random.Range(0.1f, 1);
        yield return new WaitForSeconds(timer);
        StartCoroutine(FlickeringLight());
    }

}
