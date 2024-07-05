using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DVAH;
using System.Linq;

public class InventoryManager : Singleton<InventoryManager>
{
    [SerializeField] Transform _girdLayout;
    [SerializeField] List<ItemInventoryBase> _items = new List<ItemInventoryBase>();
    public List<ItemInventoryBase> items => _items;

    [SerializeField] List<Transform> _itemSlots = new List<Transform>();
    void Start()
    {
        _itemSlots = _girdLayout.GetComponentsInChildren<Transform>().ToList();
        _itemSlots.RemoveAt(0);
        Init();
    }
    void Init()
    {
        int i = 0;
        foreach (ItemInventoryBase item in _items)
        {
            Instantiate(item.gameObject, _itemSlots[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
