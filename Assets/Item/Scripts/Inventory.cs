using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    [SerializeField] private Item[] _Invent;
    [SerializeField] private Canvas _Canvas;
	// Use this for initialization
	void Start () {
        _Invent = new Item[5];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddItem(Item Item)
    {
        for (int i = 0; i < _Invent.Length; i++)
        {
            if (_Invent[i] == null)
            {
                _Invent[i] = Item;
                break;

            }
        }
        for (int j = 0; j < _Invent.Length; j++)
        {
            if (_Invent[j] != null)
            {
                Sprite spr = Instantiate(_Invent[j].Sprite(), _Canvas.transform);
            }
            break;

        }
    }
}
