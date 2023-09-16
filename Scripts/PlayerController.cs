using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int maxHP = 100;
    [SerializeField] HeathBar heathBar = default;

    private int currentHP;

    private void Start()
    {
        currentHP = maxHP;
        heathBar.SetMaxHeath(maxHP);
    }

    private void Update()
    {
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        if (currentHP <= 0)
        {
            yield return new WaitForSeconds(.5f);
            SceneManager.LoadScene(2);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        heathBar.SetHeath(currentHP);
    }

    public void HeathRiseUp(int hp)
    {
        if (currentHP < maxHP)
        {
            currentHP += hp;
            if (currentHP  > maxHP)
            {
                currentHP = maxHP;
                heathBar.SetHeath(currentHP);
            }
            else
            {
                heathBar.SetHeath(currentHP);
            }
        }   
    }

    public int GetCurrentHeath()
    {
        return currentHP;
    }

}
