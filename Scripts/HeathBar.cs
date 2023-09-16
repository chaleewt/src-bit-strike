using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathBar : MonoBehaviour
{
    [SerializeField] Slider heathBar = default;

    // To make it possible to set MaxValue&Value in other script.
    public void SetMaxHeath(int heath) // เซตเลือดจากสคิปอื่น จะได้ไม่ต้องเข้าไปเซตที่ inspector ของ HeathBar OBJ
    {
        heathBar.maxValue = heath;
        heathBar.value = heath;
    }

    public void SetHeath(int heath) // แสดงสถานะเลือดเมื่อเกิดการเปลี่ยนแปลง
    {
        heathBar.value = heath;
    }
}
