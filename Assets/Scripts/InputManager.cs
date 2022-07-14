using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private RaycastHit hitInfo;

    private void Awake()
    {
        hitInfo = new RaycastHit();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Left mouse click
        {
            bool isHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (!isHit)
            {
                return;
            }

            Debug.Log("hit " + hitInfo.transform.gameObject.name);

            InteractableItem item = hitInfo.transform.gameObject.GetComponent<InteractableItem>();

            if (item == null)
            {
                return;
            }

            item.Interact();
        }
    }
}
