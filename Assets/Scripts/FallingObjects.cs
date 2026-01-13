using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    GameManager manager;

    void Start()
    {
        manager = FindFirstObjectByType<GameManager>();
        if (manager == null);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Untagged") || other.gameObject.name == "Grid") 
        {
            Destroy(gameObject); 
        }
        
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Enemy")) 
            {
                manager.FinishGame(); 
        
            }
            else if (gameObject.CompareTag("Reward")) 
            {
                manager.EarnMoney(); 
                Destroy(gameObject); 
            }
        }
    }
}