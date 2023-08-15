using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [SerializeField] float m_movePower = 0.1f;
    Rigidbody2D m_rb = default;
    //private int Score = 0;
    //public Text ScoreText;

    private float speed = 0.02f;
    float m_h;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        m_h = Input.GetAxisRaw("Horizontal");

        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= speed;
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed;
        }

        transform.position = position;
    }
}