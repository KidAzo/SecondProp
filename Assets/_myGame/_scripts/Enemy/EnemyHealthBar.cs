using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] Image _healthBarSprite;
    Camera _cam;
    [SerializeField] float _reduceSpeed = 2f;
    float _target = 1f;

    void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - _cam.transform.position);
        _healthBarSprite.fillAmount = Mathf.MoveTowards(_healthBarSprite.fillAmount, _target, _reduceSpeed * Time.deltaTime);
    }

    public void UpdateHealthBar(float maxHealth , float currentHealth)
    {
        _target = currentHealth / maxHealth;
    }
}
