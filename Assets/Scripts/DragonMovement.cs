using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D playerRigidBody;
    public float flapStrength;
    public LogicManager logic;
    public bool dragonIsAlive = true;

    [SerializeField] private AudioSource jumpSFX;

    private Animator dragonAnim;

    void Awake()
    {
        dragonAnim = GetComponent<Animator>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dragonIsAlive)
        {
            playerRigidBody.velocity = Vector2.up * flapStrength;
            jumpSFX.Play();
        }

        if (transform.position.y > 10 || transform.position.y < -10)
        {
            logic.gameOver();
            dragonIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        dragonIsAlive = false;
    }

    public bool canAttack()
    {
        return true;
    }
}
