using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject block;
    private Vector3 pos = new Vector3(0, 0, 0);
    void Start()
    {
        // Destroy(block);
        Physics.gravity = new Vector3(0, 0, 0);
        player.transform.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("asdf");
        pos += new Vector3(.01f, 0, 0);
        player.transform.transform.position = pos;
        // if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        // {
        //     Destory(block);
        // }
        // Debug.Log();
    }
}
