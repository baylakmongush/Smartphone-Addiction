using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

	private Canvas canvas;

	public GameObject player;

	private Items items;

	public Transform inventorySlots;

	private Slot[] slots;
	public Sprite item;
	void Start()
	{
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;
		items = player.GetComponent<Items>();
		slots = inventorySlots.GetComponentsInChildren<Slot>(); //Получение всех ячеек
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
		/*//Debug.Log(slots.Length);
		for (int i = 0; i < 4;i++)
		{
			if (item)
		}*/
		slots[0].sprite = item;
		Debug.Log(slots[0].sprite);
		for (int i = 0; i < slots.Length; i++) //Проверка всех предметов
		{
			bool active = false;
			if (items.hasItems[i]) //Если такой предмет есть у пользователя, то он будет отображаться в слоте
			{
				active = true;
			}

			slots[i].UpdateSlot(active);
		}
	}
}