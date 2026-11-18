using UnityEngine;

public class playermovescript : MonoBehaviour
{
    [SerializeField] private float Speed = 9;
    public int PlayerHp = 1;
    Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 retning = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.D))
        {
            retning += new Vector2(1f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            retning += new Vector2(-1f, 0f);
        }
        retning *= Speed;
        if (Input.GetKey(KeyCode.W))
        {
            retning += new Vector2(0f,1f*Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            retning += new Vector2(0f,-1f*Speed);
        }
        Rb.linearVelocity = retning;
        
        if (PlayerHp <= 0)
        {
            Destroy(gameObject);
        }
    }


}
