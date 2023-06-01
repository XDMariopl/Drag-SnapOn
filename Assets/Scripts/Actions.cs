using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour {
	public Objects objektuskripts;
	
	
	void Update () {
		if(objektuskripts.lastDraged !=null)
		{
			if(Input.GetKey(KeyCode.Z))
			{
				objektuskripts.lastDraged.GetComponent<RectTransform>().transform.Rotate(0,0,Time.deltaTime*13f);
			}
            if (Input.GetKey(KeyCode.X))
            {
                objektuskripts.lastDraged.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 13f);
            }
			if(Input.GetKey(KeyCode.UpArrow))
			{
				if(objektuskripts.lastDraged.GetComponent<RectTransform>().localScale.y <=0.90f) 
				{
					objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale = new Vector2(objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.x, objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.y + 0.008f);
				}
			}
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (objektuskripts.lastDraged.GetComponent<RectTransform>().localScale.y >= 0.3f)
                {
                    objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale = new Vector2(objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.x, objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.y - 0.008f);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuskripts.lastDraged.GetComponent<RectTransform>().localScale.x <= 0.90f)
                {
                    objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale = new Vector2(objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.x+0.008f, objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.y);
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuskripts.lastDraged.GetComponent<RectTransform>().localScale.x >= 0.3f)
                {
                    objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale = new Vector2(objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.x-0.008f, objektuskripts.lastDraged.GetComponent<RectTransform>().transform.localScale.y);
                }
            }
        }
	}
}
