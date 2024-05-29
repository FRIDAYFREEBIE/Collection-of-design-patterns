// Subject 인터페이스 (발행자)
public interface ISubject
{
  public void AddObserver(IObserver observer); // 옵저버 추가
  public void RemoveObserver(IObserver observer); // 옵저거 제거
  public void NotifyObserver(string itemName); // 옵저버에게 알림 (notify 전달)
}
