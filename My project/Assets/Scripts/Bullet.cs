using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 3.0f;
    public GameObject effect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //총알 이동
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);

    }
    

    private void OnBecameInvisible() { //오브젝트가 화면 밖으로 나가면 호출됨.
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.CompareTag("Enemy")) {

            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            //미사일 삭제
            Destroy(collision.gameObject);

            SoundManager.instance.SoundDie();

            //본인(Enemy) 삭제
            Destroy(gameObject);
        }
        /*위와 동일한 기능
        if (collision.gameObject.tag == "Bullet") {
        }
        */
    }

}
