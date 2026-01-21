using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   //미사일 프리팹 가져올 변수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //함수 반복(함수이름, 초기 지연시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.5f, 1f);
    }

    void Shoot() {
        //오브젝트 생성 (생성할 오브젝트, 생성 위치, 회전 방향값)
        Instantiate(bullet, transform.position, Quaternion.identity);

        SoundManager.instance.SoundBullet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
