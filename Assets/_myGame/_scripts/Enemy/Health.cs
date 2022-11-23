using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float _maxhealth;
    float _currenthealth;
    [SerializeField] EnemyHealthBar _healthBar;
    Enemy _enemy;

    void Awake()
    {
        _enemy = GetComponent<Enemy>();
        _currenthealth = _maxhealth;
        _healthBar.UpdateHealthBar(_maxhealth, _currenthealth);
    }

    public void TakeDamage(float attackDamage)
    {
        _currenthealth -= attackDamage;
        _healthBar.UpdateHealthBar(_maxhealth, _currenthealth);
        if (_currenthealth > 0) return;

        this.gameObject.SetActive(false);
        EnemyDedector.Instance.EnemyList.Remove(_enemy);
        EnemyDedector.Instance.HealthList.Remove(this);
    }
}
