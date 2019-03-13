using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameControl : MonoBehaviour, IPointerDownHandler
{

    private Camera cam;

    private GameObject tempBlower;

    [SerializeField]
    private GameObject blower;


    public void OnPointerDown(PointerEventData data)
    {
        Vector3 instPoint = cam.ScreenToWorldPoint(new Vector3(data.position.x, data.position.y, 0));


        tempBlower = Instantiate(blower, instPoint, Quaternion.identity);
        tempBlower.transform.position = new Vector3(tempBlower.transform.position.x, tempBlower.transform.position.y, 0);
        //StartCoroutine(Destroy());
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(tempBlower);
    }

    //public void OnPointerUP(PointerEventData data)
    //{
    //    Debug.Log("destroy");
    //}

    private void OnPointerUp(PointerEventData data)
    {
        Debug.Log("destroy");
    }
}
