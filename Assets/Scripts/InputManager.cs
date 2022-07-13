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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bool isHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (isHit)
            {
                Debug.Log("hit " + hitInfo.transform.gameObject.name);
            }
        }
    }
}
