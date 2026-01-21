using System.Collections;
using UnityEngine;

public class CoroutuneTest : MonoBehaviour
{

    //    코루틴: 유니티에서 여러 프레임에 걸쳐 동작을
    //    나눠 처리하는 방법.스레드가 아니라 메인 루프에서 시간 지연을 쉽게 구현.
    //시작: StartCoroutine(코루틴메서드());
    //    멈춤: StopCoroutine(참조) 또는 StopAllCoroutines();
    //    자주 쓰는 yield: yield return null(다음 프레임까지 대기), yield return new WaitForSeconds(초), yield return new WaitUntil(()=>조건).

    void Start()
    {
        StartCoroutine(ChageText());
    }

    IEnumerator ChageText()
    {
        Debug.Log("준비");

        yield return new WaitForSeconds(1f); //1초 지연

        Debug.Log("시작");

        yield return new WaitForSeconds(1f);

        Debug.Log("끝");
    }
}
