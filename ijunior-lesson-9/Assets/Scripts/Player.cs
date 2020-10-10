using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text _healthValue;
    [SerializeField] private HealthBar _healthBar;

    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    public float maxHealth => _maxHealth;
    public float minHealth => _minHealth;
    public float currentHealth => _currentHealth;

    void Update()
    {
        _healthValue.text = _currentHealth.ToString("0");
       
        if (_currentHealth >= _maxHealth)
        {
            _currentHealth = _maxHealth;
            _healthBar.SetHealthSlider(_currentHealth);
        }

        if (_currentHealth <= _minHealth)
        {
            _currentHealth = _minHealth;
            _healthBar.SetHealthSlider(_currentHealth);
        }
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        _healthBar.SetHealthSlider(_currentHealth);
    }

    public void SetHealth(float health)
    {
        _currentHealth += health;
        _healthBar.SetHealthSlider(_currentHealth);
    }
}
