using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayScript : MonoBehaviour
{
    string Ray_ObjName;
    string ButtonName;
    public GameObject Dajiang;
    float distance;
    float count=0.0f;
    float count_max=0f;
    public GameObject Camera_father;
    public GameObject RedPoint;
    public float speed = 0.01f;
    public float speed_rotate=0.1f;
    public float speed_max = 2f;
    bool DJ_Forward_Ctrl = false;
    bool DJ_Back_Ctrl = false;
    bool DJ_Up_Ctrl = false;
    bool DJ_Down_Ctrl = false;
    bool DJ_Left_Ctrl = false;
    bool DJ_Right_Ctrl = false;
    bool DJ_Rotate_Left_Ctrl = false;
    bool DJ_Rotate_Right_Ctrl = false;
    public Text speed_T;
    public Text speed_rotate_T;
    public float hit_point_y;

    // Start is called before the first frame update
    void Start()
    {
        
        //Debug.Log(speed_T.text.ToString());
        //Dajiang.transform.LookAt(aa.transform);
        //Dajiang.transform.Translate(Vector3.back * 10f);
        //DJ_LookAt();
    }

    // Update is called once per frame
    void Update()
    {
        speed_T.text = "飞行速度:" + speed.ToString("f2");
        speed_rotate_T.text = "旋转速度:" + speed_rotate.ToString("f2");
        if (DJ_Forward_Ctrl)
            Dajiang.transform.Translate(Vector3.forward * speed);
        if (DJ_Back_Ctrl)
            Dajiang.transform.Translate(Vector3.back * speed);
        if (DJ_Left_Ctrl)
            Dajiang.transform.Translate(Vector3.left * speed);
        if (DJ_Right_Ctrl)
            Dajiang.transform.Translate(Vector3.right * speed);
        if (DJ_Up_Ctrl)
            Dajiang.transform.Translate(Vector3.up * speed);
        if (DJ_Down_Ctrl&&Dajiang.transform.position.y>=0.5f+speed)
            Dajiang.transform.Translate(Vector3.down * speed);
        if (DJ_Rotate_Left_Ctrl)
            Dajiang.transform.Rotate(new Vector3(0, -speed_rotate, 0));
        if (DJ_Rotate_Right_Ctrl)
            Dajiang.transform.Rotate(new Vector3(0, speed_rotate, 0));

        switch (ButtonName)
        {
            case "jianyuan":
                {
                    //Debug.Log(Ray_ObjName);
                    DJ_LookAt();
                    if (count <= count_max)
                    {
                        Dajiang.transform.Translate(Vector3.back * 0.01f);
                        Dajiang.transform.Translate(Vector3.up * 0.01f);
                        count += 0.02f;
                        //Debug.Log(count);
                    }
                    else
                    {
                        ButtonName = "";
                        count = 0;
                        count_max = 0;
                        //RedPoint.SetActive(true);
                    }
                    break;
                }
            case "huanrao":
                {
                    if (count <=count_max)
                    {
                        Dajiang.transform.position = new Vector3(GameObject.Find(Ray_ObjName).transform.position.x + Mathf.Cos(count) * distance,
                            Dajiang.transform.position.y,
                            GameObject.Find(Ray_ObjName).transform.position.z + Mathf.Sin(count) * distance);
                        DJ_LookAt();
                        //Debug.Log(count);
                        count +=0.01f;
                    }

                    else
                    {
                        ButtonName = "";
                        count = 0;
                        count_max = 0;
                        //RedPoint.SetActive(true);
                    }
                    break;
                }
            case "luoxuan":
                {
                    if (count <= count_max)
                    {
                        Dajiang.transform.position = new Vector3(GameObject.Find(Ray_ObjName).transform.position.x + Mathf.Cos(count) * distance,
                            Dajiang.transform.position.y+0.03f,
                            GameObject.Find(Ray_ObjName).transform.position.z + Mathf.Sin(count) * distance);
                        DJ_LookAt();
                        //Debug.Log(count);
                        distance += 0.02f;
                        count += 0.01f;
                    }

                    else
                    {
                        ButtonName = "";
                        count = 0;
                        count_max = 0;
                        //RedPoint.SetActive(true);
                    }
                    break;
                }
            case "chongtian":
                {
                    //Debug.Log(Ray_ObjName);
                    DJ_LookAt();
                    if(Dajiang.transform.position.y<= GameObject.Find(Ray_ObjName).transform.position.y+2)
                    {
                        Dajiang.transform.Translate(Vector3.up * 0.01f);
                    }
                    else
                    if (count <= count_max)
                    {
                        Dajiang.transform.Translate(Vector3.forward * 0.01f);
                        count += 0.01f;
                        //Debug.Log(count);
                    }
                    else
                    {
                        if (Dajiang.transform.position.y <= GameObject.Find(Ray_ObjName).transform.position.y + 10)
                        {
                            Dajiang.transform.Translate(Vector3.up * 0.01f);
                        }
                        else
                        {
                            ButtonName = "";
                            count = 0;
                            count_max = 0;
                            //RedPoint.SetActive(true);
                        }
                    }
                    break;
                }
            case "fanhang":
                {
                    
                    //Debug.Log(Ray_ObjName);
                    if(count==0&&count_max==0)
                    {
                        count = Dajiang.transform.rotation.eulerAngles.y;
                        Dajiang.transform.LookAt(new Vector3(0, Dajiang.transform.position.y, 0));
                        count_max = Dajiang.transform.rotation.eulerAngles.y;
                    }
                    if(Mathf.Abs(count-count_max)<=0.1)
                    {
                        Dajiang.transform.LookAt(new Vector3(0, Dajiang.transform.position.y, 0));
                        if (Dajiang.transform.position.y <= 20&& Vector3.Distance(new Vector3(Dajiang.transform.position.x, 0.5f, Dajiang.transform.position.z), new Vector3(0, 0.5f, 0)) > 0.01)
                        {
                            Dajiang.transform.Translate(Vector3.up * 0.01f);
                        }
                        else
                        {
                            if (Vector3.Distance(new Vector3(Dajiang.transform.position.x, 0.5f, Dajiang.transform.position.z),new Vector3(0,0.5f,0)) <= 0.01)
                            {
                                if (Vector3.Distance(Dajiang.transform.position,new Vector3(0,0.5f,0))>=0.01)
                                {
                                    Dajiang.transform.Translate(Vector3.down * 0.01f);
                                }
                                else
                                {
                                    Dajiang.transform.position = new Vector3 (0,0.5f,0);
                                    ButtonName = "";
                                    count = 0;
                                    count_max = 0;
                                    //RedPoint.SetActive(true);
                                }
                            }
                            else
                            {
                                Dajiang.transform.Translate(Vector3.forward * 0.01f);
                            }
                        }
                    }
                    else
                    if (count<=count_max)
                    {
                        //Debug.Log(count);
                        Dajiang.transform.rotation = Quaternion.Euler(Dajiang.transform.rotation.eulerAngles.x, count, Dajiang.transform.rotation.eulerAngles.z);
                        count +=0.1f;
                    }
                    else
                    {
                        //Debug.Log(count);
                        Dajiang.transform.rotation = Quaternion.Euler(Dajiang.transform.rotation.eulerAngles.x, count, Dajiang.transform.rotation.eulerAngles.z);
                        count -=0.1f;
                    }
                    break;
                }
            case "gensui":
                {
                    if (count <= count_max)
                    {
                        Dajiang.transform.position = new Vector3(GameObject.Find(Ray_ObjName).transform.position.x + Mathf.Cos(count) * distance,
                            Dajiang.transform.position.y + 0.03f,
                            GameObject.Find(Ray_ObjName).transform.position.z + Mathf.Sin(count) * distance);
                        DJ_LookAt();
                        //Debug.Log(count);
                        distance += 0.02f;
                        count += 0.01f;
                    }

                    else
                    {
                        ButtonName = "";
                        count = 0;
                        count_max = 0;
                        RedPoint.SetActive(true);
                    }
                    break;
                }
            default: break;
        }
    }
    public void Jianyuan()
    {
        ButtonName = "jianyuan";
        RaycastHit hit;
        Vector2 v = new Vector2(Screen.width / 2, Screen.height / 2); //屏幕中心点
        if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out hit))
        {
            Ray_ObjName = hit.collider.gameObject.name;
            hit_point_y = hit.point.y;
            //Debug.Log(hit.collider.gameObject.name);
            count_max = 10.0f;
            //RedPoint.SetActive(false);
        }

    }
    public void Huanrao()
    {
        ButtonName = "huanrao";
        RaycastHit hit;
        Vector2 v = new Vector2(Screen.width / 2, Screen.height / 2); //屏幕中心点
        if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out hit))
        {
            Ray_ObjName = hit.collider.gameObject.name;
            hit_point_y = hit.point.y;
            //Debug.Log(hit.collider.gameObject.name);
            distance = Vector3.Distance(new Vector3(Dajiang.transform.position.x,0, Dajiang.transform.position.z),
                new Vector3(GameObject.Find(Ray_ObjName).transform.position.x,0, GameObject.Find(Ray_ObjName).transform.position.z));//无人机到目标点的距离
            count = Mathf.Acos((Dajiang.transform.position.x - GameObject.Find(Ray_ObjName).transform.position.x) / distance);//无人机所在的初始角度
            count_max = count+6.35f;
            //RedPoint.SetActive(false);
        }
    }
    public void Luoxuan()
    {
        ButtonName = "luoxuan";
        RaycastHit hit;
        Vector2 v = new Vector2(Screen.width / 2, Screen.height / 2); //屏幕中心点
        if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out hit))
        {
            Ray_ObjName = hit.collider.gameObject.name;
            hit_point_y = hit.point.y;
            //Debug.Log(hit.collider.gameObject.name);
            distance = Vector3.Distance(new Vector3(Dajiang.transform.position.x, 0, Dajiang.transform.position.z),
                new Vector3(GameObject.Find(Ray_ObjName).transform.position.x, 0, GameObject.Find(Ray_ObjName).transform.position.z));//无人机到目标点的距离
            count = Mathf.Acos((Dajiang.transform.position.x - GameObject.Find(Ray_ObjName).transform.position.x) / distance);//无人机所在的初始角度
            count_max = count + 6.35f;
            //RedPoint.SetActive(false);
        }
    }
    public void Chongtian()
    {
        ButtonName = "chongtian";
        RaycastHit hit;
        Vector2 v = new Vector2(Screen.width / 2, Screen.height / 2); //屏幕中心点
        if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out hit))
        {
            Ray_ObjName = hit.collider.gameObject.name;
            hit_point_y = hit.point.y;
            //Debug.Log(hit.collider.gameObject.name);
            distance = Vector3.Distance(new Vector3(Dajiang.transform.position.x, 0, Dajiang.transform.position.z),
                new Vector3(GameObject.Find(Ray_ObjName).transform.position.x, 0, GameObject.Find(Ray_ObjName).transform.position.z));//无人机到目标点的距离
            count_max = distance-0.4f;
            //RedPoint.SetActive(false);
        }
    }
    public void DJ_LookAt()
    {
        Dajiang.transform.LookAt(new Vector3(GameObject.Find(Ray_ObjName).transform.position.x, Dajiang.transform.position.y, GameObject.Find(Ray_ObjName).transform.position.z));
        Camera_father.transform.LookAt(new Vector3(GameObject.Find(Ray_ObjName).transform.position.x,hit_point_y, GameObject.Find(Ray_ObjName).transform.position.z) );
        //Camera_father.transform.LookAt(aa.transform);
    }

    public void Fanhang()
    {
        ButtonName = "fanhang";
        //RedPoint.SetActive(false);
    }
    public void Gensui()
    {
        ButtonName = "gensui";
        RaycastHit hit;
        Vector2 v = new Vector2(Screen.width / 2, Screen.height / 2); //屏幕中心点
        if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out hit))
        {
            Ray_ObjName = hit.collider.gameObject.name;
            hit_point_y = hit.point.y;
            //Debug.Log(hit.collider.gameObject.name);
            distance = Vector3.Distance(new Vector3(Dajiang.transform.position.x, 0, Dajiang.transform.position.z),
                new Vector3(GameObject.Find(Ray_ObjName).transform.position.x, 0, GameObject.Find(Ray_ObjName).transform.position.z));//无人机到目标点的距离
            //RedPoint.SetActive(false);
        }
    }
    public void DJ_Forward()
    {
        if (DJ_Forward_Ctrl)
            DJ_Forward_Ctrl = false;
        else
            DJ_Forward_Ctrl = true;
        
    }
    public void DJ_Back()
    {
        if (DJ_Back_Ctrl)
            DJ_Back_Ctrl = false;
        else
            DJ_Back_Ctrl = true;
    }
    public void DJ_Left()
    {
        if (DJ_Left_Ctrl)
            DJ_Left_Ctrl = false;
        else
            DJ_Left_Ctrl = true;
    }
    public void DJ_Right()
    {
        if (DJ_Right_Ctrl)
            DJ_Right_Ctrl = false;
        else
            DJ_Right_Ctrl = true;
    }
    public void DJ_Up()
    {
        if (DJ_Up_Ctrl)
            DJ_Up_Ctrl = false;
        else
            DJ_Up_Ctrl = true;
    }
    public void DJ_Down()
    {
        if (DJ_Down_Ctrl)
            DJ_Down_Ctrl = false;
        else
            DJ_Down_Ctrl = true;
    }
    public void DJ_Rotate_left()
    {
        if (DJ_Rotate_Left_Ctrl)
            DJ_Rotate_Left_Ctrl = false;
        else
            DJ_Rotate_Left_Ctrl = true;
    }
    public void DJ_Rotate_Right()
    {
        if (DJ_Rotate_Right_Ctrl)
            DJ_Rotate_Right_Ctrl = false;
        else
            DJ_Rotate_Right_Ctrl = true;
    }
    public void Speed_UP()
    {
        speed += 0.01f;
    }
    public void Speed_Down()
    {
        speed -= 0.01f;
    }
    public void Speed_Rotate_UP()
    {
        speed_rotate += 0.1f;
    }
    public void Speed_Rotate_Down()
    {
        speed_rotate -= 0.1f;
    }
}
