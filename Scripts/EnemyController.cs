using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
	[SerializeField] int maxHP = 100;
	[SerializeField] EnemyHeathBar enemyHeathBar = default;

	private int currentHP;

	private void Start()
	{
		currentHP = maxHP;
		enemyHeathBar.SetMaxHeath(maxHP);
	}

	private void Update()
	{
		StartCoroutine(GameWin());
	}

	IEnumerator GameWin()
	{
		if (currentHP <= 0)
		{
			yield return new WaitForSeconds(.5f);
			SceneManager.LoadScene(4);
		}
	}

	public void EnemyTakeDamage(int damage)
	{
		currentHP -= damage;
		enemyHeathBar.SetHeath(currentHP);
	}

	public void EnemyHeathRiseUp(int hp)
	{
		if (currentHP < maxHP)
		{
			currentHP += hp;
			if (currentHP > maxHP)
			{
				currentHP = maxHP;
				enemyHeathBar.SetHeath(currentHP);
			}
			else
			{
				enemyHeathBar.SetHeath(currentHP);
			}
		}
	}

	public int GetCurrentHeath()
	{
		return currentHP;
	}
}
