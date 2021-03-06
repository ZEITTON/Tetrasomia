using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator _animator;
    public PlayerMove playerMove;
    public Player player;
    Vector3 move;
    bool isCrouching;
    bool isDead;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Variable
        move = playerMove.rb.velocity;
        isCrouching = playerMove.isCrouching;
        isDead = player.isDead;

        //Animating
        float velocityZ = Vector3.Dot(move.normalized, transform.forward);
        float velocityX = Vector3.Dot(move.normalized, transform.right);

        _animator.SetBool("isCrouching", isCrouching);
        _animator.SetBool("isDead", isDead);
        _animator.SetFloat("VelocityZ", velocityZ, 0.1f, Time.deltaTime);
        _animator.SetFloat("VelocityX", velocityX, 0.1f, Time.deltaTime);
    }
}