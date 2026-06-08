using UnityEngine;

public class CHARACTER : MonoBehaviour
{
    int entero = 0;
    float deci = 2.3f;
    bool isActive = true;
    [SerializeField] protected float vel;
    protected Vector2 inputMove;

    float m_vida;
    float m_vidaActual;
    private void Start()
    {
        m_vidaActual = m_vida;
    }
    void TakeDamage(float damage)
    {
        m_vidaActual -= damage;
    }
    public void Move()
    {
        Vector3 direction = new Vector3(inputMove.x, 0, inputMove.y);

        transform.Translate(direction * vel * Time.deltaTime);
    }
    void Die()
    {
        if (m_vidaActual <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    private void Fixedupdate()
    {
        inputMove.x =
    Input.GetAxis("horizontal");
        inputMove.y =
    Input.GetAxis("vertical");
        Move();
        Die();
    }
}
