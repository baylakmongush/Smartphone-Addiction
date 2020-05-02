using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	public int index = 0; //Номер предмета, в этой игре будет всего 3 типа брони, поэтому писать более сложный скрипт нет смысла
	public Slot slot;
	public Inventory inv;
	public Sprite sprite;
	void OnTriggerEnter2D(Collider2D obj) //«Наезд» на объект
	{
		
		if (obj.transform.tag == "Player")
		{
			//Debug.Log(obj.transform.tag);
			///obj.GetComponent<Items>().AddItem(index);//Если наехал игрок, то он сможет подобрать предмет
			inv.item = sprite;
			Debug.Log(inv.item);
			Destroy(gameObject); //Удаление объекта с карты
			//Debug.Log(obj.transform.tag);
		}
	}
}
