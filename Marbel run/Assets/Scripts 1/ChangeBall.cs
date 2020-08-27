using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBall : MonoBehaviour
{
    private GameObject Player;
    static Material PlayerMat;
    public Material FlagMat;
    public Material PrideMat;
    public Material GermanyMat;
    public Material ClassicMat;



    void Start()
    {

    }

    public void FlagBall()
    {
        PlayerMat = FlagMat;
    }
    public void PrideBall()
    {
        PlayerMat = PrideMat;
    }
    public void GermanyBall()
    {
        PlayerMat = GermanyMat;
    }
    public void ClassicBall()
    {
        PlayerMat = ClassicMat;
    }
}
