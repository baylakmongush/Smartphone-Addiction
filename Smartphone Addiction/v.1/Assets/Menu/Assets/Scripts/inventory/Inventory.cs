using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

	private Canvas canvas;

	public GameObject player;

	public Items items;

	public Transform inventorySlots;

	public Slot[] slots;
	public Sprite item;

	void Start()
	{
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;
		items = player.GetComponent<Items>();
		slots = inventorySlots.GetComponentsInChildren<Slot>(); //Получение всех ячеек
		canvas.transform.localScale = new Vector3(0.5f, 0.5f, 0);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.I))
		{
			UpdateUI(); //Обновление интерфейса
			canvas.enabled = !canvas.enabled;
		}
	}

	void UpdateUI()
	{

		bool active = false;
		if ((slots[0].sprite == null || slots[1].sprite == null) && item != null )
		{
		    if (item.name == "items_0")
		    {
			    slots[0].sprite = item;
			    active = true;
			    slots[0].UpdateSlot(active);
			    item = null;
			}
		    else if (item.name == "Items_2_12")
		    {
			    slots[1].sprite = item;
			    active = true;
			    slots[1].UpdateSlot(active);
			    item = null;
			}
		}
	}
}