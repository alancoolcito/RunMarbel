using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBall : MonoBehaviour
{
    public static Material PlayerMat;
    public Material FlagMat;
    public Material PrideMat;
    public Material GermanyMat;
    public Material OceanicMat;
    public Material BlackMat;
    public Material ClassicMat;

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
    public void OceanicBall()
    {
        PlayerMat = OceanicMat;
    }
    public void BlackBall()
    {
        PlayerMat = BlackMat;
    }
    public void ClassicBall()
    {
        PlayerMat = ClassicMat;
    }
}
