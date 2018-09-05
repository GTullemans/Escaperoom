using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2));
            RaycastHit info;
            Physics.Raycast(ray, out info);
            if(info.collider.tag == "Item")
            {
                info.collider.gameObject.GetComponent<ItemUse>().UseItem();

            }

            
        }
	}
}
