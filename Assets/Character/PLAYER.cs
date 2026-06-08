using UnityEngine;
using UnityEngine.InputSystem;

public class PLAYER : CHARACTER
{
    private Vector2 inputMove;

    void Die()
        {
    Debug.Log("Player murió");
}
    void FixedUpdate()
    {
        Move();
        Die();
    }
    public void OnMove(InputValue inputValue)
    {
        Vector2 inputMove = inputValue.Get<Vector2>();
    }
    public void Move()
    {
        Debug.Log("Moviendo jugador");
    }
    void DamagePlayer()
    {
        string damage = "Daño aplicado";

        Debug.Log(damage);

        Die();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Trampa"))
        {
            DamagePlayer();
        }
    }
}