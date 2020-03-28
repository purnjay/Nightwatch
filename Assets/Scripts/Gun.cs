using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    public KeyCode shoot;

    public int ammo;
    public int maxAmmoCounter;
    private int maxAmmo = 5;

    public Text ammoText;

    public string tag;

    public GameObject Muzzle;
    public Transform muzzlePoint;

    public ParticleSystem part;

    void Start()
    {
        maxAmmo = maxAmmoCounter;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shoot))
        {
            Shoot();
           
        }

       /* GameObject GunText = GameObject.FindGameObjectWithTag(tag);

        if (PlayerPrefs.GetString("Gun", "Unlocked") != null)
        {
            GunText.SetActive(true);
        }
        else
        {
            GunText.SetActive(false);
        }
    */


         ammoText.text = ammo + "/" + maxAmmo;

        if (ammo > maxAmmo)
            ammo = maxAmmo;


        ammo = Mathf.Clamp(ammo, 0, maxAmmo);

        
        }

    

    void Shoot()
    {
        RaycastHit hit;

        if (ammo == 0)
        {
            Debug.Log("can't fire more rounds, clip empty.");
        }
        else
        {

            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                ammo -= 1;
                /*     GameObject _hit = Instantiate(Muzzle, muzzlePoint.position, muzzlePoint.rotation, muzzlePoint);
                     Destroy(_hit, 1f);
         */
                part.Play();


            }
        }
    }

    public void AddAmmo()
    {
        if ((ammo + 3) > maxAmmo)
        {
            Debug.Log("No Space for More ammo! Empty some rounds to make space for the clip.");
            
        }
        else {
            ammo += 3;
        }
    }

}
