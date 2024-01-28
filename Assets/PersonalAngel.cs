using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalAngel : MonoBehaviour
{

    [SerializeField] private Transform corner1, corner2;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        float newX = Mathf.Clamp(player.transform.position.x, corner2.position.x, corner1.position.x);
        
        float newZ = Mathf.Clamp(player.transform.position.z, corner1.position.z, corner2.position.z);
        
        transform.position = new Vector3(newX, player.transform.position.y + 8,newZ);
    }
}
