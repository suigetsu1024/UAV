using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject UI_first_right_feixingcanshu_light;
    public GameObject UI_first_right_ganzhishezhi_light;
    public GameObject UI_first_right_yaokongqigongnengshezhi_light;
    public GameObject UI_first_right_tuchuanshezhi_light;
    public GameObject UI_first_right_zhinengdianchixinxi_light;
    public GameObject UI_first_right_tongyongshezhi_light;
    public GameObject UI_first_right_feixingcanshu;
    public GameObject UI_first_right_feixingcan_gaojishezhi;
    public GameObject UI_first_right_feixingcan_gaojishezhi_exp;
    public GameObject UI_first_right_feixingcan_gaojishezhi_lingmindu;
    public GameObject UI_first_right_feixingcan_gaojishezhi_gandu;
    public GameObject UI_first_right_feixingcan_gaojishezhi_chuanganqizhuangtai_IMU;
    public GameObject UI_first_right_feixingcan_gaojishezhi_chuanganqizhuangtai_zhinanzhen;
    public GameObject UI_first_right_ganzhishezhi;
    public GameObject UI_first_right_ganzhishezhi_gaojishezhi;
    public GameObject UI_first_right_yaokongqigongnengshezhi;
    public GameObject UI_first_right_yaokongqigongnengshezhi_yaokongqijiaozhun;
    public GameObject UI_first_right_yaokongqigongnengshezhi_yaoganmoshi;
    public GameObject UI_first_right_tuchuanshezhi;
    public GameObject UI_first_right_zhinengdianchixinxi;
    public GameObject UI_first_right_zhinengdianchixinxi_dianchixiangxixinxi;
    public GameObject UI_first_right_tongyongshezhi;
    public GameObject UI_first_right_tongyongshezhi_xuanzezhibopingtai;
    public GameObject UI_first_right_tongyongshezhi_tishixinxijilu;
    public GameObject UI_first_right_tongyongshezhi_shebeimingcheng;
    public GameObject UI_first_right_tongyongshezhi_guanyu;
    public GameObject UI_first_top;
    public GameObject UI_first_left;
    public GameObject UI_first_right;
    public GameObject camera_first;
    public GameObject camera_third;
    public GameObject wing_1;
    public GameObject wing_2;
    public GameObject wing_3;
    public GameObject wing_4;
    public GameObject dajiang;
    public float count = 1.0f;
    public GameObject RedPoint;
    public bool camera_bool=true;
    public bool UP=false;
    public GameObject UI_first;
    public GameObject UI_second;
    public bool UI_bool=true;
    public bool wing_bool;
    void Start()
    {
        wing_bool = true;
        //Wing_start();
        //Dajiang_AutoUp();
    }
    void Update()
    {
        //dajiang.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 8.0f);
        //if (count <= 450)
        //    count += 1.0f;
        //else
        //    if(dajiang.transform.position.y<=15)
        //    dajiang.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 8.4f);
        //wing_1.transform.Rotate(0, 0, count * 0.1f);
        //wing_2.transform.Rotate(0, 0, count * 0.1f);
        //wing_3.transform.Rotate(0, 0, count * 0.1f);
        //wing_4.transform.Rotate(0, 0, count * 0.1f);
        if(UP)
        {
            if (dajiang.transform.position.y <= 15+ 22.226f)
            {
                dajiang.transform.Translate(Vector3.up * 0.01f);
            }
            else
            {
                dajiang.transform.position = new Vector3(dajiang.transform.position.x, 15+ 22.226f, dajiang.transform.position.z);
                UP = false;
            }

        }
    }
    public void Initialization()
    {
        UI_first_right_feixingcanshu_light.SetActive(false);
        UI_first_right_ganzhishezhi_light.SetActive(false);
        UI_first_right_yaokongqigongnengshezhi_light.SetActive(false);
        UI_first_right_tuchuanshezhi_light.SetActive(false);
        UI_first_right_zhinengdianchixinxi_light.SetActive(false);
        UI_first_right_tongyongshezhi_light.SetActive(false);
        UI_first_right_feixingcanshu.SetActive(false);
        UI_first_right_feixingcan_gaojishezhi.SetActive(false);
        UI_first_right_feixingcan_gaojishezhi_exp.SetActive(false);
        UI_first_right_feixingcan_gaojishezhi_lingmindu.SetActive(false);
        UI_first_right_feixingcan_gaojishezhi_gandu.SetActive(false);
        UI_first_right_feixingcan_gaojishezhi_chuanganqizhuangtai_IMU.SetActive(false);
        UI_first_right_feixingcan_gaojishezhi_chuanganqizhuangtai_zhinanzhen.SetActive(false);
        UI_first_right_ganzhishezhi.SetActive(false);
        UI_first_right_ganzhishezhi_gaojishezhi.SetActive(false);
        UI_first_right_yaokongqigongnengshezhi.SetActive(false);
        UI_first_right_yaokongqigongnengshezhi_yaokongqijiaozhun.SetActive(false);
        UI_first_right_yaokongqigongnengshezhi_yaoganmoshi.SetActive(false);
        UI_first_right_tuchuanshezhi.SetActive(false);
        UI_first_right_zhinengdianchixinxi.SetActive(false);
        UI_first_right_zhinengdianchixinxi_dianchixiangxixinxi.SetActive(false);
        UI_first_right_tongyongshezhi.SetActive(false);
        UI_first_right_tongyongshezhi_xuanzezhibopingtai.SetActive(false);
        UI_first_right_tongyongshezhi_tishixinxijilu.SetActive(false);
        UI_first_right_tongyongshezhi_shebeimingcheng.SetActive(false);
        UI_first_right_tongyongshezhi_guanyu.SetActive(false);
        UI_first_top.SetActive(false);
        UI_first_left.SetActive(false);
        UI_first_right.SetActive(false);
    }
    public void Button_feixingcanshu()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_feixingcanshu_light.SetActive(true);
        UI_first_right_feixingcanshu.SetActive(true);
        UI_first_right_feixingcanshu.GetComponent<Scrollbar>().value = 1;
        UI_first_right_feixingcanshu.GetComponent<Scrollbar>().size = 0.736f;
    }
    public void Button_feixingcan_gaojishezhi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_feixingcanshu_light.SetActive(true);
        UI_first_right_feixingcan_gaojishezhi.SetActive(true);
        UI_first_right_feixingcan_gaojishezhi.GetComponent<Scrollbar>().value = 1;
        UI_first_right_feixingcan_gaojishezhi.GetComponent<Scrollbar>().size = 0.875f;
    }
    public void Button_feixingcan_gaojishezhi_exp()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_feixingcanshu_light.SetActive(true);
        UI_first_right_feixingcan_gaojishezhi_exp.SetActive(true);
    }
    public void Button_feixingcan_gaojishezhi_lingmindu()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_feixingcanshu_light.SetActive(true);
        UI_first_right_feixingcan_gaojishezhi_lingmindu.SetActive(true);
    }
    public void Button_feixingcan_gaojishezhi_gandu()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_feixingcanshu_light.SetActive(true);
        UI_first_right_feixingcan_gaojishezhi_gandu.SetActive(true);
    }
    public void Button_feixingcan_gaojishezhi_chuanganqizhuangtai_IMU()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_feixingcanshu_light.SetActive(true);
        UI_first_right_feixingcan_gaojishezhi_chuanganqizhuangtai_IMU.SetActive(true);
    }
    public void Button_feixingcan_gaojishezhi_chuanganqizhuangtai_zhinanzhen()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_feixingcanshu_light.SetActive(true);
        UI_first_right_feixingcan_gaojishezhi_chuanganqizhuangtai_zhinanzhen.SetActive(true);
    }
    public void Button_ganzhishezhi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_ganzhishezhi_light.SetActive(true);
        UI_first_right_ganzhishezhi.SetActive(true);
        UI_first_right_ganzhishezhi.GetComponent<Scrollbar>().value = 1;
        UI_first_right_ganzhishezhi.GetComponent<Scrollbar>().size = 0.864f;
    }
    public void Button_ganzhishezhi_gaojishezhi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_ganzhishezhi_light.SetActive(true);
        UI_first_right_ganzhishezhi_gaojishezhi.SetActive(true);
    }
    public void Button_yaokongqigongnengshezhi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi_light.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi.GetComponent<Scrollbar>().value = 1;
        UI_first_right_yaokongqigongnengshezhi.GetComponent<Scrollbar>().size = 0.828f;
    }
    public void Button_yaokongqigongnengshezhi_yaokongqijiaozhun()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi_light.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi_yaokongqijiaozhun.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi_yaokongqijiaozhun.GetComponent<Scrollbar>().value = 1;
        UI_first_right_yaokongqigongnengshezhi_yaokongqijiaozhun.GetComponent<Scrollbar>().size = 0.806f;
    }
    public void Button_yaokongqigongnengshezhi_yaoganmoshi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi_light.SetActive(true);
        UI_first_right_yaokongqigongnengshezhi_yaoganmoshi.SetActive(true);
    }
    public void Button_tuchuanshezhi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_tuchuanshezhi_light.SetActive(true);
        UI_first_right_tuchuanshezhi.SetActive(true);
        UI_first_right_tuchuanshezhi.GetComponent<Scrollbar>().value = 1;
        UI_first_right_tuchuanshezhi.GetComponent<Scrollbar>().size = 0.815f;
    }
    public void Button_zhinengdianchixinxi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_zhinengdianchixinxi_light.SetActive(true);
        UI_first_right_zhinengdianchixinxi.SetActive(true);
        UI_first_right_zhinengdianchixinxi.GetComponent<Scrollbar>().value = 1;
        UI_first_right_zhinengdianchixinxi.GetComponent<Scrollbar>().size = 0.727f;
    }
    public void Button_zhinengdianchixinxi_dianchixiangxixinxi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_zhinengdianchixinxi_light.SetActive(true);
        UI_first_right_zhinengdianchixinxi_dianchixiangxixinxi.SetActive(true);
    }
    public void Button_tongyongshezhi()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_tongyongshezhi_light.SetActive(true);
        UI_first_right_tongyongshezhi.SetActive(true);
        UI_first_right_tongyongshezhi.GetComponent<Scrollbar>().value = 1;
        UI_first_right_tongyongshezhi.GetComponent<Scrollbar>().size = 0.5884f;
    }
    public void Button_tongyongshezhi_xuanzezhibopingtai()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_tongyongshezhi_light.SetActive(true);
        UI_first_right_tongyongshezhi_xuanzezhibopingtai.SetActive(true);
    }
    public void Button_tongyongshezhi_tishixinxijilu()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_tongyongshezhi_light.SetActive(true);
        UI_first_right_tongyongshezhi_tishixinxijilu.SetActive(true);
    }
    public void Button_tongyongshezhi_shebeimingcheng()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_tongyongshezhi_light.SetActive(true);
        UI_first_right_tongyongshezhi_shebeimingcheng.SetActive(true);
    }
    public void Button_tongyongshezhi_tongyongshezhi_guanyu()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_right_tongyongshezhi_light.SetActive(true);
        UI_first_right_tongyongshezhi_guanyu.SetActive(true);
        UI_first_right_tongyongshezhi_guanyu.GetComponent<Scrollbar>().value = 1;
        UI_first_right_tongyongshezhi_guanyu.GetComponent<Scrollbar>().size = 0.898f;
    }
    public void Right_close()
    {
        Initialization();
        UI_first_right.SetActive(true);
        UI_first_top.SetActive(true);
        UI_first_left.SetActive(true);
    }

    public void Camera_Change()
    {
        if(camera_bool)
        {
            camera_first.SetActive(false);
            camera_third.SetActive(true);
            RedPoint.SetActive(false);
            camera_bool = false;
        }
        else
        {
            camera_first.SetActive(true);
            camera_third.SetActive(false);
            RedPoint.SetActive(true);
            camera_bool = true;
        }
    }
    public void Wing_Start()
    {
        if (wing_bool)
        {
            wing_1.GetComponent<Animator>().SetBool("RotateCtrl", true);
            wing_2.GetComponent<Animator>().SetBool("RotateCtrl", true);
            wing_3.GetComponent<Animator>().SetBool("RotateCtrl", true);
            wing_4.GetComponent<Animator>().SetBool("RotateCtrl", true);
        }
    }
    public void Dajiang_AutoUp()
    {
        Wing_Start();
        UP = true;
    }
    public void UI_change()
    {
        if(UI_bool)
        {
            UI_first.SetActive(false);
            UI_second.SetActive(true);
            UI_bool = false;
        }
        else
        {
            UI_first.SetActive(true);
            UI_second.SetActive(false);
            UI_bool = true;
        }
    }
}
