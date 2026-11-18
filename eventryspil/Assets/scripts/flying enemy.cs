using UnityEngine;

public class flyingenemy : MonoBehaviour
{
[SerializeField]
private playermovescript playermovescript;
Rigidbody2D Rb ;
[SerializeField] private int EnemyHp = 1;
[SerializeField] private int Demage = 1;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playermovescript.PlayerHp -= Demage;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
