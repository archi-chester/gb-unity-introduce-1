using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC : MonoBehaviour
{
    [SerializeField] public GameObject spawnPoint;
    [SerializeField] private GameObject _npc01;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_npc01, spawnPoint.transform.position, spawnPoint.transform.rotation);
        Debug.Log("_npc01.transform.position");
        Debug.Log(_npc01.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
