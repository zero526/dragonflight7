using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(v, 0, 0);
    }


    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Enemy")) {
            //적삭제
            Destroy(collision.gameObject);

            //체력감소
        }
    }


}
