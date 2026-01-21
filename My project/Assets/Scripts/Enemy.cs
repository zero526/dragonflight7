using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed = -1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //적 이동
        transform.Translate(0, enemySpeed * Time.deltaTime, 0);

    }

    private void OnBecameInvisible() { //오브젝트가 화면 밖으로 나가면 호출됨.
        Destroy(gameObject);
    }


}