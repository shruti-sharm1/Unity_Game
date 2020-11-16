
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;


    // Update is called once per frame
    void Update()
    {
        if(Player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, Player.position.y, transform.position.z);
        }
    }
}
