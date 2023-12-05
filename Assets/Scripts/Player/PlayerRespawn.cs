using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    Animator animator;
    [SerializeField] private GameObject[] hearts;

    int life = 4;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        life = hearts.Length;
        
        
    }


    public void playerHasDamage()
    {
        animator.SetTrigger("Hit");
        life--;
        updateHealth();
    }

    public void updateHealth()
    {
        if(life==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        else  if (life<1)
        {
            int lastIndex = hearts.Length - 1;
            Destroy(hearts[lastIndex]);
            hearts = hearts.Take(lastIndex).ToArray();
            
        }
        else if (life<2)
        {
            int lastIndex = hearts.Length - 1;
            Destroy(hearts[lastIndex]);
            hearts = hearts.Take(lastIndex).ToArray();
        }
        else if (life<3)
        {
            int lastIndex = hearts.Length - 1;
            Destroy(hearts[lastIndex]);
            hearts = hearts.Take(lastIndex).ToArray();
        }

    }
}
