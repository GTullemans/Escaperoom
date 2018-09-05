using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour {
    [SerializeField] private Item Item;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void UseItem()
    {
        Debug.Log("Item Hit");
        Item.Use();
    }
}
