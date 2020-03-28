using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{

    public Text interactInfo;

    public bool interactable;

    public KeyCode interact;

    public Inventory inventory;
    [SerializeField] InventoryUI uiInventory;

    void Awake()
    {
        //inventory = new Inventory();
       // uiInventory.SetInventory(inventory);
        
    }

    void Update()
    {
        if (interactable == false)
        {
            interactInfo.enabled = false;
        }
        else {
            interactInfo.enabled = true;
        }

    }


    public void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collectable>() != null)
        {
            interactable = true;
            ItemWorld itemWorld = col.GetComponent<ItemWorld>();
            if (itemWorld != null)
            {
                inventory.AddItem(itemWorld.GetItem());
                itemWorld.DestroySelf();
            }
            col.GetComponent<Collectable>().SaveKey();
            Destroy(col.gameObject);
        }
        else {
            interactable = false;
        }

        if (col.GetComponent<Unlockable>() != null)
        {
            interactable = true;
            ItemWorld itemWorld = col.GetComponent<ItemWorld>();
            if (itemWorld != null)
            {
                inventory.AddItem(itemWorld.GetItem());
                itemWorld.DestroySelf();
            }
            col.GetComponent<Unlockable>().Activate();

        }
        else
        {
            interactable = false;
        }

        if (col.CompareTag("Ammo"))
        {
            interactable = true;

            if (Input.GetKeyDown(interact)) {
                
                FindObjectOfType<Gun>().AddAmmo();
            }
        }
        else {
            interactable = false;
        }


    }

    public void OnTriggerStay(Collider col)
    {
        if (col.GetComponent<Collectable>() != null)
        {
            interactable = true;

            if (Input.GetKeyDown(interact)) {

                ItemWorld itemWorld = col.GetComponent<ItemWorld>();
                if (itemWorld != null)
                {
                    inventory.AddItem(itemWorld.GetItem());
                    itemWorld.DestroySelf();
                }
                col.GetComponent<Collectable>().SaveKey();
                Destroy(col.gameObject);
            }
        }
        else
        {
            interactable = false;
        }

        if (col.GetComponent<Unlockable>() != null)
        {
            interactable = true;

            if (Input.GetKeyDown(interact)) {
                ItemWorld itemWorld = col.GetComponent<ItemWorld>();
                if (itemWorld != null)
                {
                    inventory.AddItem(itemWorld.GetItem());
                    itemWorld.DestroySelf();
                }
                col.GetComponent<Unlockable>().Activate();
            }
        }
        else
        {
            interactable = false;
        }

        if (col.CompareTag("Ammo"))
        {
            interactable = true;

            if(Input.GetKeyDown(interact)) { 
            FindObjectOfType<Gun>().AddAmmo();
            Destroy(col.gameObject);
            }
        }
        else
        {
            interactable = false;
        }

    }

    public void OnTriggerExit(Collider col)
    {
        interactable = false;
    }

}
