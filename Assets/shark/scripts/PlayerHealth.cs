using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public float maxHealth = 100f;
    public static float health;
    public GameObject deathCanvas;
    public AudioSource bite;
     
    void Start ()
    {
        health = maxHealth;
        bite.Play();
    }
    private void Update() 
    {
        if(health < 1)
        {
        
           SceneManager.LoadScene(1);
        }
    }
 
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health/maxHealth;
    }
}
