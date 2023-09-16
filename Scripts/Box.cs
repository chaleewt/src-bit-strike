using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] int boxHP = 1;
    [SerializeField] float fallingSpeed = 0.5f;
    [SerializeField] float sfVolume = 5f;
    [SerializeField] GameObject explodeVFX = default;
    [SerializeField] AudioClip explodeSFX = default;

    GameController _GameController = default;
    PlayerController _PlayerController = default;
    EnemyController _EnemyController = default;

    private void Start()
    {
        _GameController = FindObjectOfType<GameController>();
        _PlayerController = FindObjectOfType<PlayerController>();
        _EnemyController = FindObjectOfType<EnemyController>();
    }

    private void Update()
    {
        DestroyBox();
        FallingDown();
    }

    private void DestroyBox() // Destroy yourself if condition is match
    {
        if (_GameController.GetFinalPoint() == boxHP)
        {
            Destroy(gameObject);
            _PlayerController.HeathRiseUp(boxHP);

            var VFX = Instantiate(explodeVFX, transform.position, transform.rotation);
            Destroy(VFX.gameObject, 1f);

            MakeExplosionSFX(); // SFX

            // Enemy take damage
            _EnemyController.EnemyTakeDamage(boxHP);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // Destroy yourself if hit DeathZone
    {
        Destroy(gameObject);
        _PlayerController.TakeDamage(boxHP);
        _EnemyController.EnemyHeathRiseUp(boxHP);

        var VFX = Instantiate(explodeVFX, transform.position, transform.rotation);
        Destroy(VFX.gameObject, 1f);

        MakeExplosionSFX();
    }

    private void CreateExplosionVFX()
    {
        // VFX เมื่อถูกสร้างมันจะเป็นเอกเทศน์ เมื่อ Box ถูกทำลายแต่ตัวมันยังคงอยู่ เพราะเกิดจากคำสั่งสร้างให้ Obj ปรากฎ
        // นี่คือตัวอย่างคำสั่งให้มันทำลายตัวเองภายใน 2 วิ
        var VFX = Instantiate(explodeVFX, transform.position, transform.rotation);
        Destroy(VFX.gameObject, 1f);
    }

    private void MakeExplosionSFX()
    {
        AudioSource.PlayClipAtPoint(explodeSFX, new Vector3(0, 0, 0), sfVolume);
    }

    private void FallingDown() // Box moving down
    {
        transform.Translate(Vector2.down * Time.deltaTime * fallingSpeed);
    }
}
