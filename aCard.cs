using System;

public class aCard
{
    public int value;
    public int face;
    public Image picture;
    public Image[] possibleCards = {Properties.Resources.ac, Properties.Resources._2c, Properties.Resources._3c, Properties.Resources._4c, Properties.Resources._5c, Properties.Resources._6c, Properties.Resources._7c, Properties.Resources._8c, Properties.Resources._9c, Properties.Resources._10c, Properties.Resources.jc, Properties.Resources.qc, Properties.Resources.kc,
                               Properties.Resources._as, Properties.Resources._2s, Properties.Resources._3s, Properties.Resources._4s, Properties.Resources._5s, Properties.Resources._6s, Properties.Resources._7s, Properties.Resources._8s, Properties.Resources._9s, Properties.Resources._10s, Properties.Resources.js, Properties.Resources.qs, Properties.Resources.ks,
                               Properties.Resources.ah, Properties.Resources._2h, Properties.Resources._3h, Properties.Resources._4h, Properties.Resources._5h, Properties.Resources._6h, Properties.Resources._7h, Properties.Resources._8h, Properties.Resources._9h, Properties.Resources._10h, Properties.Resources.jh, Properties.Resources.qh, Properties.Resources.kh,
                               Properties.Resources.ad, Properties.Resources._2d, Properties.Resources._3d, Properties.Resources._4d, Properties.Resources._5d, Properties.Resources._6d, Properties.Resources._7d, Properties.Resources._8d, Properties.Resources._9d, Properties.Resources._10d, Properties.Resources.jd, Properties.Resources.qd, Properties.Resources.kd};

    public aCard(int cardNum)
    {
        value = cardNum % 13;
        face = cardNum % 4;
        picture = possibleCards[cardNum];

    }
}
