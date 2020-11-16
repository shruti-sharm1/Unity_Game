using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using TMPro;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;       //Speed of Player Object
    public Rigidbody2D rb;              //Object of Player Object

    public SpriteRenderer sr;
    public string currentColor;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;

   // private int count;
   // public TextMeshProUGUI countText;

    // Start is called before the first frame update
    void Start()
    {
        SetRandomColor();
       // count= 0;
       // SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0) || Input.GetButtonDown("Vertical"))
        //Jump=Space & 0 is Left Click & Vertical denotes UP(True) and DOWN(False) 
        //GetButtonDown denotes pressing key and GetMouseButtonDown denotes clicking mouse 
        {

            rb.velocity = Vector2.up * jumpForce;
            //Getting velocity value of Player Object and Updating it by speed
        }


        //Holding The ball from falling down
        if ((transform.position.y <= -4.85))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }


    /*void SetCountText()
    {
        countText.text = " X" + count.ToString();
    }
    */


    void OnTriggerEnter2D(Collider2D col)
    {

        //Debug.Log(col.tag);
        //Debug.Log() prints in console when object colide wd their respective Tags 
        //col.tag gives u the tagname which collides
        if (col.tag != currentColor && col.tag != "ColorChanger" && col.tag != "StartingPt" && col.tag != "StarScore")
        {
            // Debug.Log("Game Over!!!!!!!");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene("Lost");
            //To Reload The Scene 
        }

        if (col.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(col.gameObject);
            //To destroy the gameobject after changing its colour
            return;
            //to not to create Game Over message
        }


       /* if (col.tag == "StarScore")
        {
            Destroy(col.gameObject);
            count = count + 1;
            SetCountText();
        }
       */
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;

            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;

            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;

            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
        }
    }
}
