using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  DFIMG : MonoBehaviour
{
    public bool input;
    public Vector2 touchPosition;

    public SpriteRenderer check1;
    public SpriteRenderer check2;
    public SpriteRenderer check3;
    public SpriteRenderer check4;

    private bool check_1;
    private bool check_2;
    private bool check_3;
    private bool check_4;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer check1 = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer check2 = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer check3 = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer check4 = gameObject.GetComponent<SpriteRenderer>();
        check_1 = false;
        check_2 = false;
        check_3 = false;
        check_4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            touchPosition = Input.mousePosition;
            input = true;
        }
        if( Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            input = false;
        }

        if (touchPosition.x > 1270 &&  touchPosition.x < 1370 && touchPosition.y > 710 && touchPosition.y < 780)
        {
            StartCoroutine(first());
            //��
        }

        if (touchPosition.x > 1050  &&  touchPosition.x < 1115 && touchPosition.y > 550 && touchPosition.y < 635)
        {
            StartCoroutine(second());
            //Ŀư
        }

        if (touchPosition.x > 1110  &&  touchPosition.x < 1200 && touchPosition.y > 550 && touchPosition.y < 610)
        {
            StartCoroutine(third());
            //�Ӹ���
        }

        if (touchPosition.x > 1660  &&  touchPosition.x < 1800 && touchPosition.y > 370 && touchPosition.y < 500)
        {
            StartCoroutine(fourth());
            //ȭ��
        }

        if(check_1 == true && check_2 == true && check_3  == true && check_4 == true)
        {
            //����ȯ
            Debug.Log("All Check");
        }



    }

    IEnumerator first()
    {
        for (float i = 0f; i <= 1f; i += 0.1f) {
            
            Color color = new Vector4(1, 1, 1, i); 
            check1.color = color; 
            yield return 0;
        }
        check_1 = true;
        Debug.Log("1");
    }

    IEnumerator second()
    {
        for (float j = 0f; j <= 1f; j += 0.1f)
        {

            Color color = new Vector4(1, 1, 1, j);
            check2.color = color;
            yield return 0;
            
        }
        check_2 = true;
        Debug.Log("2");
    }

    IEnumerator third()
    {
        for (float k = 0f; k <= 1f; k += 0.1f)
        {

            Color color = new Vector4(1, 1, 1, k);
            check3.color = color;
            yield return 0;
            
        }
        check_3 = true;
        Debug.Log("3");
    }

    IEnumerator fourth()
    {
        for (float f = 0f; f <= 1f; f += 0.1f)
        {

            Color color = new Vector4(1, 1, 1, f);
            check4.color = color;
            yield return 0;
            
        }
        check_4 = true;
        Debug.Log("4");
    }
}
