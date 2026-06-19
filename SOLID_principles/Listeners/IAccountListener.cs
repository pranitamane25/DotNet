namespace SOLID_principles.Listeners;
public interface IAccountListener
{
    void onUnderBalance(double balance);
    void onOverBalance(double balance);

}