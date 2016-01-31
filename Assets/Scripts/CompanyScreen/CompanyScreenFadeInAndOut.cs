using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CompanyScreenFadeInAndOut : MonoBehaviour
{
    int state = 0;
    float alpha = 0.0f;
    // assigned in inspector
    public Image companyScreenImage;

    float alphaFadeSpeed = 1.0f;
    float holdAmountOfTime = 1.0f;

    float holdTimer = 0.0f;

    void Start()
    {
        if (companyScreenImage == null) return;
        companyScreenImage.color = new Color(companyScreenImage.color.r, companyScreenImage.color.g, companyScreenImage.color.b, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (companyScreenImage == null) return;

        if(state == 0)
        {
            alpha += alphaFadeSpeed * Time.deltaTime;
            companyScreenImage.color = new Color(companyScreenImage.color.r, companyScreenImage.color.g, companyScreenImage.color.b, alpha);
            if(alpha >= 1.0f)
            {
                alpha = 1.0f;
                state = 1;
            }
        }

        if(state == 1)
        {
            holdTimer += 1.0f * Time.deltaTime;
            if(holdTimer >= holdAmountOfTime)
            {
                holdTimer = 0f;
                state = 2;
            }
        }

        if(state == 2)
        {
            alpha -= alphaFadeSpeed * Time.deltaTime;
            companyScreenImage.color = new Color(companyScreenImage.color.r, companyScreenImage.color.g, companyScreenImage.color.b, alpha);
            if (alpha <= 0.0f)
            {
                alpha = 0.0f;
                state = 3;
            }
        }

        if(state == 3)
        {
            Application.LoadLevel("TitleScreen");
            state = 0;
        }
    }
}
