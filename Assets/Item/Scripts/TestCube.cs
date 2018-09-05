using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCube : Item {

    [SerializeField] private GameObject _Inventory;
    private Inventory _InScript;
    [SerializeField] private Sprite _Sprite;
	// Use this for initialization
	void Start () {
        _InScript = _Inventory.GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Use()
    {
        Debug.Log("Used");
        _InScript.AddItem(this);

    }

    public override Sprite Sprite()
    {
        return _Sprite;
    }



}
