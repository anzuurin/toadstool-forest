using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance; 
    public List<Sprite> playerSprites; 
    public List<Sprite> weaponSprites; 
    public List<int> weaponPrices; 
    public List<int> xpTable; 

    // References
    //public Player player; 

    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
