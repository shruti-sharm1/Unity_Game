using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{ 
    private int count;
    public TextMeshProUGUI countText;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }


    void SetCountText()
    {
        countText.text = " X" + count.ToString();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "StarScore")
        {
            Destroy(col.gameObject);
            count = count + 1;
            SetCountText();
        }
    }
}
