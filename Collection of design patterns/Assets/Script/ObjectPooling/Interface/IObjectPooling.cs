// 오브젝트 풀링 인터페이스
public interface IObjectPooling
{
    public void Initialize(int initCount); // 초기 풀의 크기를 설정해주는 초기화 매서드
    public Bullet CreateNewObject(); // 새로운 오브젝트를 생성 및 반환하는 매서드
    public Bullet GetObject(); // 풀에서 새로운 오브젝트를 가져오는 메서드 
    public void ReturnObject(Bullet bullet); // 오브젝트를 풀에 반환하는 메서드
}
