namespace FundamentalUpskilling.OOP.Interface;

/*
 * Naming convention class interface harus diawali dengan huruf -> I
 */
public interface IHitAble
{
    void Attack(IHitAble hitAble);
    void GetHit(int damage);
}