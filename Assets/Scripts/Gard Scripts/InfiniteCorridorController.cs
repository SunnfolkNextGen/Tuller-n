using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteCorridorController : MonoBehaviour
{

    [HideInInspector] public PlayerMovement player;

    private int[] choices = new int[4]; 
    [HideInInspector] public int currentChoice;

    [SerializeField] private GameObject Corridor0;
    [SerializeField] private GameObject Corridor1;
    [SerializeField] private GameObject Corridor2;
    [SerializeField] private GameObject Corridor3;
    [SerializeField] private GameObject Corridor4;

    [SerializeField] private GameObject SpawnPoint12;
    [SerializeField] private GameObject SpawnPoint34;



    [HideInInspector] public bool spawnFix;


    // Start is called before the first frame update
    void Start()
    {
        spawnFix = true;

        currentChoice = 0;

        choices[0] = 1;
        choices[1] = 2;
        choices[2] = 3;
        choices[3] = 4;

        player = FindObjectOfType<PlayerMovement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentChoice){
            case 1:
                if (choices[0] == player.DoorIndex && spawnFix)
                {
                    Instantiate(Corridor1, SpawnPoint12.transform.position, Quaternion.identity);
                    player.DoorIndex = 0;
                    spawnFix = false;
                }
                else
                {
                    Instantiate(Corridor0, SpawnPoint12.transform.position, Quaternion.identity);
                    currentChoice--;
                } 
                break;
            case 2: 
                if(choices[0] == player.DoorIndex && spawnFix)
                {
                    Instantiate(Corridor2, SpawnPoint12.transform.position, Quaternion.identity);
                    player.DoorIndex = 0;
                    spawnFix = false;
                }    
                else
                {
                    Instantiate(Corridor0, SpawnPoint12.transform.position, Quaternion.identity);
                    currentChoice--;
                } 
                break;
            case 3:
                if (choices[0] == player.DoorIndex && spawnFix)
                {
                    Instantiate(Corridor3, SpawnPoint34.transform.position, Quaternion.identity);
                    player.DoorIndex = 0;
                    spawnFix = false;
                }
                else
                {
                    Instantiate(Corridor0, SpawnPoint34.transform.position, Quaternion.identity);
                    currentChoice--;
                }    
                break;
            case 4:   
                if(choices[0] == player.DoorIndex && spawnFix)
                {
                    Instantiate(Corridor4, SpawnPoint34.transform.position, Quaternion.identity);
                    player.DoorIndex = 0;
                    spawnFix = false;
                }
                else
                {
                    Debug.Log("du åpnet dør nr 4");
                    Instantiate(Corridor0, SpawnPoint34.transform.position, Quaternion.identity);
                    currentChoice--;
                } 
                break;
        }



    }

    


}
